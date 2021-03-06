﻿using Nop.Web.Framework.Mvc;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Admin.Models.Home
{
    public partial class CommonStatisticsModel : BaseNopModel
    {
        public int NumberOfOrders { get; set; }

        public int NumberOfCustomers { get; set; }

        public int NumberOfPendingReturnRequests { get; set; }

        public int NumberOfLowStockProducts { get; set; }
    }
}