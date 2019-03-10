using System;
using System.Collections.Generic;

namespace PaperRaker.Core.System
{
	public class Conference : BaseEntity
	{
		public Conference()
		{
			Papers = new List<Paper>();
		}

		public uint ConferenceId { get; set; }

		public string Name { get; set; }
		public DateTime? EventStart { get; set; }
		public DateTime? EventEnd { get; set; }
		
		// TODO: Replace with Area Entity links
        public string City { get; set; }
        public string Country { get; set; }

		public virtual List<Paper> Papers { get; set; }
	}
}