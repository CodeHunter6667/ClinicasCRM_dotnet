using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicasCRM.Api.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaAtendimento",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Agendamentos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtendimento",
                table: "Agendamentos",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraAtendimento",
                table: "Agendamentos",
                type: "TIME WITHOUT TIME ZONE",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtendimento",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "HoraAtendimento",
                table: "Agendamentos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DiaAtendimento",
                table: "Agendamentos",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duracao",
                table: "Agendamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
