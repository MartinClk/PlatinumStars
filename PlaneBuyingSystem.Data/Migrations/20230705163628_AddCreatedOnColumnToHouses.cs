using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlaneBuyingSystem.Data.Migrations
{
    public partial class AddCreatedOnColumnToHouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("c26846bb-2c2e-443f-8644-43a7eb0402cd"));

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("d6677c00-7c0f-4fe3-8dd0-15659381d82a"));

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("de1f71a9-93b0-4bb1-9687-44786c6f15a5"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Planes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 5, 16, 36, 28, 398, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("43a2fa10-a0e8-4e10-bdb2-5390c02fd640"), "Frankfurt Airport, Germany", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), new Guid("41039743-5044-4dde-9f17-106a09de88a2"), 1, "The Boeing 787 is an American wide-body jet airliner developed and manufactured by Boeing Commercial Airplanes.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg/330px-All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg", 60000000m, "Airbus 787-8" });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("4c0aea5c-1e2b-43d7-9712-fef5ea62a272"), "Moscow Airport, Russia", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), null, 3, "A strategic airlift cargo aircraft designed and produced by the Antonov Design Bureau in the Soviet Union.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Antonov_An-225_Beltyukov-1.jpg/450px-Antonov_An-225_Beltyukov-1.jpg", 700000000m, "Antonov An-225-Mriya" });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("ba7827a0-9c6a-4a0c-81ed-b40bd94d4714"), "Paris Airport, France", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), null, 2, "A continuation of the Elite program's vision to redefine the very light jet category with superior performance and efficiency born from aerodynamic breakthrough.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNonihuIe20wq6mDf5LHUWDsiQ4GCmYXZuaw&usqp=CAU", 150000000m, "HondaJet Elite" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("43a2fa10-a0e8-4e10-bdb2-5390c02fd640"));

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("4c0aea5c-1e2b-43d7-9712-fef5ea62a272"));

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: new Guid("ba7827a0-9c6a-4a0c-81ed-b40bd94d4714"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Planes");

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("c26846bb-2c2e-443f-8644-43a7eb0402cd"), "Frankfurt Airport, Germany", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), new Guid("41039743-5044-4dde-9f17-106a09de88a2"), 1, "The Boeing 787 is an American wide-body jet airliner developed and manufactured by Boeing Commercial Airplanes.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg/330px-All_Nippon_Airways%2C_Boeing_787-8%2C_JA823A_%2814305502433%29.jpg", 60000000m, "Airbus 787-8" });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("d6677c00-7c0f-4fe3-8dd0-15659381d82a"), "Paris Airport, France", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), null, 2, "A continuation of the Elite program's vision to redefine the very light jet category with superior performance and efficiency born from aerodynamic breakthrough.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNonihuIe20wq6mDf5LHUWDsiQ4GCmYXZuaw&usqp=CAU", 150000000m, "HondaJet Elite" });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Address", "AgentId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("de1f71a9-93b0-4bb1-9687-44786c6f15a5"), "Moscow Airport, Russia", new Guid("f4069da7-55dc-41e6-a80f-3b188aaa0d9f"), null, 3, "A strategic airlift cargo aircraft designed and produced by the Antonov Design Bureau in the Soviet Union.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Antonov_An-225_Beltyukov-1.jpg/450px-Antonov_An-225_Beltyukov-1.jpg", 700000000m, "Antonov An-225-Mriya" });
        }
    }
}
