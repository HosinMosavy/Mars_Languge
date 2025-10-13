using Mars_Languge.Main.Class_dll;
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
        Mars_Languge.Main.Class_dll.Lexer Lexer = new Mars_Languge.Main.Class_dll.Lexer();
        //-------------------------------------------------------
        
        //button Run project/languge----دکمه اجرا پروژه/زبان----------------------------------
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text;
                var lexer = new Lexer.Lexer1(code);
                var tokens = lexer.Tokenize();

                txtOutput.Clear();
                foreach (var token in tokens)
                {
                    txt_lexser.AppendText(token.ToString() + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lexer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------
    }
}
