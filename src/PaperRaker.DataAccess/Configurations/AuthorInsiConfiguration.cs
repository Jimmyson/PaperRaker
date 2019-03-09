using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Identity;

namespace PaperRaker.DataAccess.Configurations
{
	public class AuthorIsniConfiguration : IEntityTypeConfiguration<AuthorIsni>
	{
		public void Configure(EntityTypeBuilder<AuthorIsni> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.Isni, x.AuthorId});
			builder.Property(x => x.Isni)
					.IsRequired()
					.HasMaxLength(16);
			builder.Property(x => x.AuthorId)
					.IsRequired();
					
			// Relationships
			builder.HasOne(x => x.Author)
					.WithMany(a => a.Isnis);

			//throw new System.NotImplementedException();
		}
	}
}