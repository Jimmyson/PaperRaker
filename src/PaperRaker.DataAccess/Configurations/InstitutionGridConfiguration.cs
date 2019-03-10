using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Identity;

namespace PaperRaker.DataAccess.Configurations
{
	public class InstitutionGridConfiguration : IEntityTypeConfiguration<InstitutionGrid>
	{
		public void Configure(EntityTypeBuilder<InstitutionGrid> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.Grid, x.InstitutionId});
			builder.Property(x => x.Grid)
					.IsRequired();
			builder.Property(x => x.InstitutionId)
					.IsRequired();
					
			// Relationships
			builder.HasOne(x => x.Institution)
					.WithMany(i => i.Grids);

			//throw new System.NotImplementedException();
		}
	}
}