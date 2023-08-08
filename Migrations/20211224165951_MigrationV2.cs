using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamall_foods_server_aspNetCore.Migrations
{
    public partial class MigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "27b04e99-2b3d-4386-989b-f85553e8fcbc");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "27d7384d-b196-4c90-b0cb-78fb689937d7");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "48887641-e80e-4d92-8b60-ba2bf24229eb");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "4aeaf25a-5539-4e76-b28c-4c36a83d66ab");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "5906b795-3b45-4a17-9af5-1c9afb5d866b");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "5908789e-d7ae-4322-889c-196ebadb7184");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "8030fc27-71a9-437c-a8bb-54f3714b0d5e");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "881ac0bf-8976-40ad-8b42-2ce2ec8631c9");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "95e222aa-80c6-4d24-ab41-3d64930c9a6d");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "99827733-e87e-4195-8ae7-0b0ed666444c");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "a04cb51a-7f17-43f2-9fba-eb84436aa77d");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "a3f78f2a-ffb8-47c3-8471-6a2bc319f8d7");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "b1887216-6600-4570-8d95-fe5da4aaad47");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "b7b2ff2d-a0d1-4e9e-b5e7-03305b5dd008");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e52a6530-b838-4e25-b4bb-33658f4e5cb3");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e8e01eb7-3e3f-4f09-9db3-caaba234cb30");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ed5b592b-7803-468c-83b7-cd99e7ce7416");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "fd8146d4-ca3c-4a74-9442-a3337b3cef0d");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ff7450fb-b1e6-40e4-9044-d187013c5c9d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "35897515-45bc-4cb3-8f41-9dad3dad3753");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "5c2ba2a7-391d-45c3-8590-24e594a815b3");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "64aea1f5-f3e6-44ab-adcf-aeea45a91ee1");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "82d7f5e2-eaa5-4e22-8d19-5f6788a4f2e8");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "b0f9b97d-2c76-4f25-9153-f431d1423006");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "ece9b188-ebf3-46bc-a2cb-41e3516232d9");

            migrationBuilder.AddColumn<string>(
                name: "AccountValidationToken",
                table: "Persons",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "89ef60dd-8fcf-40ca-b050-aaed7468f59f", "Kebab" },
                    { "1c4804ce-8f22-4db2-abf9-a1ef35b5ac6c", "Vin" },
                    { "3e903ddb-c9fb-4565-9a09-8f81070abc12", "Alcool" },
                    { "c7018b87-9e55-474a-88e9-1264925ebf05", "Jus" },
                    { "b160b91d-0c18-4c3c-8b86-bb8b5aa67f4e", "Snacks" },
                    { "264f058e-6dda-4556-86c4-953c324ecd16", "Poulet" },
                    { "cef693d6-5112-4ffc-96a4-61390468d9ab", "Viande" },
                    { "348e0c47-ce0e-4b11-9621-bbfe3ac3b6a5", "Fruits" },
                    { "35630f60-0175-4875-be5b-981cd6cffbfc", "Dessert" },
                    { "8601defd-adfe-413f-84da-bb32c793c7b9", "Sandwich" },
                    { "68dcd26f-a205-452d-97d2-2ddaaf0c88cd", "Cake" },
                    { "69c39e1a-e7ef-4b41-9bc0-ae68b39e061a", "Champagne" },
                    { "e2db1d36-e2a0-45de-ab1b-1882f1e5dc31", "Whisky" },
                    { "ea662319-e48e-45ba-b0e5-043951ef2962", "Couscous" },
                    { "84204c5a-f5af-4353-aabc-f095eecb1237", "Hamburger" },
                    { "9c708a91-ad6a-4d5a-a3e3-ed6dd6ea1c23", "Tacos" },
                    { "6b05e004-064a-4908-ba86-d5183af4c066", "Salade" },
                    { "16412381-b6cd-4520-a680-89346b58e1bf", "Burger" },
                    { "c7edb43a-07d3-4adf-80b3-e050ca6dcbfe", "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTypes",
                columns: new[] { "ID", "Name", "RestaurantID" },
                values: new object[,]
                {
                    { "33c24893-564c-47a7-ae57-6530d01bd39f", "CAFE", null },
                    { "094f95c1-15a9-4b73-8c4d-6a62da310a7c", "INDIAN", null },
                    { "2ee3a2fb-b586-4fc4-aa77-b9245c4a9dcd", "CHINESE", null },
                    { "9968f0a2-ba3f-458d-b447-563292c75bb3", "FAST-FOOD", null },
                    { "b09ed667-95d7-429f-9188-b22aa3821f47", "EUROPEAN", null },
                    { "530c1e45-386a-4f69-8b5e-a622501d9a3d", "AFRICAN", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "16412381-b6cd-4520-a680-89346b58e1bf");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "1c4804ce-8f22-4db2-abf9-a1ef35b5ac6c");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "264f058e-6dda-4556-86c4-953c324ecd16");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "348e0c47-ce0e-4b11-9621-bbfe3ac3b6a5");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "35630f60-0175-4875-be5b-981cd6cffbfc");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "3e903ddb-c9fb-4565-9a09-8f81070abc12");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "68dcd26f-a205-452d-97d2-2ddaaf0c88cd");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "69c39e1a-e7ef-4b41-9bc0-ae68b39e061a");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "6b05e004-064a-4908-ba86-d5183af4c066");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "84204c5a-f5af-4353-aabc-f095eecb1237");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "8601defd-adfe-413f-84da-bb32c793c7b9");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "89ef60dd-8fcf-40ca-b050-aaed7468f59f");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "9c708a91-ad6a-4d5a-a3e3-ed6dd6ea1c23");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "b160b91d-0c18-4c3c-8b86-bb8b5aa67f4e");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "c7018b87-9e55-474a-88e9-1264925ebf05");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "c7edb43a-07d3-4adf-80b3-e050ca6dcbfe");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "cef693d6-5112-4ffc-96a4-61390468d9ab");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "e2db1d36-e2a0-45de-ab1b-1882f1e5dc31");

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "ID",
                keyValue: "ea662319-e48e-45ba-b0e5-043951ef2962");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "094f95c1-15a9-4b73-8c4d-6a62da310a7c");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "2ee3a2fb-b586-4fc4-aa77-b9245c4a9dcd");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "33c24893-564c-47a7-ae57-6530d01bd39f");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "530c1e45-386a-4f69-8b5e-a622501d9a3d");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "9968f0a2-ba3f-458d-b447-563292c75bb3");

            migrationBuilder.DeleteData(
                table: "RestaurantTypes",
                keyColumn: "ID",
                keyValue: "b09ed667-95d7-429f-9188-b22aa3821f47");

            migrationBuilder.DropColumn(
                name: "AccountValidationToken",
                table: "Persons");

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
        }
    }
}
