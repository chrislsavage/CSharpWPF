using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using InterfaceProduct.Common.Model;

namespace InterfaceProduct.DesktopApp.Messages
{
    public class EditProductMessage : MessageBase
    {
        public EditProductMessage(object sender, Product product = null) : base(sender)
        {
            Product = product;
        }

        public Product Product { get; private set; }
    }
}
