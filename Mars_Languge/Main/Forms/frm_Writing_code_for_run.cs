using Mars_Language.Main.Class_dll;
using Mars_Languge.Main.Class_dll;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Mars_Languge.Main.Forms
{
    // ایمپورت توابع ویندوز
    

    public partial class frm_Writing_code_for_run : Form
    {
        public frm_Writing_code_for_run()
        {
            InitializeComponent();

        }
        //--------------control panell-------------------------------------------
        // ایمپورت توابع ویندوز
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //---------------------------------------------------------

        //Introducing the necessary classes //  معرفی کلاس های لازم
        cl_Lexer Lexer = new cl_Lexer();
        private int secondsElapsed = 0; // تعداد ثانیه‌های گذشته
        //-------------------------------------------------------

        //button Run project/languge----دکمه اجرا پروژه/زبان----------------------------------
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
      //--------------------------------
        private void frm_Writing_code_for_run_Load(object sender, EventArgs e)
        {
            secondsElapsed = 0;
            timer1.Start(); // تایمر رو روشن کن

        }
       

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

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

    

      

        //------------------------------------------------------------------------------------
    }
}
