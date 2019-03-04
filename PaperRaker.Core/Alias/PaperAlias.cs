using PaperRaker.Core.System;

namespace PaperRaker.Core.Alias
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a Aliased name for a Paper
    /// </summary>
    public class PaperAlias : BaseEntity
    {
        public uint PaperAliasId { get; set; }
        public uint PaperId { get; set; }
        
        public string Title { get; set; }
        public string Subtitle { get; set; }
        
        public string Locale { get; set; }

		public Paper Paper { get; set; }
    }
}