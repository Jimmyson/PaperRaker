namespace PaperRaker.Core.Model.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for an Author
    /// </summary>
    public class AuthorAlias : BaseEntity
    {
        public int AuthorAliasId { get; set; }
        public int AuthorId { get; set; }
        
        public string Given { get; set; }
        public string Middle { get; set; }
        public string Family { get; set; }
        
        public string Locale { get; set; }
    }
}