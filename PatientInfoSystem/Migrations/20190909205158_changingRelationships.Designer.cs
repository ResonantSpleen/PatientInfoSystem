﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientInfoSystem.Models;

namespace PatientInfoSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190909205158_changingRelationships")]
    partial class changingRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatientInfoSystem.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Comments");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zipcode");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PatientInfoSystem.Models.PatientStudy", b =>
                {
                    b.Property<int>("PatientStudyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatientId");

                    b.Property<string>("Status");

                    b.Property<int>("StudyId");

                    b.HasKey("PatientStudyId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StudyId");

                    b.ToTable("PatientStudy");
                });

            modelBuilder.Entity("PatientInfoSystem.Models.Study", b =>
                {
                    b.Property<int>("StudyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudyName");

                    b.HasKey("StudyId");

                    b.ToTable("Study");
                });

            modelBuilder.Entity("PatientInfoSystem.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatientId");

                    b.Property<int>("StudyId");

                    b.Property<DateTime>("VisitDate");

                    b.Property<int>("VisitNumber");

                    b.HasKey("VisitId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StudyId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("PatientInfoSystem.Models.PatientStudy", b =>
                {
                    b.HasOne("PatientInfoSystem.Models.Patient", "Patient")
                        .WithMany("Studies")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PatientInfoSystem.Models.Study", "Study")
                        .WithMany()
                        .HasForeignKey("StudyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PatientInfoSystem.Models.Visit", b =>
                {
                    b.HasOne("PatientInfoSystem.Models.Patient", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PatientInfoSystem.Models.Study", "Study")
                        .WithMany()
                        .HasForeignKey("StudyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
