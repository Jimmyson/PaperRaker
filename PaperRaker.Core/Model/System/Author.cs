using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.Identity;

namespace PaperRaker.Core.Model.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies an Author who creates works
    /// </summary>
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }
        public string Prefix { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Suffix { get; set; }
        
        public GenderType Gender { get; set; }
        
        public List<AuthorAlias> Alias { get; set; }
        public List<AuthorIsni> Isnis { get; set; }
        public List<AuthorOrcid> Orcids { get; set; }
    }
}