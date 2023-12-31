﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Text.Json;
using ForecastBuildTime.SqlModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ForecastBuildTime.SqlModels.Migrations
{
    [DbContext(typeof(ForecastingContext))]
    [Migration("20211110123906_AddAttachedProperties")]
    partial class AddAttachedProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ForecastBuildTime.SqlModels.BuildEntrySlim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<IDictionary<string, object>>("AttachedProperties")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("jsonb")
                        .HasDefaultValueSql("'{}'::jsonb");

                    b.Property<string>("Branch")
                        .HasColumnType("text");

                    b.Property<string>("BuildUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("CircleYmlHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Parallel")
                        .HasColumnType("integer");

                    b.Property<bool>("SelectedSuccess")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("SumOfBuildTimeInSteps")
                        .HasColumnType("interval");

                    b.Property<string>("VcsRevision")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VcsUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Why")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BuildUrl")
                        .IsUnique();

                    b.HasIndex("VcsUrl");

                    b.HasIndex("VcsUrl", "JobName");

                    b.HasIndex("VcsUrl", "SelectedSuccess");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("ForecastBuildTime.SqlModels.CircleYml", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Sha256")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("Sha256");

                    b.ToTable("CircleYmls");
                });

            modelBuilder.Entity("ForecastBuildTime.SqlModels.PredictionEvaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Approach")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("BuildCount")
                        .HasColumnType("integer");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MMRE")
                        .HasColumnType("double precision");

                    b.Property<JsonDocument>("PredictedValues")
                        .HasColumnType("jsonb");

                    b.Property<string>("VcsUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Why")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("VcsUrl", "JobName", "Branch", "Why", "Approach")
                        .IsUnique();

                    b.ToTable("Evaluations");
                });
#pragma warning restore 612, 618
        }
    }
}
