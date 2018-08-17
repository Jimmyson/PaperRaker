namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the DOI records to a paper
    /// </summary>
    public class PaperDoi
    {
        public int PaperId { get; set; }
        public string Doi { get; set; }
    }
}