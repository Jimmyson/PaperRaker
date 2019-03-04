using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
    /// <summary>
    /// Details the GRID.AC records to an institution
    /// </summary>
    public class InstitutionGrid
    {
        public int InstitutionId { get; set; }
        public string Grid { get; set; }

		public Institution Institution { get; set; }
    }
}