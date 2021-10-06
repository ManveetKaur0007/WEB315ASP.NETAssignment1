// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NaturalEnvironment.Migrations
{
    [DbContext(typeof(NaturalEnvironmentEnvironmentsContext))]
    partial class NaturalEnvironmentEnvironmentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("NaturalEnvironment.Models.Environments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Pollutionrate")
                        .HasColumnType("DECIMAL");

                    b.Property<string>("Currentstatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Effectonpeople")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Environments");
                });
#pragma warning restore 612, 618
        }
    }
}