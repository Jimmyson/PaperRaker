namespace PaperRaker.Core.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for an Institution
    /// </summary>
    public class InstitutionAlias : BaseEntity
    {
        public int InstitutionAliasId { get; set; }
        public int InstitutionId { get; set; }
        
        public string Name { get; set; }
        
        public string Locale { get; set; }
    }
}