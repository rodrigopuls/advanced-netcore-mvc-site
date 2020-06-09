using BBShop.Application.Common.Interfaces;
using System;

namespace BBShop.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
