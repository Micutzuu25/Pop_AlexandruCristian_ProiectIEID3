// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pop_AlexandruCristian_ProiectIEID3.Data;

#nullable disable

namespace Pop_AlexandruCristian_ProiectIEID3.Migrations
{
    [DbContext(typeof(Pop_AlexandruCristian_ProiectIEID3Context))]
    partial class Pop_AlexandruCristian_ProiectIEID3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Automobil", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataAparitie")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("VanzatorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VanzatorID");

                    b.ToTable("Automobil");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.AutomobilCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AutomobilID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AutomobilID");

                    b.HasIndex("CategoryID");

                    b.ToTable("AutomobilCategory");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Vanzator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NumeVanzator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Vanzator");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Automobil", b =>
                {
                    b.HasOne("Pop_AlexandruCristian_ProiectIEID3.Models.Vanzator", "Vanzator")
                        .WithMany("Automobile")
                        .HasForeignKey("VanzatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vanzator");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.AutomobilCategory", b =>
                {
                    b.HasOne("Pop_AlexandruCristian_ProiectIEID3.Models.Automobil", "Automobil")
                        .WithMany("AutomobilCategories")
                        .HasForeignKey("AutomobilID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pop_AlexandruCristian_ProiectIEID3.Models.Category", "Category")
                        .WithMany("AutomobilCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Automobil");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Automobil", b =>
                {
                    b.Navigation("AutomobilCategories");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Category", b =>
                {
                    b.Navigation("AutomobilCategories");
                });

            modelBuilder.Entity("Pop_AlexandruCristian_ProiectIEID3.Models.Vanzator", b =>
                {
                    b.Navigation("Automobile");
                });
#pragma warning restore 612, 618
        }
    }
}
