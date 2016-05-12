using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceProduct.Common.Contracts;

namespace InterfaceProduct.Menu
{
    public class RemoveMenu : IMenu
    {
        private ICommerceService _commerceService;
        public RemoveMenu(ICommerceService commerceService)
        {
            _commerceService = commerceService;
        }
        public void Execute()
        {
            Console.WriteLine("What is the name of the product you would like to remove?");
            string name = Console.ReadLine();
            _commerceService.Remove(name);
        }

        public void DisplayName()
        {
            Console.WriteLine("2)  Remove Product");
        }
    }
}
