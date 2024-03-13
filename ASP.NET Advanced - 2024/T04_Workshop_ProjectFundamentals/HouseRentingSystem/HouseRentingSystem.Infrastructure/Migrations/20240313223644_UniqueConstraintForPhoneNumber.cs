using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Agents",
                comment: "House Agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f15e820d-f94f-4259-af48-45024fe8ab2e", "AQAAAAEAACcQAAAAECbrnpfM3DqYu4cpAwJnMHNYQQ2USOF4nl72rr6uEkJoD+p3MEBLrygMS4Mm62fuKw==", "b7cf96bd-ece4-4e27-bea0-da77c9fcc191" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d714ce75-a8be-4c98-8f8c-5fab260ae178", "AQAAAAEAACcQAAAAEAxDR1DOdkWkxViaqOXOdhPIvJzwch6Kxxd0Lz2vw1UqGmhzgmnAqz/wZMhDAs49ZQ==", "9cf130cd-e8bf-4a23-af4f-7efad6f6d3e2" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.AlterTable(
                name: "Agents",
                oldComment: "House Agent");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66aae033-2c76-4353-9fd9-39cc0ddfb37b", "AQAAAAEAACcQAAAAEA1PCQ3sJzjcIU/a9peuRiZoxKQtcQQbU+VR7SzbNXPagkIs7+EifktGqh1Z4TC9Vw==", "06d01c12-5b44-4557-b92f-4eb9ce9de038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0067b932-4e78-46f2-9f4e-bf3a4c64c0b6", "AQAAAAEAACcQAAAAEGaAJ+5xEwmqBkl2ks3ESarOj1zLIb6VRIHDQy2knIroKJ/IVojUtd6T5kJvijCLkA==", "7c4ed769-fdd4-472b-9383-fed398085c09" });
        }
    }
}
