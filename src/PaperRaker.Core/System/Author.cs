﻿using System.Collections.Generic;
using PaperRaker.Core.Alias;
using PaperRaker.Core.Enum;
using PaperRaker.Core.Identity;

namespace PaperRaker.Core.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies an Author who creates works
    /// </summary>
    public class Author : BaseEntity
    {
		public Author() 
		{
			Orcids = new List<AuthorOrcid>();
			Isnis = new List<AuthorIsni>();
			Alias = new List<AuthorAlias>();
			Contributors = new List<Contributor>();
		}

        public uint AuthorId { get; set; }
        public string Prefix { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Suffix { get; set; }
        
        public GenderType Gender { get; set; }
        
        public virtual List<AuthorAlias> Alias { get; set; }
        public virtual List<AuthorIsni> Isnis { get; set; }
        public virtual List<AuthorOrcid> Orcids { get; set; }

		public virtual List<Contributor> Contributors { get; set; }
    }
}