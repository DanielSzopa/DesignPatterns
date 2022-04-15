using Adapter;

INotificationSender notificationSenderEmail = new EmailSender();
INotificationSender notificationSenderPush = new PushSender();
INotificationSender notificationSenderSms = new SmsSenderAdapter();

notificationSenderEmail.SendNotification(1, new Notification("Test", "Body"));
notificationSenderPush.SendNotification(1, new Notification("Test", "Body"));
notificationSenderSms.SendNotification(1, new Notification("Test", "Body"));