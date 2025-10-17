using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mars_Language.Main.Class_dll
{
    internal class SyntaxHighlighter
    {
        private RichTextBox _richTextBox;

        public SyntaxHighlighter(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _richTextBox.TextChanged += RichTextBox_TextChanged;
            _richTextBox.Font = new Font("Microsoft Sans Serif", 14); // فونت ثابت برای کد
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int selStart = _richTextBox.SelectionStart;
            int selLength = _richTextBox.SelectionLength;

            _richTextBox.SuspendLayout();

            // ریست کردن رنگ‌ها
            _richTextBox.SelectAll();
            _richTextBox.SelectionColor = Color.White;

            // رنگی کردن کلمات
            HighlightPattern(@"\b(int|string|float|bool)\b", Color.Orange); // نوع داده
            HighlightPattern(@"\b(print)\b", Color.MediumPurple);                 // توابع
            HighlightPattern(@"\b(if|else|for|while|return)\b", Color.SkyBlue); // کلمات کلیدی
            HighlightPattern("\".*?\"", Color.Green);                        // رشته‌ها
            HighlightPattern(@"//.*?$", Color.Silver, RegexOptions.Multiline); // کامنت‌ها
            HighlightPattern(@"(==|!=|<=|>=|<|>|;)", Color.HotPink); // عملگرهای مقایسه‌ای
            HighlightPattern(@"(&&|\|\|)", Color.SaddleBrown);
            HighlightPattern(@"[()]", Color.Red);
            HighlightPattern(@"[{}]", Color.Red);
            HighlightPattern(@"=", Color.Green);




            // بازگرداندن مکان‌نما
            _richTextBox.SelectionStart = selStart;
            _richTextBox.SelectionLength = selLength;
            _richTextBox.SelectionColor = Color.White;

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
