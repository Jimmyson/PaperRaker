namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the ORCID records to an author
    /// </summary>
    public class AuthorOrcid
    {
        public int AuthorId { get; set; }
        public string Orcid { get; set; }
    }
}