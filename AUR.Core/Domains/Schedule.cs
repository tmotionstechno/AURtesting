using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AURScheduler.Core.Domains
{
    public class Schedule : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        
        /// <summary>
        /// Gets or sets the value indicating whether a task is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was started last time
        /// </summary>
        public DateTime? LastStartUtc { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was finished last time (no matter failed is success)
        /// </summary>
        public DateTime? LastEndUtc { get; set; }

        /// <summary>
        /// Gets or sets the datetime when it was successfully finished last time
        /// </summary>
        public DateTime? LastSuccessUtc { get; set; }
       
    }
}
