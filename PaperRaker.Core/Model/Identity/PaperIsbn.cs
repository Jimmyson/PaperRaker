namespace PaperRaker.Core.Model.Identity
{
    /// <summary>
    /// Details the ISBN records to a paper
    /// </summary>
    public class PaperIsbn
    {
        public int PaperId { get; set; }
        public string Isbn { get; set; }
    }
}