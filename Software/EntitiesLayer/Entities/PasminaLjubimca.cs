namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PasminaLjubimca")]
    public partial class PasminaLjubimca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PasminaLjubimca()
        {
            Ljubimacs = new HashSet<Ljubimac>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public int KategorijaLjubimcaID { get; set; }

        public virtual KategorijaLjubimca KategorijaLjubimca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ljubimac> Ljubimacs { get; set; }
    }
}
