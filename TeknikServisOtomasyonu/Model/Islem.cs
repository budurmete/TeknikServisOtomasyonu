namespace TeknikServisOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Islem")]
    public partial class Islem
    {
        public int islemID { get; set; }

        public int? kayitID { get; set; }

        public int? islemTurID { get; set; }

        public int? personelID { get; set; }

        public string aciklama { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? islemTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public virtual IslemTur IslemTur { get; set; }

        public virtual Kayit Kayit { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
