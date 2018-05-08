namespace Neon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Short(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Short(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
