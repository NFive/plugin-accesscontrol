using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NFive.SDK.Core.Models;

namespace NFive.AccessControl.Server.Models
{
	public abstract class ModelRole : IdentityModel
	{
		[Required]
		[ForeignKey("Role")]
		public Guid RoleId { get; set; }

		public virtual Role Role { get; set; }
	}
}
