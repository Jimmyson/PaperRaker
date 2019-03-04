using Nager.ArticleNumber;
using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
	public class PaperArticle
	{
		public uint PaperArticleId { get; set; }
		public uint PaperId { get; set; }
		public ArticleNumberType Type { get; set; }
		public string Code { get; set; }

		public Paper Paper { get; set; }
	}
}