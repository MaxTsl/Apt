using Microsoft.EntityFrameworkCore.Migrations;

namespace test3.Data.Migrations
{
    public partial class UserOrgId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrgId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    OrgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    OrgINN = table.Column<string>(type: "varchar(50)", nullable: true),
                    OrgAddress = table.Column<string>(type: "varchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.OrgId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "AspNetUsers");
        }
    }
}
