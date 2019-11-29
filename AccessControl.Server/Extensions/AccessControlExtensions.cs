using System;
using System.Linq;
using NFive.AccessControl.Server.Models;
using NFive.AccessControl.Server.Storage;

namespace NFive.AccessControl.Server.Extensions
{
	public static class AccessControlExtensions
	{
		public static Role GetRole(string roleName)
		{
			using (var db = new StorageContext())
			{
				var role = db.Roles.FirstOrDefault(r => r.Name == roleName);
				if (role == null) throw new Exception($"No role named \"{roleName}\" was found.");

				return role;
			}
		}
	}
}
