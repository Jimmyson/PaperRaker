using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.System;
using PaperRaker.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
	public class Publishers : IReadable<Publisher>
	{
		private CoreContext _context;
		public Publishers(DbContext context)
		{
			_context = (context as CoreContext);
		}

		Publisher IReadable<Publisher>.Get(uint id)
		{
			var query = _context.Publishers
								.Where(x => x.PublisherId == id)
								.FirstOrDefault();

			return query;
		}

		IEnumerable<Publisher> IReadable<Publisher>.GetGroup(uint size, uint page)
		{
			var query = _context.Publishers
								.Skip( (int)(size*page) )
								.Take(20);

			return query.ToList();
		}
	}
}