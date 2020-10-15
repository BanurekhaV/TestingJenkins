using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    public class Class1
    {
        public int Calc(int x, int y)
        {
            return x * y;

        }
        public void Welcomemsg(string s)
        {
            Console.WriteLine("Hello and welcome :{0} ", s);
            Console.Read();
        }
    }
}
