using Mars_Languge.Main.Forms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Mars_Languge.Main.Class_dll
{
    internal class Lexer
    {
        
        public class Token
        {
            public string Type { get; set; }
            public string Value { get; set; }
            public override string ToString() => $"{Type}: {Value}";
        }
        
        // Lexer برای تحلیل متن و تولید توکن‌ها
        public class Lexer1
        {
            private string _input;
            public Lexer1(string input) => _input = input;

            public List<Token> Tokenize()
            {
                var tokens = new List<Token>();

                var rules = new Dictionary<string, string>
                {
                    { "Type", @"\b(int|string|float|bool)\b" },
                    { "Identifier", @"[a-zA-Z_]\w*" },
                    { "Number", @"\b\d+(\.\d+)?\b" },
                    { "String", "\".*?\"" },
                    { "Operator", @"[=+\-*/]" },
                    { "Keyword", @"\b(print)\b" },
                    { "Symbol", @"[;]" },
                    { "Whitespace", @"\s+" }
                };

                int index = 0;
                while (index < _input.Length)
                {
                    bool matched = false;

                    foreach (var rule in rules)
                    {
                        var match = Regex.Match(_input.Substring(index), $"^{rule.Value}");
                        if (match.Success)
                        {
                            if (rule.Key != "Whitespace")
                                tokens.Add(new Token { Type = rule.Key, Value = match.Value });

                            index += match.Length;
                            matched = true;
                            break;
                        }
                    }
                    
                    if (!matched)
                    {
                        throw new Exception($"Unexpected character: {_input[index]} at position {index}");

                    }
                       
                }

                return tokens;
            }
        }
    }
}
