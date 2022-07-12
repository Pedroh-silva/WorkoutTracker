using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workout_Tracker.Migrations
{
    public partial class SeedDataTableExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Barra Fixa" },
                    { 2, "Flexão de braço" },
                    { 3, "Agachamento" },
                    { 4, "Dips" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
