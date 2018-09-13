﻿// <auto-generated />
using System;
using Match.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Match.Data.Database.Migrations
{
    [DbContext(typeof(MatchMainData))]
    partial class MatchMainDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Matching.Domain.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("Location");

                    b.HasKey("Id");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("Matching.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int?>("ContactInfoId");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("NickName");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Matching.Domain.Person", b =>
                {
                    b.HasOne("Matching.Domain.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
