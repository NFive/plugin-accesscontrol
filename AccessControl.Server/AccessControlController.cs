using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Controllers;

namespace NFive.AccessControl.Server
{
	[PublicAPI]
	public class AccessControlController : Controller
	{
		public AccessControlController(ILogger logger) : base(logger) { }
	}
}
