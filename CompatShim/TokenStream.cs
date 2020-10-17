using System;
using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime;

namespace CompatShim
{
    public class TokenStream : Antlr4.Runtime.ITokenStream
    {
        private Antlr4.Runtime.ITokenStream _token_stream;

        // Compat layer
        public TokenStream(Antlr4.Runtime.ITokenStream token_stream)
        {
            _token_stream = token_stream;
        }

        Token get(int index)
        {
            throw new NotImplementedException();
        }

        String getText()
        {
            throw new NotImplementedException();
        }


        // Required by Antlr4.Runtime.ITokenStream
        public void Consume()
        {
            throw new NotImplementedException();
        }

        public int LA(int i)
        {
            return _token_stream.LA(i);
        }

        public int Mark()
        {
            throw new NotImplementedException();
        }

        public void Release(int marker)
        {
            throw new NotImplementedException();
        }

        public void Seek(int index)
        {
            throw new NotImplementedException();
        }

        public int Index { get; }
        public int Size { get; }
        public string SourceName { get; }
        public IToken LT(int k)
        {
            throw new NotImplementedException();
        }

        public IToken Get(int i)
        {
            throw new NotImplementedException();
        }

        public string GetText(Antlr4.Runtime.Misc.Interval interval)
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            throw new NotImplementedException();
        }

        public string GetText(RuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public string GetText(IToken start, IToken stop)
        {
            throw new NotImplementedException();
        }

        public ITokenSource TokenSource { get; }
    }
}
