using System;
using System.Collections.Generic;
using PaperRaker.Core.Model.Enum;
using PaperRaker.Core.Model.System;

namespace PaperRaker.Core.ViewModel
{
    public class PaperView : Paper
    {
        public HashSet<string> Isbn { get; protected set; }
        public HashSet<string> Doi { get; protected set; }
        public HashSet<Tuple<string, IssnType>> Issn { get; protected set; }
        
        public HashSet<string> SetDois { get; protected set; }
        public HashSet<string> SetTitles { get; protected set; }
    }
}