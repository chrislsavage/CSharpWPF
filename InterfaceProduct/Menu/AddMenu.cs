using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System;

namespace InterfaceProduct.Menu
{
    public class AddMenu : IMenu
    {
        private ICommerceService _commerceService;
        public AddMenu(ICommerceService commerceService)
        {
            _commerceService = commerceService;
        }

        public void Execute()
        {
            Console.WriteLine("What is the name of the product you would like to add?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the price of the product you would like to add?");
            string strPrice = Console.ReadLine();
            decimal price = Convert.ToDecimal(decimal.Parse(strPrice).ToString("N"));
            //_commerceService.Add(new Product { Name = name, Price = price });
            //Read product data (name and price)
            //create product and use the CommerceSerice to add

            //notify

            //commerceService.Add();
            //inv.AddItem(product);
        }

        public void DisplayName()
        {
            Console.WriteLine("1)  Add Product");
        }

    }
}
