using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.System;
using PaperRaker.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
	public class Authors : IReadable<Author>
	{
		private CoreContext _context;
		public Authors(DbContext context)
		{
			_context = (context as CoreContext);
		}

		Author IReadable<Author>.Get(uint id)
		{
			var query = _context.Authors
								.Where(x => x.AuthorId == id)
								.FirstOrDefault();

			return query;
		}

		IEnumerable<Author> IReadable<Author>.GetGroup(uint size, uint page)
		{
			var query = _context.Authors
								.Skip( (int)(size*page) )
								.Take(20);

			return query.ToList();
		}
	}
}