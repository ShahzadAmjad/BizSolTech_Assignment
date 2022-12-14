// <auto-generated />
using BizSolTech_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BizSolTech_Assignment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220906181436_bizsoldb")]
    partial class bizsoldb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BizSolTech_Assignment.Models.Developer", b =>
                {
                    b.Property<int>("developerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("developerId"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("jobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("developerId");

                    b.ToTable("developers");
                });
#pragma warning restore 612, 618
        }
    }
}
