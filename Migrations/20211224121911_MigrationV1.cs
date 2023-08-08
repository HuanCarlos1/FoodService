using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodTypes",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Longitude = table.Column<double>(type: "double", nullable: false),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryUsers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    ratings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeliveryUsers_Persons_ID",
                        column: x => x.ID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    DeliveryAdresses = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Persons_ID",
                        column: x => x.ID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<string>(type: "text", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    TypeID = table.Column<string>(type: "varchar(767)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    RestaurantID = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Food_FoodTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "FoodTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Food_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantAdmins",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    RestaurantId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantAdmins", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestaurantAdmins_Persons_ID",
                        column: x => x.ID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantAdmins_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTypes",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RestaurantID = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestaurantTypes_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "5906b795-3b45-4a17-9af5-1c9afb5d866b", "Kebab" },
                    { "e52a6530-b838-4e25-b4bb-33658f4e5cb3", "Vin" },
                    { "27b04e99-2b3d-4386-989b-f85553e8fcbc", "Alcool" },
                    { "99827733-e87e-4195-8ae7-0b0ed666444c", "Jus" },
                    { "fd8146d4-ca3c-4a74-9442-a3337b3cef0d", "Snacks" },
                    { "5908789e-d7ae-4322-889c-196ebadb7184", "Poulet" },
                    { "27d7384d-b196-4c90-b0cb-78fb689937d7", "Viande" },
                    { "a3f78f2a-ffb8-47c3-8471-6a2bc319f8d7", "Fruits" },
                    { "8030fc27-71a9-437c-a8bb-54f3714b0d5e", "Dessert" },
                    { "e8e01eb7-3e3f-4f09-9db3-caaba234cb30", "Sandwich" },
                    { "a04cb51a-7f17-43f2-9fba-eb84436aa77d", "Cake" },
                    { "95e222aa-80c6-4d24-ab41-3d64930c9a6d", "Champagne" },
                    { "b7b2ff2d-a0d1-4e9e-b5e7-03305b5dd008", "Whisky" },
                    { "4aeaf25a-5539-4e76-b28c-4c36a83d66ab", "Couscous" },
                    { "b1887216-6600-4570-8d95-fe5da4aaad47", "Hamburger" },
                    { "ff7450fb-b1e6-40e4-9044-d187013c5c9d", "Tacos" },
                    { "ed5b592b-7803-468c-83b7-cd99e7ce7416", "Salade" },
                    { "881ac0bf-8976-40ad-8b42-2ce2ec8631c9", "Burger" },
                    { "48887641-e80e-4d92-8b60-ba2bf24229eb", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "82d7f5e2-eaa5-4e22-8d19-5f6788a4f2e8", "CAFE", null },
                    { "ece9b188-ebf3-46bc-a2cb-41e3516232d9", "INDIAN", null },
                    { "35897515-45bc-4cb3-8f41-9dad3dad3753", "CHINESE", null },
                    { "64aea1f5-f3e6-44ab-adcf-aeea45a91ee1", "FAST-FOOD", null },
                    { "5c2ba2a7-391d-45c3-8590-24e594a815b3", "EUROPEAN", null },
                    { "b0f9b97d-2c76-4f25-9153-f431d1423006", "AFRICAN", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_RestaurantID",
                table: "Food",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Food_TypeID",
                table: "Food",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantAdmins_RestaurantId",
                table: "RestaurantAdmins",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTypes_RestaurantID",
                table: "RestaurantTypes",
                column: "RestaurantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryUsers");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "RestaurantAdmins");

            migrationBuilder.DropTable(
                name: "RestaurantTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FoodTypes");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
