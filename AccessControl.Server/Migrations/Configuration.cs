using JetBrains.Annotations;
using NFive.AccessControl.Server.Storage;
using NFive.SDK.Server.Migrations;

namespace NFive.AccessControl.Server.Migrations
{
	[UsedImplicitly]
	public sealed class Configuration : MigrationConfiguration<StorageContext> { }
}
