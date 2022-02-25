using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TeknikServisOtomasyonu.Model
{
    public partial class TeknikServisContext : DbContext
    {
        public TeknikServisContext()
            : base("name=TeknikServisContext1")
        {
        }

        public virtual DbSet<Islem> Islem { get; set; }
        public virtual DbSet<IslemTur> IslemTur { get; set; }
        public virtual DbSet<Kayit> Kayit { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Islem>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IslemTur>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kayit>()
                .Property(e => e.tutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Marka>()
                .Property(e => e.ad)
                .IsFixedLength();
        }
    }
}
