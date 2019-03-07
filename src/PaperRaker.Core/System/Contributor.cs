using System.Collections.Generic;
using PaperRaker.Core.Enum;

namespace PaperRaker.Core.System
{
    /// <summary>
    /// Identifies a Link between a Paper Contributor and its Authoring Contributors
    /// </summary>
    public class Contributor : BaseEntity
    {
        public uint PaperId { get; set; }
        public uint AuthorId { get; set; }
        public ContributorType Type { get; set; }
		
        public List<Affiliation> Affiliations { get; set; }

		public Paper Paper { get; set; }
		public Author Author { get; set; }
    }
}