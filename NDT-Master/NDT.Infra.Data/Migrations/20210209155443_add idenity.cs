//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace NDT.Infra.Data.Migrations
//{
//    public partial class addidenity : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("3e6ad597-74a4-4357-abed-60012f926a95"));

//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("8e78cf78-0e3a-4e53-97a2-55e6f7816f44"));

//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("b03fd78b-f5a7-42a8-a1ec-b1216fb866cc"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("3006cc5e-8925-4a92-aa7f-df914454b58c"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("39072b84-ac42-4fff-aac3-60bc06aa001e"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("b4ba5589-58b1-4365-b6dd-cc1dced86cc8"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("c200e711-de69-4853-bebc-02ab45e8ff3e"));

//            migrationBuilder.CreateTable(
//                name: "AspNetRoles",
//                columns: table => new
//                {
//                    Id = table.Column<string>(nullable: false),
//                    Name = table.Column<string>(maxLength: 256, nullable: true),
//                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
//                    ConcurrencyStamp = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUsers",
//                columns: table => new
//                {
//                    Id = table.Column<string>(nullable: false),
//                    UserName = table.Column<string>(maxLength: 256, nullable: true),
//                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
//                    Email = table.Column<string>(maxLength: 256, nullable: true),
//                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
//                    EmailConfirmed = table.Column<bool>(nullable: false),
//                    PasswordHash = table.Column<string>(nullable: true),
//                    SecurityStamp = table.Column<string>(nullable: true),
//                    ConcurrencyStamp = table.Column<string>(nullable: true),
//                    PhoneNumber = table.Column<string>(nullable: true),
//                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
//                    TwoFactorEnabled = table.Column<bool>(nullable: false),
//                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
//                    LockoutEnabled = table.Column<bool>(nullable: false),
//                    AccessFailedCount = table.Column<int>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetRoleClaims",
//                columns: table => new
//                {
//                    Id = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    RoleId = table.Column<string>(nullable: false),
//                    ClaimType = table.Column<string>(nullable: true),
//                    ClaimValue = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
//                        column: x => x.RoleId,
//                        principalTable: "AspNetRoles",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserClaims",
//                columns: table => new
//                {
//                    Id = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    UserId = table.Column<string>(nullable: false),
//                    ClaimType = table.Column<string>(nullable: true),
//                    ClaimValue = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserLogins",
//                columns: table => new
//                {
//                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
//                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
//                    ProviderDisplayName = table.Column<string>(nullable: true),
//                    UserId = table.Column<string>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserRoles",
//                columns: table => new
//                {
//                    UserId = table.Column<string>(nullable: false),
//                    RoleId = table.Column<string>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
//                        column: x => x.RoleId,
//                        principalTable: "AspNetRoles",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                    table.ForeignKey(
//                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateTable(
//                name: "AspNetUserTokens",
//                columns: table => new
//                {
//                    UserId = table.Column<string>(nullable: false),
//                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
//                    Name = table.Column<string>(maxLength: 128, nullable: false),
//                    Value = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
//                    table.ForeignKey(
//                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
//                        column: x => x.UserId,
//                        principalTable: "AspNetUsers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.InsertData(
//                table: "Clients",
//                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
//                values: new object[,]
//                {
//                    { new Guid("a30b169d-9255-4420-9160-e68635fa43f6"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null },
//                    { new Guid("c33a2536-ac30-4b7a-9a85-ef32e3c1d5f3"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null },
//                    { new Guid("6fd77f45-38a3-409d-967f-35361b139a0d"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null }
//                });

//            migrationBuilder.InsertData(
//                table: "MenuModel",
//                columns: new[] { "Id", "ActionName", "ClassIcon", "ControllerName", "ParentId", "Title" },
//                values: new object[,]
//                {
//                    { new Guid("4abe6fb7-a4f9-42d7-b62f-eba32bab705b"), "ShowClients", null, "Client", null, "کارفرمایان" },
//                    { new Guid("607dd871-ebda-48e7-9bd0-690fa42fe279"), "Details", null, "Project", null, "پروژه‌ها" },
//                    { new Guid("4b1c0e96-772d-4cf3-9fe7-c7e492e09056"), "", null, "", null, "تجهیزات" },
//                    { new Guid("d98ec621-9340-4af5-b1b2-f1d52775ba25"), "", null, "", null, "دستگاه‌ها" }
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetRoleClaims_RoleId",
//                table: "AspNetRoleClaims",
//                column: "RoleId");

