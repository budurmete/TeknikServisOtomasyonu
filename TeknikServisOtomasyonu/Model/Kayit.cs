namespace TeknikServisOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kayit")]
    public partial class Kayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kayit()
        {
            Islem = new HashSet<Islem>();
        }

        public int kayitID { get; set; }

        public int? musteriID { get; set; }

        public int? personelID { get; set; }

        public int? markaID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(500)]
        public string problem { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? alisTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? teslimTarihi { get; set; }

        public bool? garantiliMi { get; set; }

        [Column(TypeName = "money")]
        public decimal? tutar { get; set; }

        [StringLength(500)]
        public string aciklama { get; set; }

        [StringLength(50)]
        public string durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Islem> Islem { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
