﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SM2.Web.Data;

namespace SM2.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SM2.Web.Data.Disability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypeDisabilitiesId");

                    b.Property<DateTime>("finalDate");

                    b.Property<DateTime>("initialDate");

                    b.Property<int>("typeDisability");

                    b.HasKey("Id");

                    b.HasIndex("TypeDisabilitiesId");

                    b.ToTable("Disabilities");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Cesantia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypeCesantiasId");

                    b.Property<float>("Value");

                    b.Property<int>("typeCesantia");

                    b.HasKey("Id");

                    b.HasIndex("TypeCesantiasId");

                    b.ToTable("Cesantias");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitiesId");

                    b.Property<string>("nameCity");

                    b.HasKey("Id");

                    b.HasIndex("CitiesId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Request");

                    b.Property<DateTime>("Registration_date");

                    b.Property<int>("state_request");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypeLicensesId");

                    b.Property<DateTime>("finalDate");

                    b.Property<DateTime>("initialDate");

                    b.Property<int>("typeDisability");

                    b.HasKey("Id");

                    b.HasIndex("TypeLicensesId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TypeLoan");

                    b.Property<int?>("TypeLoansId");

                    b.Property<float>("ValorLoan");

                    b.HasKey("Id");

                    b.HasIndex("TypeLoansId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CesantiaId");

                    b.Property<DateTime>("Date_Register");

                    b.Property<int?>("DisabilityId");

                    b.Property<int?>("LicenseId");

                    b.Property<int?>("LoanId");

                    b.Property<int?>("TransferId");

                    b.Property<int>("clase_solicitud");

                    b.Property<int>("rep");

                    b.Property<int>("status");

                    b.HasKey("Id");

                    b.HasIndex("CesantiaId");

                    b.HasIndex("DisabilityId");

                    b.HasIndex("LicenseId");

                    b.HasIndex("LoanId");

                    b.HasIndex("TransferId");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Rep", b =>
                {
                    b.Property<int>("rep_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("activo");

                    b.Property<int>("cedula");

                    b.Property<string>("email")
                        .HasMaxLength(50);

                    b.Property<int>("empresa");

                    b.Property<string>("nombre")
                        .HasMaxLength(100);

                    b.Property<int>("tipo");

                    b.HasKey("rep_id");

                    b.ToTable("Reps");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nomnbre");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitiesId");

                    b.Property<int>("City");

                    b.HasKey("Id");

                    b.HasIndex("CitiesId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Type_Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Type_Requests");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.TypeCesantia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("TypeCesantias");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.TypeDisability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("TypeDisabilities");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.TypeLoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TypeLoans");
                });

            modelBuilder.Entity("SM2.Web.Data.TypeLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("TypeLicenses");
                });

            modelBuilder.Entity("SM2.Web.Data.Disability", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.TypeDisability", "TypeDisabilities")
                        .WithMany("Disabilities")
                        .HasForeignKey("TypeDisabilitiesId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Cesantia", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.TypeCesantia", "TypeCesantias")
                        .WithMany("Cesantias")
                        .HasForeignKey("TypeCesantiasId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.City", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.City", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.License", b =>
                {
                    b.HasOne("SM2.Web.Data.TypeLicense", "TypeLicenses")
                        .WithMany()
                        .HasForeignKey("TypeLicensesId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Loan", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.TypeLoan", "TypeLoans")
                        .WithMany("Loans")
                        .HasForeignKey("TypeLoansId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Problem", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.Cesantia")
                        .WithMany("Problems")
                        .HasForeignKey("CesantiaId");

                    b.HasOne("SM2.Web.Data.Disability")
                        .WithMany("Problems")
                        .HasForeignKey("DisabilityId");

                    b.HasOne("SM2.Web.Data.Entities.License")
                        .WithMany("Problems")
                        .HasForeignKey("LicenseId");

                    b.HasOne("SM2.Web.Data.Entities.Loan")
                        .WithMany("Problems")
                        .HasForeignKey("LoanId");

                    b.HasOne("SM2.Web.Data.Entities.Transfer")
                        .WithMany("Problems")
                        .HasForeignKey("TransferId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Transfer", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.City", "Cities")
                        .WithMany("Transfers")
                        .HasForeignKey("CitiesId");
                });
#pragma warning restore 612, 618
        }
    }
}
