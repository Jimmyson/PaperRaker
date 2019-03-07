using System;
using Nager.ArticleNumber;
using PaperRaker.Core.System;

namespace PaperRaker.Core.Identity
{
	public class PaperArticle
	{
		private string _code { get; set; }

		public PaperArticle(string code)
		{
			Code = code;
		}

		public uint PaperArticleId { get; set; }
		public uint PaperId { get; set; }
		public ArticleNumberType Type { get; protected set; }
		public string Code {
			get => _code;
			set {
				ArticleNumberType type = ArticleNumberHelper.GetArticleNumberType(value);

				if (type == ArticleNumberType.UNKNOWN) {
					throw new Exception("Invalid Article Number");
				}
				
				_code = value;
				Type = type;
			}
		}

		public Paper Paper { get; set; }
	}
}