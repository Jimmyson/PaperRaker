using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;

namespace PaperRaker.Core.Model.System
{
    public class Author : BaseEntity
    {
        public string Prefix { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Suffix { get; set; }
        
        public GenderType Gender { get; set; }
        public HashSet<AuthorAlias> Alias { get; set; }
    }
}