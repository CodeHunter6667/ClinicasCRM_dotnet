using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicasCRM.Api.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Medidas");

            migrationBuilder.DropTable(
                name: "PessoasFisicas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Street = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Number = table.Column<string>(type: "VARCHAR", maxLength: 10, nullable: true),
                    Neighborhood = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Complement = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "CHAR", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "VARCHAR", maxLength: 8, nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcedurePacks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PackName = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR", maxLength: 800, nullable: true),
                    Price = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    Active = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedurePacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProcedureName = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    DurationInMinutes = table.Column<short>(type: "SMALLINT", nullable: false),
                    EquipmentUsed = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    ConsumedProducts = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    PaymentMethod = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "DATE", nullable: true),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    Gender = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    RecordType = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individuals_Addresses_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegalEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    TradeName = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    Cnpj = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: false),
                    StateRegistration = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    CityRegistration = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    RecordType = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalEntities_Addresses_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professionals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<short>(type: "SMALLINT", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    Birthday = table.Column<DateTime>(type: "DATE", nullable: true),
                    ProfessionalNumber = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    ProfessionalCouncil = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    ProfessionalCouncilState = table.Column<string>(type: "VARCHAR", maxLength: 10, nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    RecordType = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professionals_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedurePackProcedure",
                columns: table => new
                {
                    ProcedurePackId = table.Column<long>(type: "bigint", nullable: false),
                    ProcedureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedurePackProcedure", x => new { x.ProcedureId, x.ProcedurePackId });
                    table.ForeignKey(
                        name: "FK_ProcedurePackProcedure_ProcedurePacks_ProcedurePackId",
                        column: x => x.ProcedurePackId,
                        principalTable: "ProcedurePacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcedurePackProcedure_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacialAnamnesis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainComplaints = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    MelaninRelatedPigmentSpotsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    VascularAlterationSpotsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    SolidFormationsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    LiquidContentFormationsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    SkinLesionsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    SequelaeOrScarsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    FacialHairAlterationsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    KeratinizationAlterationsPresent = table.Column<short>(type: "SMALLINT", nullable: false),
                    SkinClassification = table.Column<short>(type: "SMALLINT", nullable: false),
                    SkinThicknessClassification = table.Column<short>(type: "SMALLINT", nullable: false),
                    OilinessClassification = table.Column<short>(type: "SMALLINT", nullable: false),
                    SensitivityClassification = table.Column<short>(type: "SMALLINT", nullable: false),
                    Notes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacialAnamnesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacialAnamnesis_Individuals_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FemaleHabits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegularMenstrualCycle = table.Column<short>(type: "SMALLINT", nullable: false),
                    RegularContraceptiveUse = table.Column<short>(type: "SMALLINT", nullable: false),
                    Pregnant = table.Column<short>(type: "SMALLINT", nullable: false),
                    Breastfeeding = table.Column<short>(type: "SMALLINT", nullable: false),
                    HasChildren = table.Column<short>(type: "SMALLINT", nullable: false),
                    NumberOfChildren = table.Column<short>(type: "SMALLINT", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    BalencedDiet = table.Column<short>(type: "SMALLINT", nullable: false),
                    RegularBowels = table.Column<short>(type: "SMALLINT", nullable: false),
                    RegularSleep = table.Column<short>(type: "SMALLINT", nullable: false),
                    PracticesPhysicalActivities = table.Column<short>(type: "SMALLINT", nullable: false),
                    PhysicalActivityDaysPerWeek = table.Column<short>(type: "SMALLINT", nullable: false),
                    Smoker = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumesAlcoholicBeverage = table.Column<short>(type: "SMALLINT", nullable: false),
                    UseAcidOnSkin = table.Column<short>(type: "SMALLINT", nullable: false),
                    AlcoholConsumptionFrequency = table.Column<short>(type: "SMALLINT", nullable: false),
                    AcidsUsed = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    UsesDailySunscreen = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FemaleHabits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FemaleHabits_Individuals_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaleHabits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    BalencedDiet = table.Column<short>(type: "SMALLINT", nullable: false),
                    RegularBowels = table.Column<short>(type: "SMALLINT", nullable: false),
                    RegularSleep = table.Column<short>(type: "SMALLINT", nullable: false),
                    PracticesPhysicalActivities = table.Column<short>(type: "SMALLINT", nullable: false),
                    PhysicalActivityDaysPerWeek = table.Column<short>(type: "SMALLINT", nullable: false),
                    Smoker = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumesAlcoholicBeverage = table.Column<short>(type: "SMALLINT", nullable: false),
                    UseAcidOnSkin = table.Column<short>(type: "SMALLINT", nullable: false),
                    AlcoholConsumptionFrequency = table.Column<short>(type: "SMALLINT", nullable: false),
                    AcidsUsed = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    UsesDailySunscreen = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaleHabits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaleHabits_Individuals_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Height = table.Column<float>(type: "REAL", nullable: false),
                    Bust = table.Column<float>(type: "REAL", nullable: false),
                    LeftArm = table.Column<float>(type: "REAL", nullable: false),
                    RightArm = table.Column<float>(type: "REAL", nullable: false),
                    UpperAbdomen = table.Column<float>(type: "REAL", nullable: false),
                    Hip = table.Column<float>(type: "REAL", nullable: false),
                    LeftThigh = table.Column<float>(type: "REAL", nullable: false),
                    RightThigh = table.Column<float>(type: "REAL", nullable: false),
                    LeftCalf = table.Column<float>(type: "REAL", nullable: false),
                    RightCalf = table.Column<double>(type: "double precision", nullable: false),
                    MeasurementDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_Individuals_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientHistories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PreviousTreatments = table.Column<string>(type: "VARCHAR", maxLength: 300, nullable: false),
                    Allergies = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    OncologicalTreatments = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    Hypertension = table.Column<short>(type: "SMALLINT", nullable: false),
                    HeartProblem = table.Column<short>(type: "SMALLINT", nullable: false),
                    Pacemaker = table.Column<short>(type: "SMALLINT", nullable: false),
                    MetalProstheses = table.Column<short>(type: "SMALLINT", nullable: false),
                    DentalProstheses = table.Column<short>(type: "SMALLINT", nullable: false),
                    Epilepsy = table.Column<short>(type: "SMALLINT", nullable: false),
                    UnderMedicalTreatment = table.Column<short>(type: "SMALLINT", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientHistories_Individuals_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<long>(type: "bigint", nullable: false),
                    ProcedureRoom = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    ProcedureId = table.Column<long>(type: "bigint", nullable: false),
                    AppoitmentTime = table.Column<TimeSpan>(type: "TIME WITHOUT TIME ZONE", nullable: false),
                    AppoitmentDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    ProfessionalId = table.Column<long>(type: "bigint", nullable: false),
                    AppoitmentStatus = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Individuals_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyAnamnesis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainComplaints = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    MeasurementsId = table.Column<long>(type: "bigint", nullable: false),
                    MeasurementId = table.Column<long>(type: "bigint", nullable: false),
                    ChosenTreatmentNotes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Notes = table.Column<string>(type: "VARCHAR", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    IsSaved = table.Column<short>(type: "SMALLINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    UpdatedBy = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UserId = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyAnamnesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyAnamnesis_Individuals_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyAnamnesis_Measurements_MeasurementsId",
                        column: x => x.MeasurementsId,
                        principalTable: "Measurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ProcedureId",
                table: "Appointments",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ProfessionalId",
                table: "Appointments",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyAnamnesis_ClientId",
                table: "BodyAnamnesis",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyAnamnesis_MeasurementsId",
                table: "BodyAnamnesis",
                column: "MeasurementsId");

            migrationBuilder.CreateIndex(
                name: "IX_FacialAnamnesis_ClienteId",
                table: "FacialAnamnesis",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_FemaleHabits_ClientId",
                table: "FemaleHabits",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_EnderecoId",
                table: "Individuals",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalEntities_EnderecoId",
                table: "LegalEntities",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_MaleHabits_ClienteId",
                table: "MaleHabits",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ClientId",
                table: "Measurements",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientHistories_ClientId",
                table: "PatientHistories",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedurePackProcedure_ProcedurePackId",
                table: "ProcedurePackProcedure",
                column: "ProcedurePackId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_AddressId",
                table: "Professionals",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "BodyAnamnesis");

            migrationBuilder.DropTable(
                name: "FacialAnamnesis");

            migrationBuilder.DropTable(
                name: "FemaleHabits");

            migrationBuilder.DropTable(
                name: "LegalEntities");

            migrationBuilder.DropTable(
                name: "MaleHabits");

            migrationBuilder.DropTable(
                name: "PatientHistories");

            migrationBuilder.DropTable(
                name: "ProcedurePackProcedure");

            migrationBuilder.DropTable(
                name: "Professionals");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "ProcedurePacks");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bairro = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Cep = table.Column<string>(type: "VARCHAR", maxLength: 8, nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    Logradouro = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR", maxLength: 10, nullable: true),
                    Uf = table.Column<string>(type: "CHAR", maxLength: 2, nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
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
                    ConsumoProdutos = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Duracao = table.Column<short>(type: "SMALLINT", nullable: false),
                    EquipamentosUtilizados = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    FormaPagamento = table.Column<short>(type: "SMALLINT", nullable: false),
                    NomeProcedimento = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
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
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "DATE", nullable: true),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    Genero = table.Column<short>(type: "SMALLINT", nullable: false),
                    NomeCompleto = table.Column<string>(type: "VARCHAR", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    TipoCadastro = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
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
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Cnpj = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    NomeFantasia = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    RazaoSocial = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    TipoCadastro = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
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
                    ProcedimentoId = table.Column<long>(type: "bigint", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataAtendimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    HoraAtendimento = table.Column<TimeSpan>(type: "TIME WITHOUT TIME ZONE", nullable: false),
                    Profissional = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    SalaAtendimento = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    StatusAtendimento = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
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
                name: "AnamnesesFaciais",
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
                    table.PrimaryKey("PK_AnamnesesFaciais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnamnesesFaciais_PessoasFisicas_ClienteId",
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
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    AcidosUsados = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    AlimentacaoBalanceada = table.Column<short>(type: "SMALLINT", nullable: false),
                    CicloMenstrualRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsomeBebidaAlcoolica = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumoAlcool = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DiasAtividadeFisica = table.Column<short>(type: "SMALLINT", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    Fumante = table.Column<short>(type: "SMALLINT", nullable: false),
                    Gestante = table.Column<short>(type: "SMALLINT", nullable: false),
                    IntestinoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    Lactante = table.Column<short>(type: "SMALLINT", nullable: false),
                    PraticaAtividadesFisicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    QuantosFilhos = table.Column<short>(type: "SMALLINT", nullable: false),
                    SonoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    TemFilhos = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsaProtetorSolarDiario = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAcidosNaPele = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAnticoncepcionalRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
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
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    AcidosUsados = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    AlimentacaoBalanceada = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsomeBebidaAlcoolica = table.Column<short>(type: "SMALLINT", nullable: false),
                    ConsumoAlcool = table.Column<short>(type: "SMALLINT", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DiasAtividadeFisica = table.Column<short>(type: "SMALLINT", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    Fumante = table.Column<short>(type: "SMALLINT", nullable: false),
                    IntestinoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    PraticaAtividadesFisicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    SonoRegular = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsaProtetorSolarDiario = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsoAcidosNaPele = table.Column<short>(type: "SMALLINT", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    UsuarioId = table.Column<long>(type: "BIGINT", nullable: false)
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
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    Alergias = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Epilepsia = table.Column<short>(type: "SMALLINT", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    FazTratamentoMedico = table.Column<short>(type: "SMALLINT", nullable: false),
                    Hipertensao = table.Column<short>(type: "SMALLINT", nullable: false),
                    Marcapasso = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProblemaCardiaco = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProtesesDentarias = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProtesesMetalicas = table.Column<short>(type: "SMALLINT", nullable: false),
                    TratamentosAnteriores = table.Column<string>(type: "VARCHAR", maxLength: 300, nullable: false),
                    TratamentosOncologicos = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
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
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    AbdomenSuperior = table.Column<float>(type: "REAL", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    BracoDireito = table.Column<float>(type: "REAL", nullable: false),
                    BracoEsquerdo = table.Column<float>(type: "REAL", nullable: false),
                    Busto = table.Column<float>(type: "REAL", nullable: false),
                    CoxaDireita = table.Column<float>(type: "REAL", nullable: false),
                    CoxaEsquerda = table.Column<float>(type: "REAL", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DataMedicao = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EstaSalva = table.Column<short>(type: "SMALLINT", nullable: false),
                    PanturrilhaDireita = table.Column<float>(type: "REAL", nullable: false),
                    PanturrilhaEsquerda = table.Column<float>(type: "REAL", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Quadril = table.Column<float>(type: "REAL", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "text", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
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
                name: "AnamnesesCorporais",
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
                    table.PrimaryKey("PK_AnamnesesCorporais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnamnesesCorporais_Medidas_MedidasId",
                        column: x => x.MedidasId,
                        principalTable: "Medidas",
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
                name: "IX_AnamnesesCorporais_ClienteId",
                table: "AnamnesesCorporais",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesCorporais_MedidasId",
                table: "AnamnesesCorporais",
                column: "MedidasId");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesesFaciais_ClienteId",
                table: "AnamnesesFaciais",
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
    }
}
