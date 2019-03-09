using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Identity;

namespace PaperRaker.DataAccess.Configurations
{
	public class AuthorOrcidConfiguration : IEntityTypeConfiguration<AuthorOrcid>
	{
		public void Configure(EntityTypeBuilder<AuthorOrcid> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.Orcid, x.AuthorId});
			builder.Property(x => x.Orcid)
					.IsRequired()
					.HasMaxLength(19);
			builder.Property(x => x.AuthorId)
					.IsRequired();
					
			// Relationships
			builder.HasOne(x => x.Author)
					.WithMany(a => a.Orcids);

			//throw new System.NotImplementedException();
		}
	}
}