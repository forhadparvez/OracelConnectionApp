using System.Data.Entity.Migrations;

namespace OracleConnectionApp.Migrations
{
    public partial class CreateEmployeeAndDepartmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "HR.Departments",
                c => new
                    {
                        DepartmentId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        ManagerId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .ForeignKey("HR.Employees", t => t.ManagerId, cascadeDelete: true)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "HR.Employees",
                c => new
                    {
                        EmployeeId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("HR.Departments", "ManagerId", "HR.Employees");
            DropIndex("HR.Departments", new[] { "ManagerId" });
            DropTable("HR.Employees");
            DropTable("HR.Departments");
        }
    }
}
