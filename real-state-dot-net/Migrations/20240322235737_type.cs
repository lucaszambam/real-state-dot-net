using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealStateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateAcronym",
                table: "City");

            migrationBuilder.AlterColumn<string>(
                name: "StateAcronym",
                table: "City",
                type: "character varying(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateAcronym",
                table: "City",
                column: "StateAcronym",
                principalTable: "State",
                principalColumn: "Acronym");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateAcronym",
                table: "City");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.AlterColumn<string>(
                name: "StateAcronym",
                table: "City",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateAcronym",
                table: "City",
                column: "StateAcronym",
                principalTable: "State",
                principalColumn: "Acronym",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
