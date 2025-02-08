using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicasCRM.Api.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnamnesesCorporais_AvaliacoesCorporais_AvaliacaoCorporalId",
                table: "AnamnesesCorporais");

            migrationBuilder.DropForeignKey(
                name: "FK_AnamnesesFaciais_AvaliacoesFaciais_AvaliacaoFacialId",
                table: "AnamnesesFaciais");

            migrationBuilder.DropTable(
                name: "AvaliacoesCorporais");

            migrationBuilder.DropTable(
                name: "AvaliacoesFaciais");

            migrationBuilder.DropIndex(
                name: "IX_AnamnesesFaciais_AvaliacaoFacialId",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "AvaliacaoFacialId",
                table: "AnamnesesFaciais");

            migrationBuilder.RenameColumn(
                name: "AvaliacaoCorporalId",
                table: "AnamnesesCorporais",
                newName: "MedidasId");

            migrationBuilder.RenameIndex(
                name: "IX_AnamnesesCorporais_AvaliacaoCorporalId",
                table: "AnamnesesCorporais",
                newName: "IX_AnamnesesCorporais_MedidasId");

            migrationBuilder.AddColumn<short>(
                name: "AlteracoesPelosFaciais",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "AlteracoesQueratinizacao",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ClassificacaoCutanea",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ClassificacaoEspessura",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ClassificacaoOleosidade",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ClassificacaoSensibilidade",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "FormacoesComConteudoLiquido",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "FormacoesSolidas",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "LesoesDePele",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "AnamnesesFaciais",
                type: "VARCHAR",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "PresencaManchasPigmentaresRelacionadasMelanina",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "PresencasManchasAlteracaoVascular",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "PrincipaisQueixas",
                table: "AnamnesesFaciais",
                type: "VARCHAR",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "SequelasOuCicatrizes",
                table: "AnamnesesFaciais",
                type: "SMALLINT",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "AnotacoesTratamentoEscolhido",
                table: "AnamnesesCorporais",
                type: "VARCHAR",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAvaliacao",
                table: "AnamnesesCorporais",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "AnamnesesCorporais",
                type: "VARCHAR",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrincipaisQueixas",
                table: "AnamnesesCorporais",
                type: "VARCHAR",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_AnamnesesCorporais_Medidas_MedidasId",
                table: "AnamnesesCorporais",
                column: "MedidasId",
                principalTable: "Medidas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnamnesesCorporais_Medidas_MedidasId",
                table: "AnamnesesCorporais");

            migrationBuilder.DropColumn(
                name: "AlteracoesPelosFaciais",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "AlteracoesQueratinizacao",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "ClassificacaoCutanea",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "ClassificacaoEspessura",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "ClassificacaoOleosidade",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "ClassificacaoSensibilidade",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "FormacoesComConteudoLiquido",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "FormacoesSolidas",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "LesoesDePele",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "PresencaManchasPigmentaresRelacionadasMelanina",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "PresencasManchasAlteracaoVascular",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "PrincipaisQueixas",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "SequelasOuCicatrizes",
                table: "AnamnesesFaciais");

            migrationBuilder.DropColumn(
                name: "AnotacoesTratamentoEscolhido",
                table: "AnamnesesCorporais");

            migrationBuilder.DropColumn(
                name: "DataAvaliacao",
                table: "AnamnesesCorporais");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "AnamnesesCorporais");

            migrationBuilder.DropColumn(
                name: "PrincipaisQueixas",
                table: "AnamnesesCorporais");

            migrationBuilder.RenameColumn(
                name: "MedidasId",
                table: "AnamnesesCorporais",
                newName: "AvaliacaoCorporalId");

            migrationBuilder.RenameIndex(
                name: "IX_AnamnesesCorporais_MedidasId",
                table: "AnamnesesCorporais",
                newName: "IX_AnamnesesCorporais_AvaliacaoCorporalId");

            migrationBuilder.AddColumn<long>(
                name: "AvaliacaoFacialId",
                table: "AnamnesesFaciais",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "AvaliacoesCorporais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    MedidasId = table.Column<long>(type: "bigint", nullable: false),
                    AnotacoesTratamentoEscolhido = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataAvaliacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    Observacoes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    PrincipaisQueixas = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesCorporais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacoesCorporais_Medidas_MedidasId",
                        column: x => x.MedidasId,
                        principalTable: "Medidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvaliacoesCorporais_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesFaciais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    AlteracoesPelosFaciais = table.Column<short>(type: "SMALLINT", nullable: false),
                    AlteracoesQueratinizacao = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoCutanea = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoEspessura = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoOleosidade = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoSensibilidade = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    FormacoesComConteudoLiquido = table.Column<short>(type: "SMALLINT", nullable: false),
                    FormacoesSolidas = table.Column<short>(type: "SMALLINT", nullable: false),
                    LesoesDePele = table.Column<short>(type: "SMALLINT", nullable: false),
                    Observacoes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    PresencaManchasPigmentaresRelacionadasMelanina = table.Column<short>(type: "SMALLINT", nullable: false),
                    PresencasManchasAlteracaoVascular = table.Column<short>(type: "SMALLINT", nullable: false),
                    PrincipaisQueixas = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    SequelasOuCicatrizes = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesFaciais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacoesFaciais_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesFaciais_AvaliacaoFacialId",
                table: "AnamnesesFaciais",
                column: "AvaliacaoFacialId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesCorporais_ClienteId",
                table: "AvaliacoesCorporais",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesCorporais_MedidasId",
                table: "AvaliacoesCorporais",
                column: "MedidasId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesFaciais_ClienteId",
                table: "AvaliacoesFaciais",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnamnesesCorporais_AvaliacoesCorporais_AvaliacaoCorporalId",
                table: "AnamnesesCorporais",
                column: "AvaliacaoCorporalId",
                principalTable: "AvaliacoesCorporais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnamnesesFaciais_AvaliacoesFaciais_AvaliacaoFacialId",
                table: "AnamnesesFaciais",
                column: "AvaliacaoFacialId",
                principalTable: "AvaliacoesFaciais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
