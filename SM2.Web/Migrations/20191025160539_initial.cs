using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SM2.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reps",
                columns: table => new
                {
                    proyecto = table.Column<int>(nullable: false),
                    rep_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ruid = table.Column<string>(maxLength: 50, nullable: true),
                    rname = table.Column<string>(maxLength: 100, nullable: true),
                    remail = table.Column<string>(maxLength: 50, nullable: true),
                    ractivo = table.Column<int>(nullable: false),
                    rtipo = table.Column<int>(nullable: false),
                    pais = table.Column<int>(nullable: false),
                    rcedula = table.Column<int>(nullable: false),
                    rempresa = table.Column<int>(nullable: false),
                    rcodigo = table.Column<string>(maxLength: 20, nullable: true),
                    rextension = table.Column<string>(maxLength: 20, nullable: true),
                    rdependencia = table.Column<int>(nullable: false),
                    rsede = table.Column<int>(nullable: false),
                    rceco = table.Column<int>(nullable: false),
                    rorden_interna = table.Column<string>(maxLength: 20, nullable: true),
                    gestiona_tiquetes = table.Column<int>(nullable: false),
                    gerente = table.Column<int>(nullable: false),
                    rcargo = table.Column<int>(nullable: false),
                    directivo = table.Column<int>(nullable: false),
                    tipo_regimen_salarial = table.Column<int>(nullable: false),
                    url_foto = table.Column<string>(maxLength: 100, nullable: true),
                    resp_th = table.Column<int>(nullable: false),
                    resp_aviatur = table.Column<int>(nullable: false),
                    resp_formacion = table.Column<int>(nullable: false),
                    resp_traslados = table.Column<int>(nullable: false),
                    resp_prestamos = table.Column<int>(nullable: false),
                    relacion_laboral = table.Column<int>(nullable: false),
                    resp_plan_e_e = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reps", x => x.rep_id);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeCesantias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCesantias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDisabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDisabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeLoans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeLoans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nameCity = table.Column<string>(nullable: true),
                    CitiesId = table.Column<int>(nullable: true),
                    TransferId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Transfers_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cesantias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<float>(nullable: false),
                    typeCesantia = table.Column<int>(nullable: false),
                    TypeCesantiasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cesantias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cesantias_TypeCesantias_TypeCesantiasId",
                        column: x => x.TypeCesantiasId,
                        principalTable: "TypeCesantias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    initialDate = table.Column<DateTime>(nullable: false),
                    finalDate = table.Column<DateTime>(nullable: false),
                    typeDisability = table.Column<int>(nullable: false),
                    TypeLoansId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disabilities_TypeDisabilities_TypeLoansId",
                        column: x => x.TypeLoansId,
                        principalTable: "TypeDisabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    initialDate = table.Column<DateTime>(nullable: false),
                    finalDate = table.Column<DateTime>(nullable: false),
                    typeDisability = table.Column<int>(nullable: false),
                    TypeLicensesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_TypeLicenses_TypeLicensesId",
                        column: x => x.TypeLicensesId,
                        principalTable: "TypeLicenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeLoan = table.Column<int>(nullable: false),
                    ValorLoan = table.Column<float>(nullable: false),
                    TypeLoansId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_TypeLoans_TypeLoansId",
                        column: x => x.TypeLoansId,
                        principalTable: "TypeLoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cesantias_TypeCesantiasId",
                table: "Cesantias",
                column: "TypeCesantiasId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CitiesId",
                table: "Cities",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_TransferId",
                table: "Cities",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_Disabilities_TypeLoansId",
                table: "Disabilities",
                column: "TypeLoansId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_TypeLicensesId",
                table: "Licenses",
                column: "TypeLicensesId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_TypeLoansId",
                table: "Loans",
                column: "TypeLoansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cesantias");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Disabilities");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Reps");

            migrationBuilder.DropTable(
                name: "TypeCesantias");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "TypeDisabilities");

            migrationBuilder.DropTable(
                name: "TypeLicenses");

            migrationBuilder.DropTable(
                name: "TypeLoans");
        }
    }
}
