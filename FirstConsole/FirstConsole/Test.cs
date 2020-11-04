using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Test
    {
       static void Main()
        {
            int i = 100;
            /* float f,f1;
             f = i;        //implicit conversion
             f1 = 12365678.45f;
             i =(int)f1;   //Explicit conversion
             Console.WriteLine(i);

             Console.WriteLine(f);

             string str = "100gg";
             //  i = Convert.ToInt32(str);
             // i = int.tryParse(str);
             int rval = 0;
             bool status = int.TryParse(str, out rval); //used to handle exception raised by parse
             if (status)
             {
                 Console.WriteLine(rval);
             }
             else
             {
                 Console.WriteLine("Invalid data, cannot Parse");
             }
             Console.Read();
            int x = 10;
            object o;
            o = x;  //boxing(value type to object type)
            string s = "AAA";
            o = s; //implicit

            float salary;
            salary = float.Parse(Console.ReadLine()); //unboxing
            bool b;
            b = Convert.ToBoolean(Console.ReadLine());//unboxing
            DateTime dt;
            dt = Convert.ToDateTime(Console.ReadLine());//unboxing*/
         //   Class1 c = new Class1();
         //  c.Welcomemsg("Banurekha");
          //  Console.WriteLine(c.Calc(5, 6));
           Console.WriteLine("Hello from Library");
            Console.Read();



        }

    }
}
