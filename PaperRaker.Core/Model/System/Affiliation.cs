namespace PaperRaker.Core.Model.System
{
    public class Affiliation
    {
        public Contributor Contributor { get; set; }
        public Institution Institution { get; set; }
        public Institution Faculty { get; set; }
        
        public bool Primary { get; set; }
    }
}