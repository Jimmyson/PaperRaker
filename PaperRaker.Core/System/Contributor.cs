using System.Collections.Generic;
using PaperRaker.Core.Enum;

namespace PaperRaker.Core.System
{
    /// <summary>
    /// Identifies a Link between a Paper Contributor and its Authoring Contributors
    /// </summary>
    public class Contributor
    {
        public int PaperId { get; set; }
        public int AuthorId { get; set; }
        public ContributorType Type { get; set; }
        public List<Affiliation> Affiliations { get; set; }
    }
}