using Estudo_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudo_MVC.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet <Produto> produtos { get; set; }
	}
}
