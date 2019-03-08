using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Enum;
using PaperRaker.Core.System;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
	{
		public void Configure(EntityTypeBuilder<Institution> builder)
		{
			// Property Settings
			builder.HasKey(x => x.InstitutionId);
			builder.Property(x => x.InstitutionId)
					.IsRequired();

			builder.Property(x => x.Name)
					.IsUnicode()
					.IsRequired();

			// TODO: Replace with Area Entity links
			builder.Property(x => x.City)
					.IsUnicode()
					.IsRequired();

			builder.Property(x => x.Country)
					.IsUnicode()
					.IsRequired();

			builder.Property(x => x.Type)
					.IsRequired()
					.HasConversion(
						v => v.ToString(),
						v => (InstitutionType)Enum.Parse(typeof(InstitutionType), v)
					);

			// For<Institution>().PrimaryKey(x => x.InstitutionId)
            //     .Columns(x =>
            //     {
            //         x.Column(y => y.Grids).Ignore()
            //             .Reference(ReferenceType.Many);
            //         x.Column(y => y.Isnis).Ignore()
            //             .Reference(ReferenceType.Many);
                    
            //         x.Column(y => y.Alias).Ignore()
            //             .Reference(ReferenceType.Many);
            //     });

			//throw new System.NotImplementedException();
		}
	}
}