using System;
using System.Collections.Generic;
using System.Text;

namespace AURScheduler.Core.Domains.Enum
{
    /// <summary>
    /// Represents a download activation type
    /// </summary>
    public enum DownloadActivationType
    {
        /// <summary>
        /// When order is paid
        /// </summary>
        WhenOrderIsPaid = 0,

        /// <summary>
        /// Manually
        /// </summary>
        Manually = 10,
    }
}
