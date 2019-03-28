using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.Model.Alias
{
    public class AuthorAlias : BaseEntity
    {
        public Author Author { get; set; }
        
        public string Prefix { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Suffix { get; set; }
        
        public Language Locale { get; set; }
    }
}