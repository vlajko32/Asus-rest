// <auto-generated />
using System;
using Asus_rest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asus_rest.Migrations
{
    [DbContext(typeof(AsusContext))]
    [Migration("20210919141626_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asus_rest.Domain.OdgovornoLice", b =>
                {
                    b.Property<int>("SifraRadnika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrzisteSifraTrzista")
                        .HasColumnType("int");

                    b.HasKey("SifraRadnika");

                    b.HasIndex("TrzisteSifraTrzista");

                    b.ToTable("OdgovornaLica");
                });

            modelBuilder.Entity("Asus_rest.Domain.Trziste", b =>
                {
                    b.Property<int>("SifraTrzista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SifraTrzista");

                    b.ToTable("Trzista");
                });

            modelBuilder.Entity("Asus_rest.Domain.OdgovornoLice", b =>
                {
                    b.HasOne("Asus_rest.Domain.Trziste", "Trziste")
                        .WithMany()
                        .HasForeignKey("TrzisteSifraTrzista");

                    b.Navigation("Trziste");
                });
#pragma warning restore 612, 618
        }
    }
}
