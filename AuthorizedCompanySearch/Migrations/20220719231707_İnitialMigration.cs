using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorizedCompanySearch.Migrations
{
    public partial class İnitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirmModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_FirmModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmId = table.Column<int>(type: "int", nullable: false),
                    FirmModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelModels_FirmModels_FirmModelId",
                        column: x => x.FirmModelId,
                        principalTable: "FirmModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelModels_FirmModelId",
                table: "PersonelModels",
                column: "FirmModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelModels");

            migrationBuilder.DropTable(
                name: "FirmModels");
        }
    }
}
