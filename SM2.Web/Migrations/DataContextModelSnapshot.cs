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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SM2.Web.Data.Disability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RepId");

                    b.Property<int?>("TypeDisabilitiesId");

                    b.Property<DateTime>("finalDate");

                    b.Property<DateTime>("initialDate");

                    b.Property<int>("typeDisability");

                    b.HasKey("Id");

                    b.HasIndex("RepId");

                    b.HasIndex("TypeDisabilitiesId");

                    b.ToTable("Disabilities");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Cesantia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RepId");

                    b.Property<int?>("TypeCesantiasId");

                    b.Property<float>("Value");

                    b.Property<int>("typeCesantia");

                    b.HasKey("Id");

                    b.HasIndex("RepId");

                    b.HasIndex("TypeCesantiasId");

                    b.ToTable("Cesantias");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nameCity");

                    b.HasKey("Id");

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

                    b.Property<int?>("RepId");

                    b.Property<int?>("TypeLicensesId");

                    b.Property<DateTime>("finalDate");

                    b.Property<DateTime>("initialDate");

                    b.Property<int>("typeDisability");

                    b.HasKey("Id");

                    b.HasIndex("RepId");

                    b.HasIndex("TypeLicensesId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RepId");

                    b.Property<int>("TypeLoan");

                    b.Property<int?>("TypeLoansId");

                    b.Property<float>("ValorLoan");

                    b.HasKey("Id");

                    b.HasIndex("RepId");

                    b.HasIndex("TypeLoansId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Managers");
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

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Rep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.Property<int>("empresa");

                    b.Property<int>("tipo");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

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

                    b.Property<int?>("RepId");

                    b.HasKey("Id");

                    b.HasIndex("CitiesId");

                    b.HasIndex("RepId");

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

            modelBuilder.Entity("SM2.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SM2.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SM2.Web.Data.Disability", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.Rep")
                        .WithMany("Disabilities")
                        .HasForeignKey("RepId");

                    b.HasOne("SM2.Web.Data.Entities.TypeDisability", "TypeDisabilities")
                        .WithMany("Disabilities")
                        .HasForeignKey("TypeDisabilitiesId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Cesantia", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.Rep")
                        .WithMany("Cesantias")
                        .HasForeignKey("RepId");

                    b.HasOne("SM2.Web.Data.Entities.TypeCesantia", "TypeCesantias")
                        .WithMany("Cesantias")
                        .HasForeignKey("TypeCesantiasId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.License", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.Rep")
                        .WithMany("Licenses")
                        .HasForeignKey("RepId");

                    b.HasOne("SM2.Web.Data.TypeLicense", "TypeLicenses")
                        .WithMany()
                        .HasForeignKey("TypeLicensesId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Loan", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.Rep")
                        .WithMany("Loans")
                        .HasForeignKey("RepId");

                    b.HasOne("SM2.Web.Data.Entities.TypeLoan", "TypeLoans")
                        .WithMany("Loans")
                        .HasForeignKey("TypeLoansId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Manager", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
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

            modelBuilder.Entity("SM2.Web.Data.Entities.Rep", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SM2.Web.Data.Entities.Transfer", b =>
                {
                    b.HasOne("SM2.Web.Data.Entities.City", "Cities")
                        .WithMany("Transfers")
                        .HasForeignKey("CitiesId");

                    b.HasOne("SM2.Web.Data.Entities.Rep")
                        .WithMany("Transfers")
                        .HasForeignKey("RepId");
                });
#pragma warning restore 612, 618
        }
    }
}
