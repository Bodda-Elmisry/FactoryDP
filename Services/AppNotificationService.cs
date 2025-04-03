using FactoryDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Services
{
    public class AppNotificationService : INotification
    {
        public string Notify(string recipient, string message)
        {
            
            Console.WriteLine($"Sending App Notification to {recipient}: {message}");
            return $"Sendt App Notification to {recipient}: {message}";
        }
    }
}
