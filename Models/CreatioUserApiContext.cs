using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CreatioUserApi.Models
{
	public class CreatioUserApiContext : DbContext
	{
		public CreatioUserApiContext(DbContextOptions<CreatioUserApiContext> options)
			: base(options)
		{
		}

		/// <summary>
		/// Объекты администрирования.
		/// </summary>
		public DbSet<SysAdminUnit> SysAdminUnit { get; set; }

		/// <summary>
		/// Контакты.
		/// </summary>
		public virtual DbSet<Contact> Contact { get; set; }
	}
}
