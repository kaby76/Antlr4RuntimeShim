using System;
using System.Collections.Generic;
using System.Text;

namespace CompatShim
{
    public class Interval
    {
        private Antlr4.Runtime.Misc.Interval interval;




        public int a
        {
            get { return interval.a; }
        }

        public int b
        {
            get { return interval.b; }
        }

        public static int creates
        {
            get { throw new NotImplementedException(); }
        }

        public static int bits
        {
            get { throw new NotImplementedException(); }
        }
    }
}
