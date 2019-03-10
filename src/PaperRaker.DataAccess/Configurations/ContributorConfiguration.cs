using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Enum;
using PaperRaker.Core.System;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class ContributorConfiguration : IEntityTypeConfiguration<Contributor>
	{
		public void Configure(EntityTypeBuilder<Contributor> builder)
		{
			// Property Settings
			builder.HasKey(x => new {x.PaperId, x.AuthorId});
			builder.Property(x => x.PaperId)
					.IsRequired();
			builder.Property(x => x.AuthorId)
					.IsRequired();

			builder.Property(x => x.Type)
					.IsRequired()
					.HasConversion(
						v => v.ToString(),
						v => (ContributorType)Enum.Parse(typeof(ContributorType), v)
					);

			// Relationships
			builder.HasOne(x => x.Author)
					.WithMany(a => a.Contributors);
			builder.HasOne(x => x.Paper)
					.WithMany(p => p.Contributors);
				
			// For<Contributor>().PrimaryKey("PaperId,AuthorId")
            //     .Columns(x =>
            //     {
            //         x.Column(y => y.Affiliations)
            //             .Reference(ReferenceType.Many);
            //     });

			//throw new System.NotImplementedException();
		}
	}
}