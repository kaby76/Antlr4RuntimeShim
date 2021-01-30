using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Antlr4.Runtime;

namespace CompatShim
{
    public class Lexer : Antlr4.Runtime.Lexer
    {
        public Lexer(ICharStream input) : base(input)
        {
        }

        public Lexer(ICharStream input, TextWriter output, TextWriter errorOutput) : base(input, output, errorOutput)
        {
        }

        public override string[] RuleNames { get; }
        public override string GrammarFileName { get; }
        public override IVocabulary Vocabulary { get; }

        // Compat layer.
        public new const int DEFAULT_MODE = Antlr4.Runtime.Lexer.DEFAULT_MODE;
        //public const int MORE = Antlr4.Runtime.;
        //public const int SKIP = Antlr4.Runtime.;
        public const int DEFAULT_TOKEN_CHANNEL = Antlr4.Runtime.TokenConstants.DefaultChannel;
        public const int HIDDEN = Antlr4.Runtime.TokenConstants.HiddenChannel;
        public const int MIN_CHAR_VALUE = Antlr4.Runtime.Lexer.MinCharValue;
        public const int MAX_CHAR_VALUE = Antlr4.Runtime.Lexer.MaxCharValue;
        protected CharStream _input
        {
            get { return new CharStream(this.InputStream); }
        }

    }
}
