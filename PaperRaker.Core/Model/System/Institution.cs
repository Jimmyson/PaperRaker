using System;
using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;

namespace PaperRaker.Core.Model.System
{
    public class Institution : BaseEntity
    {
        public string Name { get; set; }
        
        public string City { get; set; }
        public string Country { get; set; }
        
        public DateTime Opened { get; set; }
        public DateTime Closed { get; set; }
        
        public InstitutionType Type { get; set; }
        public HashSet<InstitutionAlias> Alias { get; set; }
    }
}