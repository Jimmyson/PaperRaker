using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.Alias;
using PaperRaker.Core.System;
using PaperRaker.DataAccess.Configurations;

namespace PaperRaker.DataAccess
{
	public class CoreContext : DbContext
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<AuthorAlias> AuthorAliases { get; set; }

		public DbSet<Institution> Institutions { get; set; }
		public DbSet<InstitutionAlias> InstitutionAliases { get; set; }

		public DbSet<Paper> Papers { get; set; }
		public DbSet<PaperAlias> PaperAliases { get; set; }

		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<Affiliation> Affiliations { get; set; }		
		public DbSet<Contributor> Contributors { get; set; }

		public CoreContext(DbContextOptions<CoreContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Primary Tables
			modelBuilder.ApplyConfiguration(new AuthorConfiguration());
			modelBuilder.ApplyConfiguration(new InstitutionConfiguration());
			modelBuilder.ApplyConfiguration(new PaperConfiguration());

			// Primary Table Alias
			modelBuilder.ApplyConfiguration(new AuthorAliasConfiguration());
			modelBuilder.ApplyConfiguration(new InstitutionAliasConfiguration());
			modelBuilder.ApplyConfiguration(new PaperAliasConfiguration());

			// Primary Table Identity
			modelBuilder.ApplyConfiguration(new PaperArticleConfiguration());

			// Secondary Tables
			modelBuilder.ApplyConfiguration(new PublisherConfiguration());
			modelBuilder.ApplyConfiguration(new AffiliationConfiguration());
			modelBuilder.ApplyConfiguration(new ContributorConfiguration());
			modelBuilder.ApplyConfiguration(new ConferenceConfiguration());
		}
	}
}