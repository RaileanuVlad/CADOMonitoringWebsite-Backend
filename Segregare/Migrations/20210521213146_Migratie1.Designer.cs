﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Segregare.Contexts;

namespace Segregare.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210521213146_Migratie1")]
    partial class Migratie1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Segregare.Models.Cladire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume");

                    b.Property<int>("UnitateId");

                    b.HasKey("Id");

                    b.HasIndex("UnitateId");

                    b.ToTable("Cladiri");
                });

            modelBuilder.Entity("Segregare.Models.CladireIntrebare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CladireId");

                    b.Property<string>("Data");

                    b.Property<int>("IntrebareId");

                    b.Property<string>("Raspuns");

                    b.HasKey("Id");

                    b.HasIndex("CladireId");

                    b.HasIndex("IntrebareId");

                    b.ToTable("CladireIntrebari");
                });

            modelBuilder.Entity("Segregare.Models.Intrebare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pentru");

                    b.Property<string>("Text");

                    b.Property<string>("Tip");

                    b.HasKey("Id");

                    b.ToTable("Intrebari");
                });

            modelBuilder.Entity("Segregare.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Parola");

                    b.HasKey("Id");

                    b.ToTable("Monitori");
                });

            modelBuilder.Entity("Segregare.Models.MonitorIntrebare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data");

                    b.Property<int>("IntrebareId");

                    b.Property<int>("MonitorId");

                    b.Property<string>("Raspuns");

                    b.HasKey("Id");

                    b.HasIndex("IntrebareId");

                    b.HasIndex("MonitorId");

                    b.ToTable("MonitorIntrebari");
                });

            modelBuilder.Entity("Segregare.Models.Scoala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Judet");

                    b.Property<string>("Mediu");

                    b.Property<string>("Nume");

                    b.Property<string>("Parola");

                    b.HasKey("Id");

                    b.ToTable("Scoli");
                });

            modelBuilder.Entity("Segregare.Models.Unitate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal");

                    b.Property<string>("Fax");

                    b.Property<string>("Localitate");

                    b.Property<string>("Nivel");

                    b.Property<string>("NrStrada");

                    b.Property<string>("Nume");

                    b.Property<int>("ScoalaId");

                    b.Property<string>("Statut");

                    b.Property<string>("Strada");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.HasIndex("ScoalaId");

                    b.ToTable("Unitati");
                });

            modelBuilder.Entity("Segregare.Models.Cladire", b =>
                {
                    b.HasOne("Segregare.Models.Unitate", "Unitate")
                        .WithMany("Cladire")
                        .HasForeignKey("UnitateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Segregare.Models.CladireIntrebare", b =>
                {
                    b.HasOne("Segregare.Models.Cladire", "Cladire")
                        .WithMany("CladireIntrebare")
                        .HasForeignKey("CladireId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Segregare.Models.Intrebare", "Intrebare")
                        .WithMany("CladireIntrebare")
                        .HasForeignKey("IntrebareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Segregare.Models.MonitorIntrebare", b =>
                {
                    b.HasOne("Segregare.Models.Intrebare", "Intrebare")
                        .WithMany("MonitorIntrebare")
                        .HasForeignKey("IntrebareId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Segregare.Models.Monitor", "Monitor")
                        .WithMany("MonitorIntrebare")
                        .HasForeignKey("MonitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Segregare.Models.Unitate", b =>
                {
                    b.HasOne("Segregare.Models.Scoala", "Scoala")
                        .WithMany("Unitate")
                        .HasForeignKey("ScoalaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
