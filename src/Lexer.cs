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
        protected CharStream _input
        {
            get { return new CharStream(this.InputStream); }
        }

    }
}
