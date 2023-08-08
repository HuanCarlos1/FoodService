using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    public partial class MigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "0409959e-0f44-4881-a665-5d8ab09a70e3");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "09667632-89df-4640-9210-5f0558c99344");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "0a37d4e5-f803-438a-9645-952d7d2601a5");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "19ad7a77-458f-42c7-b402-e58a7bb08203");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "2a804dc4-fcbd-4ebe-b61b-0165f7d60e19");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "2ab7d096-dfaa-4d58-9721-86d1723df4cf");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "2d2fb347-d445-498a-aa0b-d92b86206846");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "3122c899-6349-4f19-899c-efaa593c82d2");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "4ebdc488-7f40-4154-a492-46c24f445651");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "5849aa7e-343e-42d4-a01e-d1dce9e9e01f");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "6b1867f0-b650-4dd9-997c-570225629e72");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "7a59d830-cce2-4dd9-b385-8adec6f63ea9");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "82a02a76-09ea-4968-92d3-c1726a912cd0");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "83b50678-23b9-4caf-8058-82c8853e5c78");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ab28453d-12b7-431d-b8db-8393e122a852");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "bb11c982-6a1b-4aee-a721-e49507cf1040");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e17c3338-15f4-4e6d-a5bd-1674ef9e313a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "efd89080-bb58-44d3-bc04-7863730bf9ce");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "f5429554-06af-463d-af4c-51a966257efe");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "4dd55bdc-a35e-4e24-9def-de46f04bc65d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "60138805-724d-4051-ba67-5dd24fba811c");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "6bb417aa-da89-496d-98f6-462936418a9f");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "b118543f-3221-488d-bc17-1d2901b091de");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "c0335f6e-9b56-43f9-af99-090602fc209a");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "df10e173-4c13-494a-9a5c-1bc25b7100fc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "2ab7d096-dfaa-4d58-9721-86d1723df4cf", "Kebab" },
                    { "0a37d4e5-f803-438a-9645-952d7d2601a5", "Vin" },
                    { "efd89080-bb58-44d3-bc04-7863730bf9ce", "Alcool" },
                    { "19ad7a77-458f-42c7-b402-e58a7bb08203", "Jus" },
                    { "5849aa7e-343e-42d4-a01e-d1dce9e9e01f", "Snacks" },
                    { "0409959e-0f44-4881-a665-5d8ab09a70e3", "Poulet" },
                    { "2a804dc4-fcbd-4ebe-b61b-0165f7d60e19", "Viande" },
                    { "e17c3338-15f4-4e6d-a5bd-1674ef9e313a", "Fruits" },
                    { "7a59d830-cce2-4dd9-b385-8adec6f63ea9", "Dessert" },
                    { "3122c899-6349-4f19-899c-efaa593c82d2", "Sandwich" },
                    { "82a02a76-09ea-4968-92d3-c1726a912cd0", "Cake" },
                    { "bb11c982-6a1b-4aee-a721-e49507cf1040", "Champagne" },
                    { "f5429554-06af-463d-af4c-51a966257efe", "Whisky" },
                    { "4ebdc488-7f40-4154-a492-46c24f445651", "Couscous" },
                    { "83b50678-23b9-4caf-8058-82c8853e5c78", "Hamburger" },
                    { "09667632-89df-4640-9210-5f0558c99344", "Tacos" },
                    { "2d2fb347-d445-498a-aa0b-d92b86206846", "Salade" },
                    { "6b1867f0-b650-4dd9-997c-570225629e72", "Burger" },
                    { "ab28453d-12b7-431d-b8db-8393e122a852", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "b118543f-3221-488d-bc17-1d2901b091de", "CAFE", null },
                    { "4dd55bdc-a35e-4e24-9def-de46f04bc65d", "INDIAN", null },
                    { "c0335f6e-9b56-43f9-af99-090602fc209a", "CHINESE", null },
                    { "df10e173-4c13-494a-9a5c-1bc25b7100fc", "FAST-FOOD", null },
                    { "6bb417aa-da89-496d-98f6-462936418a9f", "EUROPEAN", null },
                    { "60138805-724d-4051-ba67-5dd24fba811c", "AFRICAN", null }
                });
        }
    }
}
