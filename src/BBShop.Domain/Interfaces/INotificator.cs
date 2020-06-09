using BBShop.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBShop.Domain.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();

        List<Notification> GetNotifications();

        void Handle(Notification notification);
    }
}
