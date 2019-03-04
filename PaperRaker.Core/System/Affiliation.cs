namespace PaperRaker.Core.System
{
    /// <summary>
    /// Identifies a Link between a Paper Contributor and their partnering Institution
    /// </summary>
    public class Affiliation
    {
        public int InstitutionId { get; set; }
        public int Faculty { get; set; }
        
        public bool Primary { get; set; }
    }
}