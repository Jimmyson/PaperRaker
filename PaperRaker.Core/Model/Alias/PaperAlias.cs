using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.Model.Alias
{
    public class PaperAlias : BaseEntity
    {
        public Paper Paper { get; set; }
        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public Language Locale { get; set; }
    }
}