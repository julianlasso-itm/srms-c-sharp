﻿// <auto-generated />
using System;
using Analytics.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Analytics.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Analytics.Infrastructure.Persistence.Models.LevelModel", b =>
                {
                    b.Property<Guid>("LevelId")
                        .HasColumnType("uuid")
                        .HasColumnName("rol_level_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("rol_description");

                    b.Property<bool>("Disabled")
                        .HasColumnType("boolean")
                        .HasColumnName("rol_disabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("rol_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("LevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("level");

                    b.HasData(
                        new
                        {
                            LevelId = new Guid("8075a7cb-c688-4c57-b205-0fda99f33c3f"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6478),
                            Disabled = false,
                            Name = "Backend"
                        },
                        new
                        {
                            LevelId = new Guid("322c1b97-4284-4f69-8602-e394f0696ae3"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6490),
                            Disabled = false,
                            Name = "Frontend"
                        },
                        new
                        {
                            LevelId = new Guid("10518b06-1c9a-4318-bec3-20b689f6bc07"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6494),
                            Disabled = false,
                            Name = "Fullstack"
                        },
                        new
                        {
                            LevelId = new Guid("4b378c3b-3823-45e1-a934-50475db28cd3"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6498),
                            Disabled = false,
                            Name = "DevOps"
                        },
                        new
                        {
                            LevelId = new Guid("a0a0ce05-e9ec-47d5-ad94-a6bb2de97f7f"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6501),
                            Disabled = false,
                            Name = "QA"
                        },
                        new
                        {
                            LevelId = new Guid("d139f1cf-259e-4658-9dce-a7dcf2e34197"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6507),
                            Disabled = false,
                            Name = "UX/UI"
                        },
                        new
                        {
                            LevelId = new Guid("20d03185-6852-4e04-b474-33cbb57c5d30"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6511),
                            Disabled = false,
                            Name = "DataScience"
                        },
                        new
                        {
                            LevelId = new Guid("50aaafd2-4bee-4453-8913-0336d29306f8"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6515),
                            Disabled = false,
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            LevelId = new Guid("158dab97-0b37-4b2e-909f-e801cbfe38ab"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6519),
                            Disabled = false,
                            Name = "Product"
                        },
                        new
                        {
                            LevelId = new Guid("a663fff2-a93a-4f08-95c4-1fd113b29043"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6523),
                            Disabled = false,
                            Name = "Project"
                        },
                        new
                        {
                            LevelId = new Guid("232ca6c8-e24d-4872-bad3-7e88d5cdd7f0"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6527),
                            Disabled = false,
                            Name = "Management"
                        },
                        new
                        {
                            LevelId = new Guid("d7ffddf0-1fa6-49ca-b110-131f274471cb"),
                            CreatedAt = new DateTime(2024, 6, 8, 10, 15, 8, 359, DateTimeKind.Utc).AddTicks(6530),
                            Disabled = false,
                            Name = "Other"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
