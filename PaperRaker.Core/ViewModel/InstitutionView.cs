using System.Collections.Generic;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.ViewModel
{
    public class InstitutionView : Institution
    {
        public HashSet<string> Grid { get; protected set; }
        public HashSet<string> Isni { get; protected set; }
    }
}