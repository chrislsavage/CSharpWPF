using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProduct.Common.Contracts
{
    public interface INotificationService
    {
       //void NotifyProductAdded();
       //void NotifyProductRemoved();
       // void NotifyIncorrectInput();


       void NotifyMessage(string message);
    }
}
