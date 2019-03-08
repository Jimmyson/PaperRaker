using System.Collections.Generic;

namespace PaperRaker.Core.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies a Publisher who prints and releases Paper works
    /// </summary>
    public class Publisher : BaseEntity
    {
        public uint PublisherId { get; set; }
        
        public string Name { get; set; }
		
        // TODO: Replace with Area Entity links
        public string City { get; set; }
        public string Country { get; set; }

		public virtual List<Paper> Papers { get; set; }
    }
}