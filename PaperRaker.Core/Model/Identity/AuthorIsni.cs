namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the ISNI records to an author
    /// </summary>
    public class AuthorIsni
    {
        public int AuthorId { get; set; }
        public string Isni { get; set; }
    }
}