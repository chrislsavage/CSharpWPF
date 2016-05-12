using InterfaceProduct.Common.Contracts;
using System;

namespace InterfaceProduct.Notifications
{
    public class SimpleNotify : INotificationService

    {


        public void NotifyMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
