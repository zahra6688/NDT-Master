using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NDT.Infra.Data.Migrations
{
    public partial class insertmenuitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("236edf90-3840-4b4a-942b-f96db920458c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("649b6b3c-b052-4c44-820c-fb973d4dcee4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("91d25ba0-25ed-49b3-ad43-9b5d604160b4"));

            migrationBuilder.CreateTable(
                name: "MenuModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    ClassIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[,]
                {
                    { new Guid("3e6ad597-74a4-4357-abed-60012f926a95"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null },
                    { new Guid("8e78cf78-0e3a-4e53-97a2-55e6f7816f44"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null },
                    { new Guid("b03fd78b-f5a7-42a8-a1ec-b1216fb866cc"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "MenuModel",
                columns: new[] { "Id", "ActionName", "ClassIcon", "ControllerName", "ParentId", "Title" },
                values: new object[,]
                {
                    { new Guid("3006cc5e-8925-4a92-aa7f-df914454b58c"), "ShowClients", null, "Client", null, "کارفرمایان" },
                    { new Guid("c200e711-de69-4853-bebc-02ab45e8ff3e"), "Details", null, "Project", null, "پروژه‌ها" },
                    { new Guid("39072b84-ac42-4fff-aac3-60bc06aa001e"), "", null, "", null, "تجهیزات" },
                    { new Guid("b4ba5589-58b1-4365-b6dd-cc1dced86cc8"), "", null, "", null, "دستگاه‌ها" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuModel");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3e6ad597-74a4-4357-abed-60012f926a95"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8e78cf78-0e3a-4e53-97a2-55e6f7816f44"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b03fd78b-f5a7-42a8-a1ec-b1216fb866cc"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[] { new Guid("236edf90-3840-4b4a-942b-f96db920458c"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[] { new Guid("91d25ba0-25ed-49b3-ad43-9b5d604160b4"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
                values: new object[] { new Guid("649b6b3c-b052-4c44-820c-fb973d4dcee4"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null });
        }
    }
}
