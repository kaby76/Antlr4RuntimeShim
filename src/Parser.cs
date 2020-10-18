using System;
using System.IO;
using Antlr4.Runtime;

namespace CompatShim
{
    public class Parser : Antlr4.Runtime.Parser
    {
        // Required by Antlr4.Runtime.Parser.
        public Parser(ITokenStream input) : base(input)
        {
        }

        public Parser(ITokenStream input, TextWriter output, TextWriter errorOutput) : base(input, output, errorOutput)
        {
        }

        public override string[] RuleNames { get; }
        public override string GrammarFileName { get; }
        public override IVocabulary Vocabulary { get; }


        // Compat layer.
        protected TokenStream _input
        {
            get { return new TokenStream(this.TokenStream); }
        }
    }
}
