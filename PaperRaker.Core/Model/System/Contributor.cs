using System.Collections.Generic;
using PaperRaker.Core.Model.Enum;

namespace PaperRaker.Core.Model.System
{
    public class Contributor
    {
        public Paper Paper { get; set; }
        public Author Author { get; set; }
        public ContributorType Type { get; set; }
        public HashSet<Affiliation> Affiliations { get; set; }
    }
}