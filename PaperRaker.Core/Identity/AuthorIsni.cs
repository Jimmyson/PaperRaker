using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
    /// <summary>
    /// Details the ISNI records to an author
    /// </summary>
    public class AuthorIsni
    {
        public uint AuthorId { get; set; }
        public string Isni { get; set; }

		public Author Author { get; set; }
    }
}