using Microsoft.EntityFrameworkCore;

namespace PaperRaker.DataAccess
{
	public static class DatabaseFactory
	{
		public static DbContext DbContextFactory(string sqlClient, string connectionString)
		{
			DbContextOptionsBuilder builder = new DbContextOptionsBuilder();

			switch (sqlClient) {
				case "SqlServer":
					builder.UseSqlServer(connectionString);
					break;
				case "MySql":
					builder.UseMySql(connectionString);
					break;
				case "Npgsql":
					builder.UseNpgsql(connectionString);
					break;
				case "Sqlite":
				default:
					builder.UseSqlite(connectionString);
					break;
			}

			DbContext context = new CoreContext(builder.Options);

			return context;
		}
	}
}