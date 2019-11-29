using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NFive.SDK.Core.Models;

namespace NFive.AccessControl.Server.Models
{
	public class Role : IdentityModel
	{
		[Required]
		[Index(IsUnique = true)]
		[MinLength(1)]
		[MaxLength(255)]
		public string Name { get; set; }
	}
}
