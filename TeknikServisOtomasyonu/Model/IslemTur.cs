namespace TeknikServisOtomasyonu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IslemTur")]
    public partial class IslemTur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IslemTur()
        {
            Islem = new HashSet<Islem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int islemTurID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Islem> Islem { get; set; }
    }
}
