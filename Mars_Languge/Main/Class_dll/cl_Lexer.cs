using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mars_Language.Main.Class_dll
{
    internal class cl_Lexer
    {
        public class Token
        {
            public string Type { get; set; }
            public string Value { get; set; }
            public override string ToString() => $"{Type}: {Value}";
        }

        public class Lexer1
        {
            private string _input;
            public Lexer1(string input) => _input = input;

            public List<Token> Tokenize()
            {
                var tokens = new List<Token>();

                var rules = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Type", @"\b(int|string|float|bool)\b"),
                    new KeyValuePair<string, string>("Keyword", @"\b(print)\b"),
                    new KeyValuePair<string, string>("Identifier", @"[a-zA-Z_]\w*"),
                    new KeyValuePair<string, string>("Number", @"\b\d+(\.\d+)?\b"),
                    new KeyValuePair<string, string>("String", "\".*?\""),
                    new KeyValuePair<string, string>("Operator", @"[=+\-*/]"),
                    new KeyValuePair<string, string>("Symbol", @"[;]"),
                    new KeyValuePair<string, string>("Whitespace", @"\s+")
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
                        throw new Exception($"Unexpected character: '{_input[index]}' at position {index}");
                }

                return tokens;
            }
        }
    }
}
