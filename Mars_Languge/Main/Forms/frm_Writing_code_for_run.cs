using Mars_Language.Main.Class_dll;
using System;
using System.Windows.Forms;

namespace Mars_Languge.Main.Forms
{
    public partial class frm_Writing_code_for_run : Form
    {
        public frm_Writing_code_for_run()
        {
            InitializeComponent();
        }
        //Introducing the necessary classes //  معرفی کلاس های لازم
        cl_Lexer Lexer = new cl_Lexer();
        
        //-------------------------------------------------------

        //button Run project/languge----دکمه اجرا پروژه/زبان----------------------------------
        private void btnRun_Click(object sender, EventArgs e)
        {
           
            try
            {
                // مرحله 1: Lexer
                var lexer = new cl_Lexer.Lexer1(txtCode.Text);
                var tokens = lexer.Tokenize();

                // نمایش توکن‌ها
                txtOutput.Clear();
                txt_lexser.Clear();
                foreach (var token in tokens)
                    txt_lexser.AppendText(token.ToString() + Environment.NewLine);

                // مرحله 2: Parser و اجرای کد
                txtOutput.Text = "OutPut >>>  ";
                var parser = new cl_Parser(tokens, txtOutput); // RichTextBox
                parser.Parse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mars Language Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    //------------------------------------------------------------------------------------
}
}
