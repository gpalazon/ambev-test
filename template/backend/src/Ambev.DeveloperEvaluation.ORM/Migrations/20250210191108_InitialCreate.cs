﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
            //        Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
            //        Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
            //        Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
            //        Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
            //        Role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                    name: "Users",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(nullable: false, defaultValueSql: "gen_random_uuid()"),
                        Username = table.Column<string>(maxLength: 50, nullable: false),
                        Email = table.Column<string>(maxLength: 100, nullable: false),
                        Password = table.Column<string>(maxLength: 100, nullable: false),
                        Phone = table.Column<string>(maxLength: 20, nullable: false),
                        Role = table.Column<string>(maxLength: 20, nullable: false),
                        Status = table.Column<string>(maxLength: 20, nullable: false),
                        CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "NOW()"),
                        UpdatedAt = table.Column<DateTime>(nullable: true, defaultValueSql: "NOW()")
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Id);
                    });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
