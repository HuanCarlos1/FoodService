using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    public partial class MigrationV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Persons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Persons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "f9f33105-4860-4267-8271-399ed05c7f88", "Kebab" },
                    { "9f34d056-9735-4fb4-8da8-e74a078d42fd", "Vin" },
                    { "1ffbf709-645a-4cd3-8c6f-451c132df3e3", "Alcool" },
                    { "3215b019-cdb9-4e49-9041-4198abf402bf", "Jus" },
                    { "6d5896e0-0254-41a9-ade8-9a01b6f255f2", "Snacks" },
                    { "625626c3-faad-4174-801b-ff28165a9263", "Poulet" },
                    { "e159f085-94bc-4c10-8b94-12dd8a96e670", "Viande" },
                    { "ae7f2d04-f33a-484c-a6a5-2946298b197d", "Fruits" },
                    { "1d62a758-aa6f-4447-a079-9621a8d52c31", "Dessert" },
                    { "dee36cce-c394-49da-a63b-b1cd35fcd158", "Sandwich" },
                    { "cd0e3efa-29ba-4b42-ba45-61d3af5a4651", "Cake" },
                    { "ba80da75-0fd9-4980-bc9f-add553c15c85", "Champagne" },
                    { "2d91d9d3-6e5c-418f-b838-34724320065c", "Whisky" },
                    { "87c72dbc-8584-4645-a1d4-b707b60b6440", "Couscous" },
                    { "11d257c5-f315-4683-91c3-c6a7852ce7e4", "Hamburger" },
                    { "a015897e-548f-4794-937f-ee5cb3352343", "Tacos" },
                    { "e26bd97d-42ec-4437-9749-c32657d39465", "Salade" },
                    { "74f8a1cf-f778-47d1-a73a-6726a3773456", "Burger" },
                    { "7b78bafe-e880-4833-8b5c-8bc6804ae521", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "f3c5d4c5-9166-4366-ac41-ad3d7452eecc", "CAFE", null },
                    { "be3a3f53-1656-4622-b90c-183f76398d59", "INDIAN", null },
                    { "7233fcb5-89bc-42b0-98f2-08b8710b8b8d", "CHINESE", null },
                    { "33192253-4046-4ad8-b709-80c24b8a9c6b", "FAST-FOOD", null },
                    { "8dc3c431-488e-4fcc-8706-845ef12aae45", "EUROPEAN", null },
                    { "5de3e181-802e-4327-9668-0dc9c2005ecf", "AFRICAN", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "11d257c5-f315-4683-91c3-c6a7852ce7e4");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "1d62a758-aa6f-4447-a079-9621a8d52c31");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "1ffbf709-645a-4cd3-8c6f-451c132df3e3");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "2d91d9d3-6e5c-418f-b838-34724320065c");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "3215b019-cdb9-4e49-9041-4198abf402bf");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "625626c3-faad-4174-801b-ff28165a9263");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "6d5896e0-0254-41a9-ade8-9a01b6f255f2");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "74f8a1cf-f778-47d1-a73a-6726a3773456");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "7b78bafe-e880-4833-8b5c-8bc6804ae521");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "87c72dbc-8584-4645-a1d4-b707b60b6440");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "9f34d056-9735-4fb4-8da8-e74a078d42fd");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "a015897e-548f-4794-937f-ee5cb3352343");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ae7f2d04-f33a-484c-a6a5-2946298b197d");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ba80da75-0fd9-4980-bc9f-add553c15c85");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "cd0e3efa-29ba-4b42-ba45-61d3af5a4651");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "dee36cce-c394-49da-a63b-b1cd35fcd158");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e159f085-94bc-4c10-8b94-12dd8a96e670");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e26bd97d-42ec-4437-9749-c32657d39465");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "f9f33105-4860-4267-8271-399ed05c7f88");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "33192253-4046-4ad8-b709-80c24b8a9c6b");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "5de3e181-802e-4327-9668-0dc9c2005ecf");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "7233fcb5-89bc-42b0-98f2-08b8710b8b8d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "8dc3c431-488e-4fcc-8706-845ef12aae45");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "be3a3f53-1656-4622-b90c-183f76398d59");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "f3c5d4c5-9166-4366-ac41-ad3d7452eecc");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Persons");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
