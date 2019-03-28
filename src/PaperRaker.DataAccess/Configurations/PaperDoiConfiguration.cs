using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nager.ArticleNumber;
using PaperRaker.Core.Identity;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class PaperDoiConfiguration : IEntityTypeConfiguration<PaperDoi>
	{
		public void Configure(EntityTypeBuilder<PaperDoi> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.Doi, x.PaperId});
			builder.Property(x => x.Doi)
					.IsRequired();
			builder.Property(x => x.PaperId)
					.IsRequired();

			// Relationships
			builder.HasOne(x => x.Paper)
					.WithMany(p => p.Dois);
					
			//throw new System.NotImplementedException();
		}
	}
}