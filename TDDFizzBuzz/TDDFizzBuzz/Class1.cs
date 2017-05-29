using System;

namespace TDDFizzBuzz
{
    public class Class1
    {
        public object FB(int p)
        {
            if (p % 3 == 0 && p % 5 == 0) return "fizzbuzz";
            if (p % 3 == 0) return "fizz";
            if (p % 5 == 0) return "buzz";
            if (p < 1) throw new IndexOutOfRangeException();
            return p;
        }
    }
}
