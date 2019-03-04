namespace PaperRaker.Core.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for a Paper
    /// </summary>
    public class PaperAlias : BaseEntity
    {
        public int PaperAliasId { get; set; }
        public int PaperId { get; set; }
        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public string Locale { get; set; }
    }
}