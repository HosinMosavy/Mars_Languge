using Mars_Languge.Main.Class_dll;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mars_Language.Main.Class_dll
{
    internal class Parser
    {
        private List<Lexer.Token> _tokens;
        private int _position = 0;
        private Dictionary<string, object> _variables = new Dictionary<string, object>();

        public Parser(List<Lexer.Token> tokens)
        {
            _tokens = tokens;
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
                    throw new Exception($"Unexpected token {current.Value} at position {_position}");
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

            Console.WriteLine(_variables[varName]);

            Expect("Symbol", ";");
        }

        private void Expect(string type, string? value = null)
        {
            var token = _tokens[_position];
            if (token.Type != type || (value != null && token.Value != value))
                throw new Exception($"Expected {type} {value} but got {token.Type} {token.Value}");

            _position++;
        }
    }
}
