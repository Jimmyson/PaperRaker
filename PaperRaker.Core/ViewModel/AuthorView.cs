using System.Collections.Generic;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.ViewModel
{
    public class AuthorView : Author
    {
        public HashSet<string> Orcid { get; protected set; }
        public HashSet<string> Isni { get; protected set; }
    }
}