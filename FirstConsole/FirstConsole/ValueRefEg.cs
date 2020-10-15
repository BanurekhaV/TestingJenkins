using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class student
    {
        public int marks1;
        public int marks2;
    }
    class ValueRefEg
    {
        static void Main()
        {
            student s1 = new student();
            s1.marks1 = 80;
            s1.marks2 = 86;
            Console.WriteLine(s1.marks1 + s1.marks2);
            student s2 = new student();
            s2 = s1;
            Console.WriteLine(s2.marks1 + s2.marks2);
            //After Changes to one student
            s1.marks1 = 50;
            s1.marks2 = 60;
            Console.WriteLine("After Reassigning marks of S1");
            Console.WriteLine(s1.marks1 + s1.marks2);
            Console.WriteLine(s2.marks1 + s2.marks2);
            //  var, dynamic
            int a;
            var x=34.678f;
            dynamic d;
            d = 10;
            d = "Rama";
            d = 345.789f;
            d = "12/12/2019";

            Console.Read();
        }

    }
}
