using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NDT.Infra.Data.Migrations
{
    public partial class clientModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    JobDomain = table.Column<string>(nullable: true),
                    CeoName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CentralPhoneNo = table.Column<string>(nullable: true),
                    CentralFaxNo = table.Column<string>(nullable: true),
                    SitePhoneNo = table.Column<string>(nullable: true),
                    SiteFaxNo = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
