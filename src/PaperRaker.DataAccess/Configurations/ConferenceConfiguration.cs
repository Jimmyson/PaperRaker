using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaperRaker.Core.Enum;
using PaperRaker.Core.System;
using System;

namespace PaperRaker.DataAccess.Configurations
{
	public class ConferenceConfiguration : IEntityTypeConfiguration<Conference>
	{
		public void Configure(EntityTypeBuilder<Conference> builder)
		{
			// Property Settings
			builder.HasKey(x => x.ConferenceId);
			builder.Property(x => x.ConferenceId)
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
					
			//throw new System.NotImplementedException();
		}
	}
}