﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Services
{
    public interface IEmailService
    {
        void Send(string to, string email, string subject, string body);
    }
}
