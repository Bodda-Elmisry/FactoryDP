using FactoryDP.Interfaces;
using FactoryDP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Facatories
{
    public class NotificationFactory
    {

        public INotification GetNotificationProvider(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmialNotificationService(),
                "sms" => new SMSNotificationService(),
                "app" => new AppNotificationService(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }

    }
}
