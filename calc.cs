using System;

namespace Test
{

    public class T1
    {

        private int a { get; set; }
        private int c { get; set; }

        public T1(int a, int c)
        {
            this.a = a;
            this.c = c;
        }

        public int m1()
        {
            return a + c;
        }

    }
}
