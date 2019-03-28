using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.System;

namespace PaperRaker.DataAccess.Configurations
{
	public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
	{
		public void Configure(EntityTypeBuilder<Publisher> builder)
		{
			// Property Settings
			builder.HasKey(x => x.PublisherId);
			builder.Property(x => x.PublisherId)
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

			// For<Publisher>().PrimaryKey(x => x.PublisherId);

			//throw new System.NotImplementedException();
		}
	}
}