namespace PaperRaker.Core.System
{
    /// <summary>
    /// Identifies a Link between a Paper Contributor and their partnering Institution
    /// </summary>
    public class Affiliation : BaseEntity
    {
        public uint PaperId { get; set; }
        public uint AuthorId { get; set; }
        public uint InstitutionId { get; set; }
        // public uint Faculty { get; set; } // Needs to pair to an Institution
        
        public bool Primary { get; set; }

		public virtual Contributor Contributor { get; set; }
		public virtual Institution Institution { get; set; }
    }
}