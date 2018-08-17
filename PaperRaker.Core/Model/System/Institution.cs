using System;
using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.Identity;

namespace PaperRaker.Core.Model.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies an Institution
    /// </summary>
    public class Institution : BaseEntity
    {
        public int InstitutionId { get; set; }
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