﻿// <auto-generated />
using System;
using Match.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Match.Data.Database.Migrations
{
    [DbContext(typeof(MatchMainData))]
    [Migration("20180914091432_q")]
    partial class q
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Matching.Domain.Complexion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyType");

                    b.Property<int>("HairColor");

                    b.Property<int?>("PersonId");

                    b.Property<int>("SkinColor");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Complexion");
                });

            modelBuilder.Entity("Matching.Domain.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("Location");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("Matching.Domain.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EducationType");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Matching.Domain.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HaveAnimal");

                    b.Property<bool>("HaveChildren");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Family");
                });

            modelBuilder.Entity("Matching.Domain.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenderType");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("Matching.Domain.Interests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonInterest");

                    b.HasKey("Id");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Matching.Domain.InterestsPerson", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("InterestsId");

                    b.HasKey("PersonId", "InterestsId");

                    b.HasIndex("InterestsId");

                    b.ToTable("InterestsPerson");
                });

            modelBuilder.Entity("Matching.Domain.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId");

                    b.Property<int>("occupation");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Occupation");
                });

            modelBuilder.Entity("Matching.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("NickName");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Matching.Domain.Personality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PeronalityTraits");

                    b.HasKey("Id");

                    b.ToTable("Personality");
                });

            modelBuilder.Entity("Matching.Domain.PersonPersonality", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("PersonalityId");

                    b.HasKey("PersonId", "PersonalityId");

                    b.HasIndex("PersonalityId");

                    b.ToTable("PersonPersonality");
                });

            modelBuilder.Entity("Matching.Domain.Complexion", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("Complexions")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Matching.Domain.ContactInfo", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithOne("ContactInfo")
                        .HasForeignKey("Matching.Domain.ContactInfo", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matching.Domain.Education", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("Educations")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Matching.Domain.Family", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("Family")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Matching.Domain.Gender", b =>
                {
                    b.HasOne("Matching.Domain.Person")
                        .WithMany("IntrestedInGenders")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Matching.Domain.InterestsPerson", b =>
                {
                    b.HasOne("Matching.Domain.Interests", "Interests")
                        .WithMany("InterestsPerson")
                        .HasForeignKey("InterestsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("InterestsPerson")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matching.Domain.Occupation", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("Occupations")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Matching.Domain.PersonPersonality", b =>
                {
                    b.HasOne("Matching.Domain.Person", "Person")
                        .WithMany("PersonPersonalities")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matching.Domain.Personality", "Personality")
                        .WithMany("PersonPersonalities")
                        .HasForeignKey("PersonalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
