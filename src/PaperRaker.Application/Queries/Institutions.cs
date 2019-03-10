using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.System;
using PaperRaker.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
	public class Institutions : IReadable<Institution>
	{
		private CoreContext _context;
		public Institutions(DbContext context)
		{
			_context = (context as CoreContext);
		}

		Institution IReadable<Institution>.Get(uint id)
		{
			var query = _context.Institutions
								.Where(x => x.InstitutionId == id)
								.FirstOrDefault();

			return query;
		}

		IEnumerable<Institution> IReadable<Institution>.GetGroup(uint size, uint page)
		{
			var query = _context.Institutions
								.Skip( (int)(size*page) )
								.Take(20);

			return query.ToList();
		}
	}
}