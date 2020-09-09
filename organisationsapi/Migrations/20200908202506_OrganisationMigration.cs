using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace organisationsapi.Migrations
{
    public partial class OrganisationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    bankAccount = table.Column<string>(nullable: false),
                    MFO = table.Column<int>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    status = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Organisation",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true),
                    orgAddress = table.Column<string>(nullable: false),
                    telNumber = table.Column<string>(maxLength: 70, nullable: false),
                    status = table.Column<bool>(nullable: false, defaultValue: true),
                    bankDetailsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Organisation_Bank_bankDetailsid",
                        column: x => x.bankDetailsid,
                        principalTable: "Bank",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_bankDetailsid",
                table: "Organisation",
                column: "bankDetailsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organisation");

            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
