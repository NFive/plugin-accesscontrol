// <auto-generated />
// ReSharper disable all

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace NFive.AccessControl.Server.Migrations
{
	[GeneratedCode("NFive.Migration", "0.3 Alpha Build 209")]
	public class Init : DbMigration, IMigrationMetadata
	{
		string IMigrationMetadata.Id => "201911232310347_Init";

		string IMigrationMetadata.Source => null;

		string IMigrationMetadata.Target => "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";

		public override void Up()
		{
			CreateTable(
				"dbo.Roles",
				c => new
				{
					Id = c.Guid(nullable: false),
					Name = c.String(nullable: false, maxLength: 255, unicode: false),
					Created = c.DateTime(nullable: false, precision: 0),
					Deleted = c.DateTime(precision: 0),
				})
				.PrimaryKey(t => t.Id)
				.Index(t => t.Name, unique: true);

			CreateTable(
				"dbo.UserRoles",
				c => new
				{
					Id = c.Guid(nullable: false),
					UserId = c.Guid(nullable: false),
					RoleId = c.Guid(nullable: false),
					Created = c.DateTime(nullable: false, precision: 0),
					Deleted = c.DateTime(precision: 0),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
				.ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
				.Index(t => t.UserId)
				.Index(t => t.RoleId);
		}

		public override void Down()
		{
			DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
			DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
			DropIndex("dbo.UserRoles", new[] { "RoleId" });
			DropIndex("dbo.UserRoles", new[] { "UserId" });
			DropIndex("dbo.Roles", new[] { "Name" });
			DropTable("dbo.UserRoles");
			DropTable("dbo.Roles");
		}
	}
}