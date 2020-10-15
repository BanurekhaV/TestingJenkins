using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace FirstConsole
    
{
    class Program
    {
      static void Main()
        {
            /* Console.WriteLine("Hello Welcome to C Sharp programming");
               Console.WriteLine("Please enter your Name:");
             string name=Console.ReadLine();
               Console.WriteLine("Please enter your Age:");
              int age=Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Youe Name is :{0} and your Age is :{1} ", name,age);
              Program p = new Program();
               int result = p.add(5, 5);
               Console.WriteLine("The sum of 2 nos is " + result);
               Console.Read();*/
            Console.WriteLine("Hai There!!");
            testing t = new testing();
            t.callfunction();

        }
      public int add(int a, int b)
        {
            return a + b;
        }

        void Display()
        {
            Console.WriteLine("Hello");
        }
        
    }

   class testing
    {
       
       public void callfunction()
        {
            Program p = new Program();
            int res=p.add(6,7);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }

    }

