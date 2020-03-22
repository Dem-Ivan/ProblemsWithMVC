using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC12.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Phone> Phones { get; set; }
		public DbSet<Order> Orders { get; set; }

		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
