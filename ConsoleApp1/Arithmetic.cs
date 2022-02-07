using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arithmetic
    {

        public int sum(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int mul(int x, int y)
        {
            return x * y;
        }


        public virtual bool CheckDigitsOnly()
        {
            return false;
        }


    }
}
