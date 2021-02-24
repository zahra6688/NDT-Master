using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NDT.Infra.Data.Migrations
{
    public partial class projectmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6fd77f45-38a3-409d-967f-35361b139a0d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a30b169d-9255-4420-9160-e68635fa43f6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c33a2536-ac30-4b7a-9a85-ef32e3c1d5f3"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("4abe6fb7-a4f9-42d7-b62f-eba32bab705b"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("4b1c0e96-772d-4cf3-9fe7-c7e492e09056"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("607dd871-ebda-48e7-9bd0-690fa42fe279"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("d98ec621-9340-4af5-b1b2-f1d52775ba25"));

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    clientId = table.Column<Guid>(nullable: false),
                    projectTitle = table.Column<string>(nullable: true),
                    startDate = table.Column<DateTime>(nullable: false),
                    state = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    radiographyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Clients_clientId",
                        column: x => x.clientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[,]
                {
                    { new Guid("bcbbde5e-5318-4c09-943c-55dc47e9e45e"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null },
                    { new Guid("4a9fd261-7e83-416d-8a11-fe9ee0001ca9"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null },
                    { new Guid("8f13d11f-95d3-42c3-891d-cf2c587d0977"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuModel",
                columns: new[] { "Id", "ActionName", "ClassIcon", "ControllerName", "ParentId", "Title" },
                values: new object[,]
                {
                    { new Guid("b81f3008-82bf-40d3-ac55-609cf12feb48"), "ShowClients", null, "Client", null, "کارفرمایان" },
                    { new Guid("7b259957-909e-4677-999b-cb4e20d48870"), "Details", null, "Project", null, "پروژه‌ها" },
                    { new Guid("61eb8017-e3c6-42c9-82b6-712f5cdba8a1"), "", null, "", null, "تجهیزات" },
                    { new Guid("9b32d02b-872b-48b5-a541-44fb9e2a71ff"), "", null, "", null, "دستگاه‌ها" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_clientId",
                table: "Project",
                column: "clientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4a9fd261-7e83-416d-8a11-fe9ee0001ca9"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8f13d11f-95d3-42c3-891d-cf2c587d0977"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bcbbde5e-5318-4c09-943c-55dc47e9e45e"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("61eb8017-e3c6-42c9-82b6-712f5cdba8a1"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("7b259957-909e-4677-999b-cb4e20d48870"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("9b32d02b-872b-48b5-a541-44fb9e2a71ff"));

            migrationBuilder.DeleteData(
                table: "MenuModel",
                keyColumn: "Id",
                keyValue: new Guid("b81f3008-82bf-40d3-ac55-609cf12feb48"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[,]
                {
                    { new Guid("a30b169d-9255-4420-9160-e68635fa43f6"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null },
                    { new Guid("c33a2536-ac30-4b7a-9a85-ef32e3c1d5f3"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null },
                    { new Guid("6fd77f45-38a3-409d-967f-35361b139a0d"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuModel",
                columns: new[] { "Id", "ActionName", "ClassIcon", "ControllerName", "ParentId", "Title" },
                values: new object[,]
                {
                    { new Guid("4abe6fb7-a4f9-42d7-b62f-eba32bab705b"), "ShowClients", null, "Client", null, "کارفرمایان" },
                    { new Guid("607dd871-ebda-48e7-9bd0-690fa42fe279"), "Details", null, "Project", null, "پروژه‌ها" },
                    { new Guid("4b1c0e96-772d-4cf3-9fe7-c7e492e09056"), "", null, "", null, "تجهیزات" },
                    { new Guid("d98ec621-9340-4af5-b1b2-f1d52775ba25"), "", null, "", null, "دستگاه‌ها" }
                });
        }
    }
}
