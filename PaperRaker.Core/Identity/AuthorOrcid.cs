using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
    /// <summary>
    /// Details the ORCID records to an author
    /// </summary>
    public class AuthorOrcid
    {
        public int AuthorId { get; set; }
        public string Orcid { get; set; }

		public Author Author { get; set; }
    }
}