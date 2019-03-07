using System;
using System.Collections.Generic;
using PaperRaker.Core.Alias;
using PaperRaker.Core.Enum;
using PaperRaker.Core.Identity;

namespace PaperRaker.Core.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies an Institution
    /// </summary>
    public class Institution : BaseEntity
    {
		public Institution() 
		{
			Grids = new List<InstitutionGrid>();
			Isnis = new List<InstitutionIsni>();
			Alias = new List<InstitutionAlias>();
		}

        public uint InstitutionId { get; set; }
        public string Name { get; set; }
        
        public string City { get; set; }
        public string Country { get; set; }
        
        public DateTime Opened { get; set; }
        public DateTime Closed { get; set; }
        
        public InstitutionType Type { get; set; }
        
        public List<InstitutionAlias> Alias { get; set; }
        public List<InstitutionIsni> Isnis { get; set; }
        public List<InstitutionGrid> Grids { get; set; }
    }
}