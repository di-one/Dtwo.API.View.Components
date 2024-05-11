using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Feedback
{
    public static class Notification
    {
        public class NotificationMessage
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public ESeverity Severity { get; set; }
        }

        public enum ESeverity
        {
            Info,
            Warning,
            Error
        }

        public static Action<NotificationMessage> OnNotification;

        public static void Notify(NotificationMessage message)
        {
            OnNotification?.Invoke(message);
        }
    }
}
