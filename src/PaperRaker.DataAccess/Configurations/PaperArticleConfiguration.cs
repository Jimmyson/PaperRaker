using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nager.ArticleNumber;
using PaperRaker.Core.Identity;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class PaperArticleConfiguration : IEntityTypeConfiguration<PaperArticle>
	{
		public void Configure(EntityTypeBuilder<PaperArticle> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.PaperArticleId, x.PaperId});
			builder.Property(x => x.PaperArticleId)
					.IsRequired();
			builder.Property(x => x.PaperId)
					.IsRequired();

			builder.Property(x => x.Type)
					.IsRequired()
					.HasConversion(
						v => v.ToString(),
						v => (ArticleNumberType)Enum.Parse(typeof(ArticleNumberType), v)
					);

			builder.Property(x => x.Code)
					.HasField("_code");

			// Relationships
			builder.HasOne(x => x.Paper)
					.WithMany(p => p.Articles);
					
			//throw new System.NotImplementedException();
		}
	}
}