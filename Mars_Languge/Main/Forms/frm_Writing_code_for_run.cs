using Mars_Language.Main.Class_dll;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Mars_Languge.Main.Forms
{
   


    public partial class frm_Writing_code_for_run : Form
    {
        public frm_Writing_code_for_run()
        {
            InitializeComponent();
            lstSuggest.Visible = false;
            txtCode.KeyUp += txtCode_KeyUp;
            lstSuggest.KeyDown += lstSuggest_KeyDown;
            lstSuggest.Click += lstSuggest_Click;
        }

        //---------------------------------------------------------------------------------------
        //-------------------------------------internal class------------------------------------
        //---------------------------------------------------------------------------------------
        private void InsertSuggestion()
        {
            if (lstSuggest.SelectedItem == null) return;
            string selected = lstSuggest.SelectedItem.ToString();
            string word = GetCurrentWord();

            int pos = txtCode.SelectionStart;
            txtCode.Text = txtCode.Text.Remove(pos - word.Length, word.Length);
            txtCode.Text = txtCode.Text.Insert(pos - word.Length, selected);
            txtCode.SelectionStart = pos - word.Length + selected.Length;
            lstSuggest.Visible = false;
        }

        //--------------------------------------

        private string GetCurrentWord()
        {
            int pos = txtCode.SelectionStart;
            int start = pos - 1;
            while (start >= 0 && (char.IsLetterOrDigit(txtCode.Text[start]) || txtCode.Text[start] == '_'))
                start--;
            return txtCode.Text.Substring(start + 1, pos - (start + 1));
        }

        //--------------------------------------

        private void PositionListBox()
        {
            var point = txtCode.GetPositionFromCharIndex(txtCode.SelectionStart);
            point.Y += (int)Math.Ceiling(txtCode.Font.GetHeight());
            lstSuggest.Location = new Point(point.X + txtCode.Left, point.Y + txtCode.Top);
        }
        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------









        ////Introducing the necessary classes //  معرفی کلاس های لازم------------------------------
        List<string> suggestions = new List<string> { "print", "private", "protected", "int", "string", "float", "if", "else", "for", "while" };
        cl_Lexer Lexer = new cl_Lexer();
        private int secondsElapsed = 0; // تعداد ثانیه‌های گذشته
        //---------------------------------------------------------------------------------------
        //--------------control panell-----------------------------------------------------------
        // ایمپورت توابع ویندوز
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //---------------------------------------------------------------------------------------
        //------------------------------------form event /رویداد های فرم-------------------------
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            // تبدیل ثانیه به hh:mm:ss
            TimeSpan time = TimeSpan.FromSeconds(secondsElapsed);
            lbl_time.Text = time.ToString(@"hh\:mm\:ss");
        }
        //---------------------------------------------------------------------------------------
        //--------------------------------------فرم لود------------------------------------------
        private void frm_Writing_code_for_run_Load(object sender, EventArgs e)
        {
            secondsElapsed = 0;
            timer1.Start(); // تایمر رو روشن کن
            /////            
            highlighter = new SyntaxHighlighter(txtCode);

        }
        //---------------------------------------------------------------------------------------
        //---------------------------------------Control Box-------------------------------------
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        //---------------------------------------------------------------------------------------
        //button Run project/languge----دکمه اجرا پروژه/زبان--------------------------------------
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtError.Clear();  // پاک کردن خطاهای قبلی
            txtOutput.Clear(); // پاک کردن خروجی قبلی
            txt_lexser.Clear(); // پاک کردن توکن‌ها

            try
            {
                // مرحله 1: Lexer
                var lexer = new cl_Lexer.Lexer1(txtCode.Text);
                var tokens = lexer.Tokenize();

                // نمایش توکن‌ها
                foreach (var token in tokens)
                    txt_lexser.AppendText(token.ToString() + Environment.NewLine);

                // مرحله 2: Parser و اجرای کد
                var parser = new cl_Parser(tokens, txtOutput); // RichTextBox خروجی
                parser.Parse();
            }
            catch (Exception ex)
            {
                // نمایش خطاها در txtError به جای MessageBox
                txtError.AppendText(ex.Message + Environment.NewLine);
            }


        }
        //---------------------------------------------------------------------------------------
        //---------------------------------------اجرای کلس رنگی کردن متن ها----------------------
        private SyntaxHighlighter highlighter;
        //---------------------------------------------------------------------------------------
        //---------------------------------------txtCode_Event------------------------------------------------
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // اگه کاربر پرانتز باز زد
            if (e.KeyChar == '(')
            {
                int pos = txtCode.SelectionStart; // محل فعلی مکان‌نما
                txtCode.Text = txtCode.Text.Insert(pos, "()"); // اضافه کردن پرانتز بسته
                txtCode.SelectionStart = pos + 1; // مکان‌نما بین پرانتزها قرار بگیره
                e.Handled = true; // جلوگیری از نوشتن دوباره (
            }

            // برای کروشه {}
            else if (e.KeyChar == '{')
            {
                int pos = txtCode.SelectionStart;
                txtCode.Text = txtCode.Text.Insert(pos, "{}");
                txtCode.SelectionStart = pos + 1;
                e.Handled = true;
            }

            // برای کوتیشن ""
            else if (e.KeyChar == '"')
            {
                int pos = txtCode.SelectionStart;
                txtCode.Text = txtCode.Text.Insert(pos, "\"\"");
                txtCode.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }
        //--------------------------------------
        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            // فقط وقتی کاربر حروف تایپ می‌کنه
            if (char.IsLetterOrDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                string word = GetCurrentWord();
                if (word.Length > 0)
                {
                    var matches = suggestions
                        .Where(s => s.StartsWith(word, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (matches.Count > 0)
                    {
                        lstSuggest.Items.Clear();
                        lstSuggest.Items.AddRange(matches.ToArray());
                        lstSuggest.Visible = true;
                        PositionListBox();
                    }
                    else
                        lstSuggest.Visible = false;
                }
                else
                    lstSuggest.Visible = false;
            }
        }

        //--------------------------------------

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            // اگه لیست‌باکس بازه
            if (lstSuggest.Visible)
            {
                if (lstSuggest.Visible)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        if (lstSuggest.SelectedIndex < lstSuggest.Items.Count - 1)
                            lstSuggest.SelectedIndex++;
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        if (lstSuggest.SelectedIndex > 0)
                            lstSuggest.SelectedIndex--;
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Enter)
                    {
                        if (lstSuggest.SelectedItem != null)
                        {
                            string word = lstSuggest.SelectedItem.ToString();

                            // پیدا کردن شروع کلمه‌ای که کاربر در حال تایپشه
                            int pos = txtCode.SelectionStart;
                            int start = pos;

                            // از آخر به عقب می‌ریم تا جایی که فاصله یا خط جدید ببینیم
                            while (start > 0 && !char.IsWhiteSpace(txtCode.Text[start - 1]))
                                start--;

                            int length = pos - start;

                            // حذف اون بخش و جایگزینی با کلمه پیشنهادی
                            txtCode.Select(start, length);
                            txtCode.SelectedText = word + " ";

                            lstSuggest.Visible = false;
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------
        //---------------------------Suggest List event---------------------------------------

        private void lstSuggest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertSuggestion();
            }
        }

        //--------------------------------------

        private void lstSuggest_Click(object sender, EventArgs e)
        {
            InsertSuggestion();
        }
        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------
      

       
    }
}
