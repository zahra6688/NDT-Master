using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NDT.Infra.Data.Migrations
{
    public partial class SeedClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Categories",
            //    table: "Categories");

            //migrationBuilder.RenameTable(
            //    name: "Categories",
            //    newName: "Clients");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Clients",
            //    table: "Clients",
            //    column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

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

            //migrationBuilder.RenameTable(
            //    name: "Clients",
            //    newName: "Categories");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Categories",
            //    table: "Categories",
            //    column: "Id");
        }
    }
}
