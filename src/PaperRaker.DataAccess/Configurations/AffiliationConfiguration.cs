using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.System;

namespace PaperRaker.DataAccess.Configurations
{
	public class AffiliationConfiguration : IEntityTypeConfiguration<Affiliation>
	{
		public void Configure(EntityTypeBuilder<Affiliation> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.PaperId, x.AuthorId, x.InstitutionId});
			builder.Property(x => x.PaperId)
					.IsRequired();
			builder.Property(x => x.AuthorId)
					.IsRequired();
			builder.Property(x => x.InstitutionId)
					.IsRequired();

			builder.Property(x => x.Primary)
					.IsRequired();

			// Relationships
			builder.HasOne(x => x.Institution)
					.WithMany(i => i.Affiliations);
			builder.HasOne(x => x.Contributor)
					.WithMany(c => c.Affiliations);
				
			// For<Affiliation>().PrimaryKey("PaperId,AuthorId,InstitutionId")
            //     .Columns(x =>
            //     {
            //         x.Column(y => y.InstitutionId)
            //             .Reference(ReferenceType.Many);
            //     });

			//throw new System.NotImplementedException();
		}
	}
}