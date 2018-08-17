using PaperRaker.Core.Model.Enum;

namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the ISSN records to a paper
    /// </summary>
    public class PaperIssn
    {
        public int PaperId { get; set; }
        public string Issn { get; set; }
        public IssnType Type { get; set; }
    }
}