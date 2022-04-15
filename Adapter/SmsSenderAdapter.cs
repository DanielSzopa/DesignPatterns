using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _sender = new SmsSender();
        public void SendNotification(int userId, Notification notification)
        {
            //na podstawie id usera pobieramy numer telefonu
            var telephoneNumber = "123321456";

            _sender.SendSms(telephoneNumber, $"{notification.Title}  Body: {notification.Body}");
        }
    }
}
