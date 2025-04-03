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
        private readonly IServiceProvider serviceProvider;

        public NotificationFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }


        public INotification GetNotificationProvider(string type)
        {
            return type.ToLower() switch
            {
                "email" => (INotification)serviceProvider.GetService(typeof(EmialNotificationService)),
                "sms" => (INotification)serviceProvider.GetService(typeof(SMSNotificationService)),
                "app" => (INotification)serviceProvider.GetService(typeof(AppNotificationService)),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }

    }
}
