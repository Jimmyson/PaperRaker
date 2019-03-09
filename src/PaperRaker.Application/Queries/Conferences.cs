using Microsoft.EntityFrameworkCore;
using PaperRaker.Core.System;
using PaperRaker.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PaperRaker.Application.Queries
{
	public class Conferences : IReadable<Conference>
	{
		private CoreContext _context;
		public Conferences(DbContext context)
		{
			_context = (context as CoreContext);
		}

		Conference IReadable<Conference>.Get(uint id)
		{
			var query = _context.Conferences
								.Where(x => x.ConferenceId == id)
								.FirstOrDefault();

			return query;
		}

		IEnumerable<Conference> IReadable<Conference>.GetGroup(uint size, uint page)
		{
			var query = _context.Conferences
								.Skip( (int)(size*page) )
								.Take(20);

			return query.ToList();
		}
	}
}