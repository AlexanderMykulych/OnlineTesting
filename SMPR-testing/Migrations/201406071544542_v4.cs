namespace SMPR_testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into [TaskTypes] values ('���� �� ����')");
            Sql("insert into [TaskTypes] values ('���� �� ������')");
        }
        
        public override void Down()
        {
        }
    }
}
