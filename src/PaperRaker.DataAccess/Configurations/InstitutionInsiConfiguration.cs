using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Identity;

namespace PaperRaker.DataAccess.Configurations
{
	public class InstitutionIsniConfiguration : IEntityTypeConfiguration<InstitutionIsni>
	{
		public void Configure(EntityTypeBuilder<InstitutionIsni> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.Isni, x.InstitutionId});
			builder.Property(x => x.Isni)
					.IsRequired()
					.HasMaxLength(16);
			builder.Property(x => x.InstitutionId)
					.IsRequired();
					
			// Relationships
			builder.HasOne(x => x.Institution)
					.WithMany(i => i.Isnis);

			//throw new System.NotImplementedException();
		}
	}
}