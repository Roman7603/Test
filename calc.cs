using System;

namespace Test
{

    public class T1
    {

        private int a { get; set; }
        private int b { get; set; }

        public T1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int m1()
        {
            return a + b;
        }

    }
}
