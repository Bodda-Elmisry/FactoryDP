using FactoryDP.Facatories;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDP_Core.Controllers
{
    [Route("Delivery")]
    public class DeliveryController : Controller
    {
        private readonly NotificationFactory notificationFactory;

        public DeliveryController(NotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        [HttpGet("SendNotification")]
        public IActionResult SendNotification(string type, string recipient, string message)
        {
            var notification = notificationFactory.GetNotificationProvider(type);
            if (notification == null)
            {
                return BadRequest("Invalid notification type");
            }

            var result = notification.Notify(recipient, message);
            return Ok(result);
        }

    }
}
