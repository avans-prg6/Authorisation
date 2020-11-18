﻿// <auto-generated />
using Authorisation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Authorisation.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20201118104843_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Authorisation.Model.Geheim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Inhoud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Geheimen");
                });
#pragma warning restore 612, 618
        }
    }
}
