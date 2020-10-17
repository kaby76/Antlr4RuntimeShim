# Antlr4RuntimeShim
A shim to offer compatibility with the ANTLR4 Java runtime API with C#.

Tired of rewriting semantic predicates in your ANTLR grammar targeted for Jave
into C#? I am. This library is a shim I wrote to allow one to use the same predicate
code--outside of Java-specific syntax and runtime calls--in C#. So code that checks
the input stream for characters will compile in C#. E.g.,

            if (this._input.LA(-1) != c)
                return true;
