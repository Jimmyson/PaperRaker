using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.Model.Alias
{
    public class InstitutionAlias : BaseEntity
    {
        public Institution Institution { get; set; }
        
        public string Name { get; set; }
        
        public Language Locale { get; set; }
    }
}