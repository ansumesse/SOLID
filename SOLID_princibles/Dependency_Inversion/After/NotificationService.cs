using SOLID.DIP.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion.After
{
    internal class NotificationService
    {
        private readonly Customer customer;
        public List<IMessageDelivery> messageDeliveries { get; set; } = new();
        public void Notify()
        {
            foreach (var messageDelivery in messageDeliveries)
            {
                messageDelivery.Send();
            }
        }

    }
}
