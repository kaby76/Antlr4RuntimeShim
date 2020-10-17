using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompatShim
{
    public class CharStream : Antlr4.Runtime.ICharStream
    {
        public void Consume()
        {
            throw new NotImplementedException();
        }

        public int LA(int i)
        {
            return inputStream.LA(i);
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
        public string GetText(Antlr4.Runtime.Misc.Interval interval)
        {
            throw new NotImplementedException();
        }

        // Compat layer.
        private IIntStream inputStream;

        public CharStream(IIntStream inputStream)
        {
            this.inputStream = inputStream;
        }
    }
}
