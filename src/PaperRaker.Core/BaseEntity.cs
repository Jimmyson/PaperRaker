using System;

namespace PaperRaker.Core
{
    /// <summary>
    /// Base attributes that detail entity data
    /// </summary>
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}