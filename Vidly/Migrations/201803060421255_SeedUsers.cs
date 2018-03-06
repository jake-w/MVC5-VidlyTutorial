namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6439a88d-3505-413f-b162-7f9ba7f39cad', N'guest@vidly.com', 0, N'AKYO+QUS8DkLvFoEwRfiXGr/kGREyJ0W4DdfC5juZgWD3VzNSmx+3XwysAUeewJ9Dg==', N'98955d88-6f96-4106-b1a3-99fc5174d698', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b24a227d-7889-4270-96e3-6cfb1e065e38', N'admin@vidly.com', 0, N'ACFPHkDeFhQMo6Q196GwzaBIt+927zR8IALo9PML8ecn8aDggiM1clMr+/kTbvVFjg==', N'433cdc76-db2f-4e32-96de-bd299a338ab3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'afd1d760-8215-421a-b585-e56fd6ebfb06', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b24a227d-7889-4270-96e3-6cfb1e065e38', N'afd1d760-8215-421a-b585-e56fd6ebfb06')
");
        }
        
        public override void Down()
        {
        }
    }
}
