namespace PaperRaker.Core.System
{
    /// <summary>
    /// Identifies a Link between a Paper Contributor and their partnering Institution
    /// </summary>
    public class Affiliation : BaseEntity
    {
        public uint InstitutionId { get; set; }
        public uint Faculty { get; set; }
        
        public bool Primary { get; set; }

		public Institution Institution { get; set; }
    }
}