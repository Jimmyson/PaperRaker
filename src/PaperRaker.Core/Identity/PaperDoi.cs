using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
    /// <summary>
    /// Details the DOI records to a paper
    /// </summary>
    public class PaperDoi
    {
        public uint PaperId { get; set; }
        public string Doi { get; set; }

		public Paper Paper { get; set; }
    }
}