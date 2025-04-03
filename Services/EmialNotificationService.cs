using FactoryDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Services
{
    public class EmialNotificationService : INotification
    {
        public string Notify(string recipient, string message)
        {
            
            Console.WriteLine($"Sending Email Notification to {recipient}: {message}");
            return $"Sent Email Notification to {recipient}: {message}";
        }
    }
}
