﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newspaper.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Newspaper.Migrations
{
    [DbContext(typeof(NewspaperContext))]
    partial class NewspaperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Newspaper.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<int>("IssueId")
                        .HasColumnType("integer")
                        .HasColumnName("issue_id");

                    b.Property<int>("ReporterId")
                        .HasColumnType("integer")
                        .HasColumnName("reporter_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_articles");

                    b.HasIndex("IssueId")
                        .HasDatabaseName("ix_articles_issue_id");

                    b.HasIndex("ReporterId")
                        .HasDatabaseName("ix_articles_reporter_id");

                    b.ToTable("articles", (string)null);
                });

            modelBuilder.Entity("Newspaper.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.HasKey("Id")
                        .HasName("pk_issues");

                    b.ToTable("issues", (string)null);
                });

            modelBuilder.Entity("Newspaper.Models.Reporter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("speciality");

                    b.HasKey("Id")
                        .HasName("pk_reporters");

                    b.ToTable("reporters", (string)null);
                });

            modelBuilder.Entity("Newspaper.Models.Article", b =>
                {
                    b.HasOne("Newspaper.Models.Issue", "Issue")
                        .WithMany("Articles")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_articles_issues_issue_id");

                    b.HasOne("Newspaper.Models.Reporter", "Reporter")
                        .WithMany("Articles")
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_articles_reporters_reporter_id");

                    b.Navigation("Issue");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("Newspaper.Models.Issue", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Newspaper.Models.Reporter", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
