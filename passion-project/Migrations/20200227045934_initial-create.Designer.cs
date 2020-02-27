﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using passion_project.Model;

namespace passion_project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200227045934_initial-create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("appointment_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppointmentDate")
                        .HasColumnName("appointment_date")
                        .HasColumnType("date");

                    b.Property<string>("AppointmentSummery")
                        .HasColumnName("appointment_summery")
                        .HasColumnType("text");

                    b.Property<TimeSpan?>("AppointmentTime")
                        .HasColumnName("appointment_time");

                    b.Property<int?>("DoctorPatientId")
                        .HasColumnName("doctor_patient_id");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorPatientId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetRoleClaims", b =>
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

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserClaims", b =>
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

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("doctor_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnName("biography")
                        .HasColumnType("text");

                    b.Property<string>("DoctorEmailAddress")
                        .HasColumnName("doctor_email_address")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DoctorFirstName")
                        .HasColumnName("doctor_first_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DoctorImageUrl")
                        .HasColumnName("doctor_image_url")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("DoctorLastName")
                        .HasColumnName("doctor_last_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DoctorPhoneNumber")
                        .HasColumnName("doctor_phone_number")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int?>("RoomNumber")
                        .HasColumnName("room_number");

                    b.Property<string>("Speciality")
                        .HasColumnName("speciality")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("DoctorId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("doctor_patient_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnName("doctor_id");

                    b.Property<int?>("PatientId")
                        .HasColumnName("patient_id");

                    b.HasKey("DoctorPatientId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatient");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("patient_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientAddress")
                        .HasColumnName("patient_address")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("PatientBirthDate")
                        .HasColumnName("patient_birth_date")
                        .HasColumnType("date");

                    b.Property<string>("PatientCity")
                        .HasColumnName("patient_city")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("PatientEmailAddress")
                        .HasColumnName("patient_email_address")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PatientFirstName")
                        .HasColumnName("patient_first_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PatientGender")
                        .HasColumnName("patient_gender")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("PatientHistory")
                        .HasColumnName("patient_history")
                        .HasColumnType("text");

                    b.Property<string>("PatientImageUrl")
                        .HasColumnName("patient_image_url")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("PatientLastName")
                        .HasColumnName("patient_last_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PatientPhoneNumber")
                        .HasColumnName("patient_phone_number")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("PatientPostalCode")
                        .HasColumnName("patient_postal_code")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int?>("Phn")
                        .HasColumnName("phn");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("passion_project.ViewModel.DoctorIndexVM", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography");

                    b.Property<string>("DoctorEmailAddress");

                    b.Property<string>("DoctorFirstName")
                        .IsRequired();

                    b.Property<string>("DoctorLastName")
                        .IsRequired();

                    b.Property<string>("DoctorPhoneNumber")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("RoomNumber")
                        .IsRequired();

                    b.Property<string>("Speciality");

                    b.HasKey("DoctorId");

                    b.ToTable("DoctorIndexVM");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.Appointment", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.DoctorPatient", "DoctorPatient")
                        .WithMany("Appointment")
                        .HasForeignKey("DoctorPatientId")
                        .HasConstraintName("FK__Appointme__docto__2C3393D0");
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetRoleClaims", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserClaims", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserLogins", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserRoles", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.AspNetUserTokens", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("passion_project.Models.AppointmentSystem.DoctorPatient", b =>
                {
                    b.HasOne("passion_project.Models.AppointmentSystem.Doctor", "Doctor")
                        .WithMany("DoctorPatient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__DoctorPat__docto__286302EC");

                    b.HasOne("passion_project.Models.AppointmentSystem.Patient", "Patient")
                        .WithMany("DoctorPatient")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK__DoctorPat__patie__29572725");
                });
#pragma warning restore 612, 618
        }
    }
}
