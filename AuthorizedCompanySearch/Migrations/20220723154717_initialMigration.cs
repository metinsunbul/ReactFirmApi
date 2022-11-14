using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorizedCompanySearch.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    FirmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaveAuthority = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Authority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmPerformansScore = table.Column<double>(type: "float", nullable: false),
                    GasOpenningPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.FirmId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    personelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmId = table.Column<int>(type: "int", nullable: false),
                    FirmModelFirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.personelId);
                    table.ForeignKey(
                        name: "FK_Personels_Firms_FirmModelFirmId",
                        column: x => x.FirmModelFirmId,
                        principalTable: "Firms",
                        principalColumn: "FirmId");
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "FirmId", "Address", "Authority", "Email", "FirmPerformansScore", "GasOpenningPercentage", "HaveAuthority", "Name", "Phone", "Title" },
                values: new object[,]
                {
                    { -2, "ankara", "mehmet", "mehmet@subilgi.com", 90.0, 60.0, true, "Subilgi", "0312987454", "Subilgi" },
                    { -1, "ankara", "mehmet2", "mehmet@subilgi.com", 30.0, 50.0, true, "Subilgi2", "0312987454", "Subilgi2" }
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "personelId", "FirmId", "FirmModelFirmId", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { -2, -1, null, "mehmet", "0312945", "sunbul" },
                    { -1, -1, null, "mehmet2", "03129342", "sunbul2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_FirmModelFirmId",
                table: "Personels",
                column: "FirmModelFirmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Firms");
        }
    }
}
