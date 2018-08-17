namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the ISSN records to an institution
    /// </summary>
    public class InstitutionIsni
    {
        public int InstitutionId { get; set; }
        public string Isni { get; set; }
    }
}