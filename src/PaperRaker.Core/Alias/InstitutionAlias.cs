using PaperRaker.Core.System;

namespace PaperRaker.Core.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for an Institution
    /// </summary>
    public class InstitutionAlias : BaseEntity
    {
        public uint InstitutionAliasId { get; set; }
        public uint InstitutionId { get; set; }
        
        public string Name { get; set; }
        
        public string Locale { get; set; }

		public Institution Institution { get; set; }
    }
}