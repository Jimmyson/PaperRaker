using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.Model.Identity
{
    public class PaperIssn
    {
        public Paper Paper { get; set; }
        public string Issn { get; set; }
        public IssnType Type { get; set; }
    }
}