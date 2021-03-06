﻿using ITShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Data
{
    public class OOADContext : DbContext
    {
        public OOADContext(DbContextOptions<OOADContext> options): base(options)
        {
        }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Kupovina> Kupovina { get; set; }
        public DbSet<Slusalice> Slusalice { get; set; }
        public DbSet<Disk> Disk { get; set; }
        public DbSet<HardDisk> HDisk { get; set; }
        public DbSet<SSD> SDisk { get; set; }
        public DbSet<Tastatura> Tastatura { get; set; }
        public DbSet<Kuciste> Kuciste { get; set; }
        public DbSet<GrafickaKartica> GrafickaKartica { get; set; }
        public DbSet<ZvucnaKartica> ZvucnaKartica { get; set; }
        public DbSet<Memorija> Memorija { get; set; }
        public DbSet<Monitor> Monitor { get; set; }
        public DbSet<Mis> Mis { get; set; }
        public DbSet<Procesor> Procesor { get; set; }
        public DbSet<KupovinaProizvoda> KupovinaProizvod { get; set; }
        public DbSet<NacinPlacanjaKlasa> NacinPlacanja { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Korisnik>().ToTable("Korisnik");
            builder.Entity<Kupovina>().ToTable("Kupovina");
            builder.Entity<Proizvod>().ToTable("Proizvod");
            //Ovo oznacava da pravimo primary key koji je kombinacija dvije kolone
            builder.Entity<KupovinaProizvoda>().HasKey(c => new { c.ProizvodId, c.KupovinaId });

            builder.Entity<KupovinaProizvoda>().ToTable("Kupovina_Proizvod");
            builder.Entity<NacinPlacanjaKlasa>().ToTable("Nacin_Placanja");

        }

        public DbSet<ITShop.Models.MaticnaPloca> MaticnaPloca { get; set; }

        public DbSet<ITShop.Models.Korpa> Korpa { get; set; }

        public DbSet<ITShop.Models.Racunar> Racunar { get; set; }
    }
}
