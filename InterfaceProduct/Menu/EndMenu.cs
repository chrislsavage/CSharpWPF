using InterfaceProduct.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProduct.Menu
{
    public class EndMenu :IMenu 
    {
        public void Execute()
        {
            
        }

        public void DisplayName()
        {
            Console.WriteLine("4)  Exit");
        }
    }
}
