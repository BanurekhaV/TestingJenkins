using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Sample
    {
        static void Main()
        {
            //int ? TicketsonSale=100; // int is being made a nullable data type
            //int Availabletickets;
            //if(TicketsonSale==null)
            //{
            //    Availabletickets = 0;
            //}
            //else
            //{
            //   // Availabletickets =(int)TicketsonSale; //or
            //    Availabletickets = TicketsonSale.Value;
            //}
            int? Ticketsonsale = null; //or null
            int Availabletickets = Ticketsonsale ?? 0; //Null Coalescing Operator ??
            Console.WriteLine("Available Tickets ={0}", Availabletickets);
            Console.Read();


        }
    }
}
