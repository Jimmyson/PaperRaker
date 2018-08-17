using System;
using System.Collections.Generic;
using PaperRaker.Core.Model.Alias;
using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.Identity;

namespace PaperRaker.Core.Model.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies a published Paper work
    /// </summary>
    public class Paper : BaseEntity
    {
        public int PaperId { get; set; }
        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public string Abstract { get; set; }
        public uint? PageCount { get; set; }
        public bool PeerReviewed { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
        public PaperType? ReleaseType { get; set; }
        
        public int PublisherId { get; set; }
        public DateTime? PublishDate { get; set; }
        public PublishType? PublishType { get; set; }
        
        public string Language { get; set; }
        public string Licence { get; set; }
        
        public List<Contributor> Contributors { get; set; }
        public List<PaperDoi> Dois { get; set; }
        public List<PaperIssn> Issns { get; set; }
        public List<PaperIsbn> Isbns { get; set; }

        public List<PaperAlias> Alias { get; set; }
    }
}