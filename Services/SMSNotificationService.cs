using FactoryDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Services
{
    public class SMSNotificationService : INotification
    {
        public string Notify(string recipient, string message)
        {
            
            Console.WriteLine($"Sending SMS Notification to {recipient}: {message}");
            return $"Sent SMS Notification to {recipient}: {message}";
        }
    }
}
