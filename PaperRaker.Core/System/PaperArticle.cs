using System;
using Nager.ArticleNumber;

namespace PaperRaker.Core.System
{
	public class PaperArticle : BaseEntity
	{
		public int PaperId { get; set; }
		public ArticleNumberType Type { get; private set; }
		public string Code { get; set; }
	}
}