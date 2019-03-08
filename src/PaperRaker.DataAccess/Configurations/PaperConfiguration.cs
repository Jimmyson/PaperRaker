using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Enum;
using PaperRaker.Core.System;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class PaperConfiguration : IEntityTypeConfiguration<Paper>
	{
		public void Configure(EntityTypeBuilder<Paper> builder)
		{
			// Property Settings
			builder.HasKey(x => x.PaperId);
			builder.Property(x => x.PaperId)
					.IsRequired();

			builder.Property(x => x.Title)
					.IsUnicode()
					.IsRequired();

			builder.Property(x => x.Subtitle)
					.IsUnicode();

			builder.Property(x => x.Abstract)
					.IsUnicode()
					.HasColumnType("text");
					
			builder.Property(x => x.PeerReviewed)
					.IsRequired();

			builder.Property(x => x.ReleaseType)
					.HasConversion(
						v => v.ToString(),
						v => (PaperType)Enum.Parse(typeof(PaperType), v)
					);
					
			builder.Property(x => x.PublishType)
					.HasConversion(
						v => v.ToString(),
						v => (PublishType)Enum.Parse(typeof(PublishType), v)
					);

			// Relationships
			builder.HasOne(x => x.Publisher)
					.WithMany(p => p.Papers);
			builder.HasOne(x => x.Conference)
					.WithMany(c => c.Papers);
			
			// For<Paper>().PrimaryKey(x => x.PaperId)
            //     .Columns(x =>
            //     {
            //         x.Column(y => y.PublisherId).Ignore()
            //             .Reference();
                    
            //         x.Column(y => y.Contributors).Ignore()
            //             .Reference(ReferenceType.Many);
            //         x.Column(y => y.Dois).Ignore()
            //             .Reference(ReferenceType.Many);
            //         x.Column(y => y.Isbns).Ignore()
            //             .Reference(ReferenceType.Many);
            //         x.Column(y => y.Issns).Ignore()
            //             .Reference(ReferenceType.Many);
                    
            //         x.Column(y => y.Alias).Ignore()
            //             .Reference(ReferenceType.Many);
            //     });

			//throw new System.NotImplementedException();
		}
	}
}