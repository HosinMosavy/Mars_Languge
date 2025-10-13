using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mars_Language.Main.Class_dll
{
    internal class cl_Parser
    {
        private List<cl_Lexer.Token> _tokens;
        private int _position = 0;
        private Dictionary<string, object> _variables = new Dictionary<string, object>();
        private RichTextBox _outputBox;

        public cl_Parser(List<cl_Lexer.Token> tokens, RichTextBox outputBox = null)
        {
            _tokens = tokens;
            _outputBox = outputBox;
        }

        public void Parse()
        {
            while (_position < _tokens.Count)
            {
                var current = _tokens[_position];

                if (current.Type == "Type")
                    ParseVariableDeclaration();
                else if (current.Type == "Keyword" && current.Value == "print")
                    ParsePrintStatement();
                else
                    throw new Exception($"Unexpected token '{current.Value}' at position {_position}");
            }
        }

        private void ParseVariableDeclaration()
        {
            var type = _tokens[_position].Value;
            _position++;

            var name = _tokens[_position].Value;
            _position++;

            Expect("Operator", "=");

            var valueToken = _tokens[_position];
            _position++;

            object value = null;
            switch (type)
            {
                case "int": value = int.Parse(valueToken.Value); break;
                case "float": value = float.Parse(valueToken.Value); break;
                case "string": value = valueToken.Value.Trim('"'); break;
                case "bool": value = bool.Parse(valueToken.Value); break;
            }

            _variables[name] = value;

            Expect("Symbol", ";");
        }

        private void ParsePrintStatement()
        {
            _position++;
            var varName = _tokens[_position].Value;
            _position++;

            if (!_variables.ContainsKey(varName))
                throw new Exception($"Undefined variable: {varName}");

            var value = _variables[varName];

            // چاپ در RichTextBox
            _outputBox?.AppendText(value + Environment.NewLine);

            Expect("Symbol", ";");
        }

        private void Expect(string type, string value = null)
        {
            if (_position >= _tokens.Count)
                throw new Exception("Unexpected end of input");

            var token = _tokens[_position];
            if (token.Type != type || (value != null && token.Value != value))
                throw new Exception($"Expected {type} '{value}' but got {token.Type} '{token.Value}'");

            _position++;
        }
    }
}
