using System;
using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;

namespace PaperRaker.Core.Model.System
{
    public class Paper : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public string Abstract { get; set; }
        public uint? PageCount { get; set; }
        public bool PeerReviewed { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
        public PaperType? ReleaseType { get; set; }
        
        public Publisher Publisher { get; set; }
        public DateTime? PublishDate { get; set; }
        public PublishType? PublishType { get; set; }
        
        public Language? Language { get; set; }
        
        public string Licence { get; set; }
        
        public List<Contributor> Contributors { get; set; }

        //public HashSet<PaperAlias> Alias { get; set; }
    }
}