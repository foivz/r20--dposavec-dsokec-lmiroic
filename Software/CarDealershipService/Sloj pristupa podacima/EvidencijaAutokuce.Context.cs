﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sloj_pristupa_podacima
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarDealershipandServiceEntities : DbContext
    {
        public CarDealershipandServiceEntities()
            : base("name=CarDealershipandServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artikl> Artikls { get; set; }
        public virtual DbSet<Artikli_na_skladistu> Artikli_na_skladistu { get; set; }
        public virtual DbSet<Dnevnik_rada> Dnevnik_rada { get; set; }
        public virtual DbSet<Dokument> Dokuments { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Poslovnica> Poslovnicas { get; set; }
        public virtual DbSet<Radnja_dnevnika> Radnja_dnevnika { get; set; }
        public virtual DbSet<Skladiste> Skladistes { get; set; }
        public virtual DbSet<Skladiste_poslovnice> Skladiste_poslovnice { get; set; }
        public virtual DbSet<Stavke_dokumenta> Stavke_dokumenta { get; set; }
        public virtual DbSet<Tip_dokumenta> Tip_dokumenta { get; set; }
        public virtual DbSet<Tip_korisnika> Tip_korisnika { get; set; }
        public virtual DbSet<Usluga> Uslugas { get; set; }
        public virtual DbSet<Vrsta_usluge> Vrsta_usluge { get; set; }
        public virtual DbSet<Vrste_artikla> Vrste_artikla { get; set; }
    }
}
