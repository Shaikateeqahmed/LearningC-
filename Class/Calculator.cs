using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
  //we cann't write methods or var in namespace we need to have classes for that
    internal class Calculator
    {
        public int a;
        public int b;
        public int add() { return a + b; }
    }

    static class Cal
    {
        internal static int add(int a, int b) { return a + b; }
    }
}