//            migrationBuilder.CreateIndex(
//                name: "RoleNameIndex",
//                table: "AspNetRoles",
//                column: "NormalizedName",
//                unique: true,
//                filter: "[NormalizedName] IS NOT NULL");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserClaims_UserId",
//                table: "AspNetUserClaims",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserLogins_UserId",
//                table: "AspNetUserLogins",
//                column: "UserId");

//            migrationBuilder.CreateIndex(
//                name: "IX_AspNetUserRoles_RoleId",
//                table: "AspNetUserRoles",
//                column: "RoleId");

//            migrationBuilder.CreateIndex(
//                name: "EmailIndex",
//                table: "AspNetUsers",
//                column: "NormalizedEmail");

//            migrationBuilder.CreateIndex(
//                name: "UserNameIndex",
//                table: "AspNetUsers",
//                column: "NormalizedUserName",
//                unique: true,
//                filter: "[NormalizedUserName] IS NOT NULL");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "AspNetRoleClaims");

//            migrationBuilder.DropTable(
//                name: "AspNetUserClaims");

//            migrationBuilder.DropTable(
//                name: "AspNetUserLogins");

//            migrationBuilder.DropTable(
//                name: "AspNetUserRoles");

//            migrationBuilder.DropTable(
//                name: "AspNetUserTokens");

//            migrationBuilder.DropTable(
//                name: "AspNetRoles");

//            migrationBuilder.DropTable(
//                name: "AspNetUsers");

//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("6fd77f45-38a3-409d-967f-35361b139a0d"));

//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("a30b169d-9255-4420-9160-e68635fa43f6"));

//            migrationBuilder.DeleteData(
//                table: "Clients",
//                keyColumn: "Id",
//                keyValue: new Guid("c33a2536-ac30-4b7a-9a85-ef32e3c1d5f3"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("4abe6fb7-a4f9-42d7-b62f-eba32bab705b"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("4b1c0e96-772d-4cf3-9fe7-c7e492e09056"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("607dd871-ebda-48e7-9bd0-690fa42fe279"));

//            migrationBuilder.DeleteData(
//                table: "MenuModel",
//                keyColumn: "Id",
//                keyValue: new Guid("d98ec621-9340-4af5-b1b2-f1d52775ba25"));

//            migrationBuilder.InsertData(
//                table: "Clients",
//                columns: new[] { "Id", "Address", "CentralFaxNo", "CentralPhoneNo", "CeoName", "ClientName", "EmailAddress", "JobDomain", "SiteFaxNo", "SitePhoneNo" },
//                values: new object[,]
//                {
//                    { new Guid("3e6ad597-74a4-4357-abed-60012f926a95"), "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", null, null, "احمد محمدی", " صنایع  پتروشیمی رامپکو", null, null, null, null },
//                    { new Guid("8e78cf78-0e3a-4e53-97a2-55e6f7816f44"), "اراک-کوی صنعتی ,خیابان پامچال ", null, null, "علی حمیدی", "ماشین سازی اراک", null, null, null, null },
//                    { new Guid("b03fd78b-f5a7-42a8-a1ec-b1216fb866cc"), "قشم-مجتمع خلیج فارس -واحد 84", null, null, "حسین نوابی", "فراپتروسازان انرژی قشم", null, null, null, null }
//                });

//            migrationBuilder.InsertData(
//                table: "MenuModel",
//                columns: new[] { "Id", "ActionName", "ClassIcon", "ControllerName", "ParentId", "Title" },
//                values: new object[,]
//                {
//                    { new Guid("3006cc5e-8925-4a92-aa7f-df914454b58c"), "ShowClients", null, "Client", null, "کارفرمایان" },
//                    { new Guid("c200e711-de69-4853-bebc-02ab45e8ff3e"), "Details", null, "Project", null, "پروژه‌ها" },
//                    { new Guid("39072b84-ac42-4fff-aac3-60bc06aa001e"), "", null, "", null, "تجهیزات" },
//                    { new Guid("b4ba5589-58b1-4365-b6dd-cc1dced86cc8"), "", null, "", null, "دستگاه‌ها" }
//                });
//        }
//    }
//}
