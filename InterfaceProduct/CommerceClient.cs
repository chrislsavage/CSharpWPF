using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Menu;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceProduct
{
    public class CommerceApp
    {
        private Dictionary<int, IMenu> _options;
        private ICommerceService _commerceService;

        public CommerceApp(ICommerceService commerceService)
        {
            this._commerceService = commerceService;

            _options = new Dictionary<int, IMenu>()
            {
                { 1, new AddMenu(_commerceService) },
                { 2, new RemoveMenu(_commerceService)},
                { 3, new ListMenu(_commerceService) },
                { 4, new EndMenu()},
            };
        }

        public void Run()
        {
            Console.WriteLine("Please select an item:");
            foreach (KeyValuePair<int, IMenu> option in _options)
            {
                option.Value.DisplayName();
            }
            int input;
      
            if (!int.TryParse(Console.ReadLine(), out input))
            { 
                Console.WriteLine("Incorrect Input. Please select a numbered menu Option.");
            }
            else
            {
                input--; 

                if (input == 3)
                {
                    return;
                }
                else
                {
                    var menuOption = _options.Values.ElementAtOrDefault(input);
                    if (menuOption != null)
                    {
                        menuOption.Execute();
                        Run();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input. Please select a numbered menu Option.");
                        Run();
                    }
                }
            }
        }
    }
}