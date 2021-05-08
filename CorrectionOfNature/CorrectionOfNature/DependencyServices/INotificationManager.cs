﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionOfNature.DependencyServices
{
    public interface INotificationManager
    {
        event EventHandler NotificationReceived;
        void Initialize();
        void SendNotification(string title, string message, DateTime? notifyTime = null);
        void ReceiveNotification(string title, string message);
    }
}
