namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ce190848-a5e8-46c7-9257-08938697e7dc', N'guest@vidly.com', 0, N'AFiNmja5tMVfikLicVTk1mgYlca4/IeaqMIUMHz4WwPHMoicK8/TdAnrp2jnEuymyw==', N'7e707f2c-999e-40de-835e-467b3740ed73', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f0b163e3-9597-48c3-b07f-ed5caa61316a', N'admin@vidly.com', 0, N'AHNn4oaFivcBiDrO/nK9sIas75lALPArM51MjHgult3zbxJb8E20jVR6gIgCzAqkeQ==', N'79dd3390-01a1-4aaf-9f1c-12aea5122d75', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e319f8f3-9a48-40e5-9f8c-72fef6bdc281', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f0b163e3-9597-48c3-b07f-ed5caa61316a', N'e319f8f3-9a48-40e5-9f8c-72fef6bdc281')
");
        }
        
        public override void Down()
        {
        }
    }
}
