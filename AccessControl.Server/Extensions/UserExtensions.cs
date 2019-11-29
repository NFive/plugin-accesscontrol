using System.Linq;
using JetBrains.Annotations;
using NFive.AccessControl.Server.Models;
using NFive.AccessControl.Server.Storage;
using NFive.SDK.Core.Models.Player;

namespace NFive.AccessControl.Server.Extensions
{
    [PublicAPI]
	public static class UserExtensions
	{
		public static bool HasRole(this User user, string roleName)
		{
			using (var db = new StorageContext())
			{
				return db.UserRoles.Any(r => r.UserId == user.Id && r.Role.Name == roleName);
			}
		}

		public static void AddRole(this User user, string roleName)
		{
			var role = AccessControlExtensions.GetRole(roleName);

			using (var db = new StorageContext())
			{
				var perm = db.UserRoles.FirstOrDefault(r => r.UserId == user.Id && r.Role.Name == roleName);
				if (perm != null) return;

				db.UserRoles.Add(new UserRole
				{
					RoleId = role.Id,
					UserId = user.Id
				});

				db.SaveChanges();
			}
		}

		public static void RemoveRole(this User user, string roleName)
		{
			using (var db = new StorageContext())
			{
				var perm = db.UserRoles.FirstOrDefault(r => r.UserId == user.Id && r.Role.Name == roleName);
				if (perm == null) return;

				db.UserRoles.Remove(perm);

				db.SaveChanges();
			}
		}
	}
}
