using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class fixTheDBNamePointsOfInterest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterests_Cities_CityId",
                table: "PointsOfInterests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterests",
                table: "PointsOfInterests");

            migrationBuilder.RenameTable(
                name: "PointsOfInterests",
                newName: "PointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterests_CityId",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "PointsOfInterests");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterests",
                newName: "IX_PointsOfInterests_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterests",
                table: "PointsOfInterests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterests_Cities_CityId",
                table: "PointsOfInterests",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
