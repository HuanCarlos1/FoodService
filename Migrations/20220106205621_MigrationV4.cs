using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    public partial class MigrationV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "103d6e25-815f-43fb-bffb-4f768060278a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "171d5a50-75de-4fa7-a99b-086f52e3e0ea");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "37ec6a69-60ac-454b-97a5-d655aee31a4e");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "41c71115-f9fd-4ad9-a24f-4659d8be2212");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "44f9059b-f931-4660-8850-6f7aae6732eb");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "5925a3d9-b3fa-4e69-9876-06a6ac9fb53f");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "726f20dd-f5a6-470a-9ed6-a0ba204dda42");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "7a7d4758-249d-4e5f-a3be-0b5cd0243cb4");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "8887dd25-b6f1-4174-afb3-c5d6586b793d");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "89a1a192-89c0-4a6f-8617-afbceb41f23a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "abbe1ab9-eecc-4f61-827c-7f8d03388af6");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "addfbc2d-23b7-47a8-b506-9b454149456a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "b0168d7d-957c-43d1-966e-120b768f4598");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "bdf629bc-c5ae-4f81-ac27-6c6916ae133c");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "be8c136f-54cb-47b2-b4c9-c4da553c43b2");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "c08a260f-2b0f-48ce-a27a-c79bbbfb6d5c");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "cb1e0599-1166-43f1-8acd-83666bded89f");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "db1ad6c0-cd02-4b8b-900b-29531f38a673");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "f39e853c-ea37-44fb-92da-e1d6d2278dd9");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "008edf5d-09fe-4ff3-bf7a-5fac68152783");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "635fcaba-2396-4696-9c49-1d8ed0b01c2b");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "66dda11a-4eea-4d92-bd49-cfed884dcf36");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "9ba52110-2263-4128-ae78-f116fab543bd");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "adf1c80d-0c67-4cdc-8c15-bcea5555385e");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "e961b4ae-f75b-4584-a946-c171cbb3223a");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Restaurants");

            migrationBuilder.CreateTable(
                name: "BusinessHour",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(767)", nullable: false),
                    OpeningHour = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClosingHour = table.Column<DateTime>(type: "datetime", nullable: false),
                    Day = table.Column<string>(type: "text", nullable: true),
                    RestaurantID = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessHour", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BusinessHour_Restaurants_RestaurantID",
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
                    { "ff6913dc-5f41-4a3f-b102-8add34729f89", "Kebab" },
                    { "bac590d8-bfdb-4f02-8fb6-c62974586af2", "Vin" },
                    { "1531c8ab-a477-40f0-a22c-a53ed343dae4", "Alcool" },
                    { "204d43d3-405c-4a4f-a2bf-9f616c0d3251", "Jus" },
                    { "cf818423-da1f-478f-880f-5f7d3991f82e", "Snacks" },
                    { "e309f16c-0c4a-489c-aaa3-f13fc57c383b", "Poulet" },
                    { "a5a6c279-c8a8-4508-abc8-7717148209db", "Viande" },
                    { "6932709e-d514-4e22-b850-820d4cb6144b", "Fruits" },
                    { "b61ad9df-74d8-460b-9c16-b4b7af56671a", "Dessert" },
                    { "5afb6bc2-808f-4077-ab88-0565a60506d8", "Sandwich" },
                    { "867f6b76-3c53-465f-8f4c-38f7f9a4b02f", "Cake" },
                    { "476fe5e6-b791-4050-bcd8-7771b77cff28", "Champagne" },
                    { "2398f7f0-4e1a-49de-bef0-e89931d82da9", "Whisky" },
                    { "07f274f4-8ac6-4ccf-a8fe-35b334aef522", "Couscous" },
                    { "c6b1b954-90f7-41f7-96d2-77b3c71db8cc", "Hamburger" },
                    { "f39d1f6c-2498-4a6d-b6f1-b87d8927bf48", "Tacos" },
                    { "ca250579-0fa5-4883-b6b6-65c259f2b875", "Salade" },
                    { "3d5e14b9-5da7-4a26-a320-f4f254641440", "Burger" },
                    { "e367ba1a-2d33-4a95-9e1a-45731df8219a", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "1c6f64d5-0d33-4e49-a9d5-143c1c0fbf7d", "CAFE", null },
                    { "d4a3df78-337f-4942-b4ec-067cf8298d77", "INDIAN", null },
                    { "90bcc333-1e1a-4a0e-bb80-aef829f0f92d", "CHINESE", null },
                    { "8a035158-60c8-4335-935a-1e852f459a6f", "FAST-FOOD", null },
                    { "f8ffe47a-a5ea-488b-902d-30658e5c94a7", "EUROPEAN", null },
                    { "981632cd-8f63-4d07-adce-aad9b4a45ba5", "AFRICAN", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessHour_RestaurantID",
                table: "BusinessHour",
                column: "RestaurantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessHour");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "07f274f4-8ac6-4ccf-a8fe-35b334aef522");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "1531c8ab-a477-40f0-a22c-a53ed343dae4");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "204d43d3-405c-4a4f-a2bf-9f616c0d3251");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "2398f7f0-4e1a-49de-bef0-e89931d82da9");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "3d5e14b9-5da7-4a26-a320-f4f254641440");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "476fe5e6-b791-4050-bcd8-7771b77cff28");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "5afb6bc2-808f-4077-ab88-0565a60506d8");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "6932709e-d514-4e22-b850-820d4cb6144b");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "867f6b76-3c53-465f-8f4c-38f7f9a4b02f");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "a5a6c279-c8a8-4508-abc8-7717148209db");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "b61ad9df-74d8-460b-9c16-b4b7af56671a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "bac590d8-bfdb-4f02-8fb6-c62974586af2");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "c6b1b954-90f7-41f7-96d2-77b3c71db8cc");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ca250579-0fa5-4883-b6b6-65c259f2b875");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "cf818423-da1f-478f-880f-5f7d3991f82e");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e309f16c-0c4a-489c-aaa3-f13fc57c383b");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e367ba1a-2d33-4a95-9e1a-45731df8219a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "f39d1f6c-2498-4a6d-b6f1-b87d8927bf48");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ff6913dc-5f41-4a3f-b102-8add34729f89");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "1c6f64d5-0d33-4e49-a9d5-143c1c0fbf7d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "8a035158-60c8-4335-935a-1e852f459a6f");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "90bcc333-1e1a-4a0e-bb80-aef829f0f92d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "981632cd-8f63-4d07-adce-aad9b4a45ba5");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "d4a3df78-337f-4942-b4ec-067cf8298d77");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "f8ffe47a-a5ea-488b-902d-30658e5c94a7");

            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Restaurants",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "abbe1ab9-eecc-4f61-827c-7f8d03388af6", "Kebab" },
                    { "bdf629bc-c5ae-4f81-ac27-6c6916ae133c", "Vin" },
                    { "171d5a50-75de-4fa7-a99b-086f52e3e0ea", "Alcool" },
                    { "b0168d7d-957c-43d1-966e-120b768f4598", "Jus" },
                    { "f39e853c-ea37-44fb-92da-e1d6d2278dd9", "Snacks" },
                    { "726f20dd-f5a6-470a-9ed6-a0ba204dda42", "Poulet" },
                    { "8887dd25-b6f1-4174-afb3-c5d6586b793d", "Viande" },
                    { "addfbc2d-23b7-47a8-b506-9b454149456a", "Fruits" },
                    { "89a1a192-89c0-4a6f-8617-afbceb41f23a", "Dessert" },
                    { "7a7d4758-249d-4e5f-a3be-0b5cd0243cb4", "Sandwich" },
                    { "44f9059b-f931-4660-8850-6f7aae6732eb", "Cake" },
                    { "37ec6a69-60ac-454b-97a5-d655aee31a4e", "Champagne" },
                    { "5925a3d9-b3fa-4e69-9876-06a6ac9fb53f", "Whisky" },
                    { "be8c136f-54cb-47b2-b4c9-c4da553c43b2", "Couscous" },
                    { "db1ad6c0-cd02-4b8b-900b-29531f38a673", "Hamburger" },
                    { "cb1e0599-1166-43f1-8acd-83666bded89f", "Tacos" },
                    { "41c71115-f9fd-4ad9-a24f-4659d8be2212", "Salade" },
                    { "c08a260f-2b0f-48ce-a27a-c79bbbfb6d5c", "Burger" },
                    { "103d6e25-815f-43fb-bffb-4f768060278a", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "008edf5d-09fe-4ff3-bf7a-5fac68152783", "CAFE", null },
                    { "66dda11a-4eea-4d92-bd49-cfed884dcf36", "INDIAN", null },
                    { "9ba52110-2263-4128-ae78-f116fab543bd", "CHINESE", null },
                    { "635fcaba-2396-4696-9c49-1d8ed0b01c2b", "FAST-FOOD", null },
                    { "adf1c80d-0c67-4cdc-8c15-bcea5555385e", "EUROPEAN", null },
                    { "e961b4ae-f75b-4584-a946-c171cbb3223a", "AFRICAN", null }
                });
        }
    }
}
