using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;

namespace NFive.AccessControl.Server.Models
{
	[PublicAPI]
	public class UserRole : ModelRole
	{
		[Required]
		[ForeignKey("User")]
		public Guid UserId { get; set; }

		public virtual User User { get; set; }
	}
}
