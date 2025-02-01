using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicasCRM.Api.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Logradouro = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR", maxLength: 10, nullable: true),
                    Bairro = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: true),
                    Cidade = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Uf = table.Column<string>(type: "CHAR", maxLength: 2, nullable: false),
                    Cep = table.Column<string>(type: "VARCHAR", maxLength: 8, nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedimentos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeProcedimento = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    Duracao = table.Column<short>(type: "SMALLINT", nullable: false),
                    EquipamentosUtilizados = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    ConsumoProdutos = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    FormaPagamento = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoasFisicas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCompleto = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: true),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    Genero = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    TipoCadastro = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasFisicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoasFisicas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoasJuridicas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RazaoSocial = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Cnpj = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    TipoCadastro = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasJuridicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoasJuridicas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    SalaAtendimento = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    ProcedimentoId = table.Column<long>(type: "bigint", nullable: false),
                    Duracao = table.Column<int>(type: "INTEGER", nullable: false),
                    DiaAtendimento = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Profissional = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    StatusAtendimento = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamentos_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Procedimentos_ProcedimentoId",
                        column: x => x.ProcedimentoId,
                        principalTable: "Procedimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesFaciais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrincipaisQueixas = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    PresencaManchasPigmentaresRelacionadasMelanina = table.Column<short>(type: "SMALLINT", nullable: false),
                    PresencasManchasAlteracaoVascular = table.Column<short>(type: "SMALLINT", nullable: false),
                    FormacoesSolidas = table.Column<short>(type: "SMALLINT", nullable: false),
                    FormacoesComConteudoLiquido = table.Column<short>(type: "SMALLINT", nullable: false),
                    LesoesDePele = table.Column<short>(type: "SMALLINT", nullable: false),
                    SequelasOuCicatrizes = table.Column<short>(type: "SMALLINT", nullable: false),
                    AlteracoesPelosFaciais = table.Column<short>(type: "SMALLINT", nullable: false),
                    AlteracoesQueratinizacao = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoCutanea = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoEspessura = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoOleosidade = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClassificacaoSensibilidade = table.Column<short>(type: "SMALLINT", nullable: false),
                    Observacoes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "HabitosFemininos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CicloMenstrualRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAnticoncepcionalRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    Gestante = table.Column<short>(type: "SMALLINT", nullable: false),
                    Lactante = table.Column<short>(type: "SMALLINT", nullable: false),
                    TemFilhos = table.Column<short>(type: "SMALLINT", nullable: false),
                    QuantosFilhos = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    AlimentacaoBalanceada = table.Column<short>(type: "SMALLINT", nullable: false),
                    IntestinoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    SonoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    PraticaAtividadesFisicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    DiasAtividadeFisica = table.Column<short>(type: "SMALLINT", nullable: false),
                    Fumante = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsomeBebidaAlcoolica = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAcidosNaPele = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumoAlcool = table.Column<short>(type: "SMALLINT", nullable: false),
                    AcidosUsados = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    UsaProtetorSolarDiario = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitosFemininos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitosFemininos_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabitosMasculinos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    AlimentacaoBalanceada = table.Column<short>(type: "SMALLINT", nullable: false),
                    IntestinoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    SonoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    PraticaAtividadesFisicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    DiasAtividadeFisica = table.Column<short>(type: "SMALLINT", nullable: false),
                    Fumante = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsomeBebidaAlcoolica = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAcidosNaPele = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumoAlcool = table.Column<short>(type: "SMALLINT", nullable: false),
                    AcidosUsados = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    UsaProtetorSolarDiario = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitosMasculinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitosMasculinos_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoPacientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TratamentosAnteriores = table.Column<string>(type: "VARCHAR", maxLength: 300, nullable: false),
                    Alergias = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    TratamentosOncologicos = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    Hipertensao = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProblemaCardiaco = table.Column<short>(type: "SMALLINT", nullable: false),
                    Marcapasso = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProtesesMetalicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProtesesDentarias = table.Column<short>(type: "SMALLINT", nullable: false),
                    Epilepsia = table.Column<short>(type: "SMALLINT", nullable: false),
                    FazTratamentoMedico = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoPacientes_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medidas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    Busto = table.Column<float>(type: "REAL", nullable: false),
                    BracoEsquerdo = table.Column<float>(type: "REAL", nullable: false),
                    BracoDireito = table.Column<float>(type: "REAL", nullable: false),
                    AbdomenSuperior = table.Column<float>(type: "REAL", nullable: false),
                    Quadril = table.Column<float>(type: "REAL", nullable: false),
                    CoxaEsquerda = table.Column<float>(type: "REAL", nullable: false),
                    CoxaDireita = table.Column<float>(type: "REAL", nullable: false),
                    PanturrilhaEsquerda = table.Column<float>(type: "REAL", nullable: false),
                    PanturrilhaDireita = table.Column<float>(type: "REAL", nullable: false),
                    DataMedicao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medidas_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnamnesesFaciais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AvaliacaoFacialId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnamnesesFaciais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnamnesesFaciais_AvaliacoesFaciais_AvaliacaoFacialId",
                        column: x => x.AvaliacaoFacialId,
                        principalTable: "AvaliacoesFaciais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnamnesesFaciais_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesCorporais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrincipaisQueixas = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    MedidasId = table.Column<long>(type: "bigint", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    AnotacoesTratamentoEscolhido = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    DataAvaliacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Observacoes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
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
                name: "AnamnesesCorporais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AvaliacaoCorporalId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnamnesesCorporais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnamnesesCorporais_AvaliacoesCorporais_AvaliacaoCorporalId",
                        column: x => x.AvaliacaoCorporalId,
                        principalTable: "AvaliacoesCorporais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnamnesesCorporais_PessoasFisicas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "PessoasFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ClienteId",
                table: "Agendamentos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ProcedimentoId",
                table: "Agendamentos",
                column: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesCorporais_AvaliacaoCorporalId",
                table: "AnamnesesCorporais",
                column: "AvaliacaoCorporalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesCorporais_ClienteId",
                table: "AnamnesesCorporais",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesFaciais_AvaliacaoFacialId",
                table: "AnamnesesFaciais",
                column: "AvaliacaoFacialId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesFaciais_ClienteId",
                table: "AnamnesesFaciais",
                column: "ClienteId");

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

            migrationBuilder.CreateIndex(
                name: "IX_HabitosFemininos_ClienteId",
                table: "HabitosFemininos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitosMasculinos_ClienteId",
                table: "HabitosMasculinos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPacientes_ClienteId",
                table: "HistoricoPacientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Medidas_ClienteId",
                table: "Medidas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoasFisicas_EnderecoId",
                table: "PessoasFisicas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoasJuridicas_EnderecoId",
                table: "PessoasJuridicas",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "AnamnesesCorporais");

            migrationBuilder.DropTable(
                name: "AnamnesesFaciais");

            migrationBuilder.DropTable(
                name: "HabitosFemininos");

            migrationBuilder.DropTable(
                name: "HabitosMasculinos");

            migrationBuilder.DropTable(
                name: "HistoricoPacientes");

            migrationBuilder.DropTable(
                name: "PessoasJuridicas");

            migrationBuilder.DropTable(
                name: "Procedimentos");

            migrationBuilder.DropTable(
                name: "AvaliacoesCorporais");

            migrationBuilder.DropTable(
                name: "AvaliacoesFaciais");

            migrationBuilder.DropTable(
                name: "Medidas");

            migrationBuilder.DropTable(
                name: "PessoasFisicas");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
