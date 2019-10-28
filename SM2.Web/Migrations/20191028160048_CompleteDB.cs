using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SM2.Web.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nameCity = table.Column<string>(nullable: true),
                    CitiesId = table.Column<int>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_Request = table.Column<int>(nullable: false),
                    state_request = table.Column<int>(nullable: false),
                    Registration_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reps",
                columns: table => new
                {
                    rep_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    activo = table.Column<int>(nullable: false),
                    tipo = table.Column<int>(nullable: false),
                    cedula = table.Column<int>(nullable: false),
                    empresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reps", x => x.rep_id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nomnbre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Requests", x => x.Id);
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
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<int>(nullable: false),
                    CitiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
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
                    TypeDisabilitiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disabilities_TypeDisabilities_TypeDisabilitiesId",
                        column: x => x.TypeDisabilitiesId,
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

            migrationBuilder.CreateTable(
                name: "Problem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clase_solicitud = table.Column<int>(nullable: false),
                    Date_Register = table.Column<DateTime>(nullable: false),
                    rep = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    CesantiaId = table.Column<int>(nullable: true),
                    DisabilityId = table.Column<int>(nullable: true),
                    LicenseId = table.Column<int>(nullable: true),
                    LoanId = table.Column<int>(nullable: true),
                    TransferId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Problem_Cesantias_CesantiaId",
                        column: x => x.CesantiaId,
                        principalTable: "Cesantias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Problem_Disabilities_DisabilityId",
                        column: x => x.DisabilityId,
                        principalTable: "Disabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Problem_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Problem_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Problem_Transfers_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfers",
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
                name: "IX_Disabilities_TypeDisabilitiesId",
                table: "Disabilities",
                column: "TypeDisabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_TypeLicensesId",
                table: "Licenses",
                column: "TypeLicensesId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_TypeLoansId",
                table: "Loans",
                column: "TypeLoansId");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_CesantiaId",
                table: "Problem",
                column: "CesantiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_DisabilityId",
                table: "Problem",
                column: "DisabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_LicenseId",
                table: "Problem",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_LoanId",
                table: "Problem",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_TransferId",
                table: "Problem",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_CitiesId",
                table: "Transfers",
                column: "CitiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Problem");

            migrationBuilder.DropTable(
                name: "Reps");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Type_Requests");

            migrationBuilder.DropTable(
                name: "Cesantias");

            migrationBuilder.DropTable(
                name: "Disabilities");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "TypeCesantias");

            migrationBuilder.DropTable(
                name: "TypeDisabilities");

            migrationBuilder.DropTable(
                name: "TypeLicenses");

            migrationBuilder.DropTable(
                name: "TypeLoans");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
