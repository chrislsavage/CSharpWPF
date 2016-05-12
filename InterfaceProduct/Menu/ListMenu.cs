using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceProduct.Common.Contracts;

namespace InterfaceProduct.Menu
{
    public class ListMenu : IMenu
    {
        private ICommerceService _commerceService;
        public ListMenu(ICommerceService commerceService)
        {
            _commerceService = commerceService;
        }
        public void Execute()
        {
            _commerceService.List();
        }

        public void DisplayName()
        {
            Console.WriteLine("3)  List Inventory");
        }
    }
}
