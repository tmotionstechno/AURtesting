﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AURScheduler.Core.Domains.Enum
{
    /// <summary>
    /// Represents a rental product period (for prices)
    /// </summary>
    public enum RentalPricePeriod
    {
        /// <summary>
        /// Days
        /// </summary>
        Days = 0,

        /// <summary>
        /// Weeks
        /// </summary>
        Weeks = 10,

        /// <summary>
        /// Months
        /// </summary>
        Months = 20,

        /// <summary>
        /// Years
        /// </summary>
        Years = 30,
    }
}
