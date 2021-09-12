﻿namespace OnlineCosmeticShop.Services.TradePartners
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ITradePartnerService
    {
        public bool IsTradePartner(string userId);

        public int IdByUser(string userId);
    }
}
