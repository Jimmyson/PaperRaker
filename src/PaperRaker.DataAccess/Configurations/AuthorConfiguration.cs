using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Enum;
using PaperRaker.Core.System;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class AuthorConfiguration : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			// Property Settings
			builder.HasKey(x => x.AuthorId);
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
					
			builder.Property(x => x.Gender)
					.HasConversion(
						v => v.ToString(),
						v => (GenderType)Enum.Parse(typeof(GenderType), v)
					);
				
			// For<Author>().PrimaryKey(x => x.AuthorId)
            //     .Columns(x =>
            //     {
            //         x.Column(y => y.Isnis).Ignore()
            //             .Reference(ReferenceType.Many);
            //         x.Column(y => y.Orcids).Ignore()
            //             .Reference(ReferenceType.Many);
                    
            //         x.Column(y => y.Alias).Ignore()
            //             .Reference(ReferenceType.Many);
            //     });

			//throw new System.NotImplementedException();
		}
	}
}