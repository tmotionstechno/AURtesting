﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AURScheduler.Core.Domains.Enum
{
    /// <summary>
    /// Represents a backorder mode
    /// </summary>
    public enum BackorderMode
    {
        /// <summary>
        /// No backorders
        /// </summary>
        NoBackorders = 0,

        /// <summary>
        /// Allow qty below 0
        /// </summary>
        AllowQtyBelow0 = 1,

        /// <summary>
        /// Allow qty below 0 and notify customer
        /// </summary>
        AllowQtyBelow0AndNotifyCustomer = 2,
    }
}
