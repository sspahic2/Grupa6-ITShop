﻿// <auto-generated />
using System;
using ITShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITShop.Migrations
{
    [DbContext(typeof(OOADContext))]
    [Migration("20200606175853_Validacija")]
    partial class Validacija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITShop.Data.Mis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DodatneTipke")
                        .HasColumnType("int");

                    b.Property<int>("DuzinaKabla")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("VrstaPrikljucka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Mis");
                });

            modelBuilder.Entity("ITShop.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UposlenikId")
                        .HasColumnType("int");

                    b.HasKey("AdministratorId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("ITShop.Models.Disk", b =>
                {
                    b.Property<int>("DiskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Brzina")
                        .HasColumnType("int");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("DiskId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Disk");
                });

            modelBuilder.Entity("ITShop.Models.GrafickaKartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojVentilatora")
                        .HasColumnType("int");

                    b.Property<int>("KolicinaMemorije")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Graficka_Kartica");
                });

            modelBuilder.Entity("ITShop.Models.HardDisk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiskId");

                    b.ToTable("HardDisk");
                });

            modelBuilder.Entity("ITShop.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("ITShop.Models.Kuciste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojPortova")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<double>("Zapremina")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Kuciste");
                });

            modelBuilder.Entity("ITShop.Models.Kupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("ITShop.Models.Kupovina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumTransakcije")
                        .HasColumnType("datetime2");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<int?>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("TipPlacanjaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("TipPlacanjaId");

                    b.ToTable("Kupovina");
                });

            modelBuilder.Entity("ITShop.Models.KupovinaProizvoda", b =>
                {
                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<int>("KupovinaId")
                        .HasColumnType("int");

                    b.HasKey("ProizvodId", "KupovinaId");

                    b.HasIndex("KupovinaId");

                    b.ToTable("KupovinaProizvod");
                });

            modelBuilder.Entity("ITShop.Models.MaticnaPloca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojRAMSlotova")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("SocketProcesora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Maticna_Ploca");
                });

            modelBuilder.Entity("ITShop.Models.Memorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Memorija");
                });

            modelBuilder.Entity("ITShop.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojHDMI")
                        .HasColumnType("int");

                    b.Property<int>("BrojVGA")
                        .HasColumnType("int");

                    b.Property<double>("Dijagonala")
                        .HasColumnType("float");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("Rezolucija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Monitor");
                });

            modelBuilder.Entity("ITShop.Models.NacinPlacanjaKlasa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nacin_Placanja");
                });

            modelBuilder.Entity("ITShop.Models.Procesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojJezgra")
                        .HasColumnType("int");

                    b.Property<int>("BrzinaJezgra")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Procesor");
                });

            modelBuilder.Entity("ITShop.Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proizvodjac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("ITShop.Models.SSD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiskId")
                        .HasColumnType("int");

                    b.Property<double>("Velicina")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiskId");

                    b.ToTable("SSD");
                });

            modelBuilder.Entity("ITShop.Models.Slusalice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ImaLiMikrofon")
                        .HasColumnType("bit");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("VrstaPrikljucka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Slusalice");
                });

            modelBuilder.Entity("ITShop.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIstekaLicence")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KupacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ITShop.Models.Tastatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("VrstaPrikljucka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Tastatura");
                });

            modelBuilder.Entity("ITShop.Models.Uposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumZaposljenja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Uposlenik");
                });

            modelBuilder.Entity("ITShop.Models.ZvucnaKartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Zvucna_Kartica");
                });

            modelBuilder.Entity("ITShop.Data.Mis", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Administrator", b =>
                {
                    b.HasOne("ITShop.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikId");
                });

            modelBuilder.Entity("ITShop.Models.Disk", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.GrafickaKartica", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.HardDisk", b =>
                {
                    b.HasOne("ITShop.Models.Disk", "Disk")
                        .WithMany()
                        .HasForeignKey("DiskId");
                });

            modelBuilder.Entity("ITShop.Models.Kuciste", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Kupac", b =>
                {
                    b.HasOne("ITShop.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");
                });

            modelBuilder.Entity("ITShop.Models.Kupovina", b =>
                {
                    b.HasOne("ITShop.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId");

                    b.HasOne("ITShop.Models.NacinPlacanjaKlasa", "TipPlacanja")
                        .WithMany()
                        .HasForeignKey("TipPlacanjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITShop.Models.KupovinaProizvoda", b =>
                {
                    b.HasOne("ITShop.Models.Kupovina", "Kupovina")
                        .WithMany()
                        .HasForeignKey("KupovinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITShop.Models.MaticnaPloca", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Memorija", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Monitor", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Procesor", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.SSD", b =>
                {
                    b.HasOne("ITShop.Models.Disk", "Disk")
                        .WithMany()
                        .HasForeignKey("DiskId");
                });

            modelBuilder.Entity("ITShop.Models.Slusalice", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Student", b =>
                {
                    b.HasOne("ITShop.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId");
                });

            modelBuilder.Entity("ITShop.Models.Tastatura", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });

            modelBuilder.Entity("ITShop.Models.Uposlenik", b =>
                {
                    b.HasOne("ITShop.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");
                });

            modelBuilder.Entity("ITShop.Models.ZvucnaKartica", b =>
                {
                    b.HasOne("ITShop.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");
                });
#pragma warning restore 612, 618
        }
    }
}
