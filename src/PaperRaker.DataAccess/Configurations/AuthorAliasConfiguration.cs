using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Alias;

namespace PaperRaker.DataAccess.Configurations
{
	public class AuthorAliasConfiguration : IEntityTypeConfiguration<AuthorAlias>
	{
		public void Configure(EntityTypeBuilder<AuthorAlias> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.AuthorAliasId, x.AuthorId});
			builder.Property(x => x.AuthorAliasId)
					.IsRequired();
			builder.Property(x => x.AuthorId)
					.IsRequired();

			builder.Property(x => x.Given)
					.IsUnicode()
					.IsRequired();

			builder.Property(x => x.Middle)
					.IsUnicode();

			builder.Property(x => x.Family)
					.IsUnicode()
					.IsRequired();

			// Relationships
			builder.HasOne(x => x.Author)
					.WithMany(a => a.Alias);
					
			//throw new System.NotImplementedException();
		}
	}
}