using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Alias;

namespace PaperRaker.DataAccess.Configurations
{
	public class PaperAliasConfiguration : IEntityTypeConfiguration<PaperAlias>
	{
		public void Configure(EntityTypeBuilder<PaperAlias> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.PaperAliasId, x.PaperId});
			builder.Property(x => x.PaperAliasId)
					.IsRequired();
			builder.Property(x => x.PaperId)
					.IsRequired();

			builder.Property(x => x.Title)
					.IsUnicode()
					.IsRequired();

			builder.Property(x => x.Subtitle)
					.IsUnicode();

			// Relationships
			builder.HasOne(x => x.Paper)
					.WithMany(p => p.Alias);
					
			//throw new System.NotImplementedException();
		}
	}
}