using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
    /// <summary>
    /// Details the ISSN records to an institution
    /// </summary>
    public class InstitutionIsni
    {
        public uint InstitutionId { get; set; }
        public string Isni { get; set; }
		
        public Institution Institution { get; set; }
    }
}