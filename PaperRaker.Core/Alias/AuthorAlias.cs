using PaperRaker.Core.System;

namespace PaperRaker.Core.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for an Author
    /// </summary>
    public class AuthorAlias : BaseEntity
    {
        public uint AuthorAliasId { get; set; }
        public uint AuthorId { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Locale { get; set; }

		public Author Author { get; set; }
    }
}