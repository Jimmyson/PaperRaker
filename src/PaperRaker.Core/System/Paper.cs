using System;
using System.Collections.Generic;
using PaperRaker.Core.Alias;
using PaperRaker.Core.Enum;
using PaperRaker.Core.Identity;

namespace PaperRaker.Core.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies a published Paper work
    /// </summary>
    public class Paper : BaseEntity
    {
		public Paper() 
		{
			Contributors = new List<Contributor>();
			Dois = new List<PaperDoi>();
			Articles = new List<PaperArticle>();
			Alias = new List<PaperAlias>();
		}
		
        public uint PaperId { get; set; }
        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public string Abstract { get; set; }
        public uint? PageCount { get; set; }
        public bool PeerReviewed { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
        public PaperType? ReleaseType { get; set; }
        
        public uint? PublisherId { get; set; }
        public DateTime? PublishDate { get; set; }
        public PublishType? PublishType { get; set; }

		public uint? ConferenceId { get; set; }
        
        public string Language { get; set; }
        public string Licence { get; set; }
        
        public virtual List<Contributor> Contributors { get; set; }
        public virtual List<PaperDoi> Dois { get; set; }
		public virtual List<PaperArticle> Articles { get; set; }

        public virtual List<PaperAlias> Alias { get; set; }

		public virtual Publisher Publisher { get; set; }
		public virtual Conference Conference { get; set; }
    }
}