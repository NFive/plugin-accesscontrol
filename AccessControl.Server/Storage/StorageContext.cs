using System.Data.Entity;
using NFive.AccessControl.Server.Models;
using NFive.SDK.Server.Storage;

namespace NFive.AccessControl.Server.Storage
{
	public class StorageContext : EFContext<StorageContext>
	{
		public DbSet<Role> Roles { get; set; }

		public DbSet<UserRole> UserRoles { get; set; }
	}
}
