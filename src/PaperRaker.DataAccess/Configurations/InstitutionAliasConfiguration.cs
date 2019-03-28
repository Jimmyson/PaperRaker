using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Alias;

namespace PaperRaker.DataAccess.Configurations
{
	public class InstitutionAliasConfiguration : IEntityTypeConfiguration<InstitutionAlias>
	{
		public void Configure(EntityTypeBuilder<InstitutionAlias> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.InstitutionAliasId, x.InstitutionId});
			builder.Property(x => x.InstitutionAliasId)
					.IsRequired();
			builder.Property(x => x.InstitutionId)
					.IsRequired();

			builder.Property(x => x.Name)
					.IsUnicode()
					.IsRequired();

			// Relationships
			builder.HasOne(x => x.Institution)
					.WithMany(i => i.Alias);

			//throw new System.NotImplementedException();
		}
	}
}