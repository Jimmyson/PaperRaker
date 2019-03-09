using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.Alias;
using PaperRaker.Core.Identity;
using PaperRaker.Core.System;
using PaperRaker.DataAccess.Configurations;

namespace PaperRaker.DataAccess
{
	public class CoreContext : DbContext
	{
		public DbSet<Author> Authors { get; set; }
		//public DbSet<AuthorAlias> AuthorAliases { get; set; }

		public DbSet<Institution> Institutions { get; set; }
		//public DbSet<InstitutionAlias> InstitutionAliases { get; set; }

		public DbSet<Paper> Papers { get; set; }
		//public DbSet<PaperArticle> PaperArticles { get; set; }
		//public DbSet<PaperAlias> PaperAliases { get; set; }

		public DbSet<Publisher> Publishers { get; set; }
		//public DbSet<Affiliation> Affiliations { get; set; }		
		//public DbSet<Contributor> Contributors { get; set; }
		public DbSet<Conference> Conferences { get; set; }

		public CoreContext(DbContextOptions options) : base(options)
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
			modelBuilder.ApplyConfiguration(new PaperDoiConfiguration());

			modelBuilder.ApplyConfiguration(new InstitutionGridConfiguration());
			modelBuilder.ApplyConfiguration(new InstitutionIsniConfiguration());

			modelBuilder.ApplyConfiguration(new AuthorOrcidConfiguration());
			modelBuilder.ApplyConfiguration(new AuthorIsniConfiguration());

			// Secondary Tables
			modelBuilder.ApplyConfiguration(new PublisherConfiguration());
			modelBuilder.ApplyConfiguration(new AffiliationConfiguration());
			modelBuilder.ApplyConfiguration(new ContributorConfiguration());
			modelBuilder.ApplyConfiguration(new ConferenceConfiguration());
			

			base.OnModelCreating(modelBuilder);
		}
	}
}