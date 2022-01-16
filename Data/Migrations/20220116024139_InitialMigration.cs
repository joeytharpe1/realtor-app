using Microsoft.EntityFrameworkCore.Migrations;

namespace houses.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HouseAddress = table.Column<string>(type: "TEXT", nullable: false),
                    HouseCity = table.Column<string>(type: "TEXT", nullable: false),
                    HouseState = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    HouseZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    HouseBath = table.Column<int>(type: "INTEGER", nullable: false),
                    HouseBed = table.Column<int>(type: "INTEGER", nullable: false),
                    HouseIsAcres = table.Column<bool>(type: "INTEGER", nullable: false),
                    HouseAcres = table.Column<int>(type: "INTEGER", nullable: true),
                    HousePriceRange = table.Column<string>(type: "TEXT", nullable: false),
                    ItemType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.HouseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
