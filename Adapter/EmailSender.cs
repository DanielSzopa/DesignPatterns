namespace Adapter
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending email notification to : {userId} Title: {notification.Title}   Body: {notification.Body}");
        }
    }
}
