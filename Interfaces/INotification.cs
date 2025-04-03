using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Interfaces
{
    public interface INotification
    {
        string Notify(string recipient, string message);
    }
}
