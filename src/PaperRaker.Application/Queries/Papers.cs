using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.System;
using PaperRaker.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
	public class Papers : IReadable<Paper>
	{
		private CoreContext _context;
		public Papers(DbContext context)
		{
			_context = (context as CoreContext);
		}

		Paper IReadable<Paper>.Get(uint id)
		{
			var query = _context.Papers
								.Where(x => x.PaperId == id)
								.FirstOrDefault();

			return query;
		}

		IEnumerable<Paper> IReadable<Paper>.GetGroup(uint size, uint page)
		{
			var query = _context.Papers
								.Skip( (int)(size*page) )
								.Take(20);

			return query.ToList();
		}
	}
}