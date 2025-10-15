using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mars_Languge.Main.Class_dll
{
    internal class cl_SyntaxHighlighter
    {
        private RichTextBox _richTextBox;
        private TextBox txtCode;

        public cl_SyntaxHighlighter(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _richTextBox.TextChanged += RichTextBox_TextChanged;
            _richTextBox.Font = new Font("Consolas", 12); // فونت ثابت برای کد
        }

        public cl_SyntaxHighlighter(TextBox txtCode)
        {
            this.txtCode = txtCode;
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int selStart = _richTextBox.SelectionStart;
            int selLength = _richTextBox.SelectionLength;

            // جلوگیری از flicker
            _richTextBox.SuspendLayout();

            // Reset رنگ‌ها
            _richTextBox.SelectAll();
            _richTextBox.SelectionColor = Color.Black;

            string text = _richTextBox.Text;

            // Regex ها
            HighlightPattern(@"\b(int|string|float|bool)\b", Color.Orange);       // نوع داده‌ها
            HighlightPattern(@"\b(print)\b", Color.Purple);                       // توابع مهم
            HighlightPattern(@"\b(if|else|for|while|return)\b", Color.Blue);     // کلمات کلیدی
            HighlightPattern("\".*?\"", Color.Green);                              // رشته‌ها
            HighlightPattern(@"//.*?$", Color.Gray, RegexOptions.Multiline);       // کامنت‌ها

            _richTextBox.SelectionStart = selStart;
            _richTextBox.SelectionLength = selLength;
            _richTextBox.SelectionColor = Color.Black;

            _richTextBox.ResumeLayout();
        }

        private void HighlightPattern(string pattern, Color color, RegexOptions options = RegexOptions.None)
        {
            foreach (Match m in Regex.Matches(_richTextBox.Text, pattern, options))
            {
                _richTextBox.Select(m.Index, m.Length);
                _richTextBox.SelectionColor = color;
            }
        }
    }
}
