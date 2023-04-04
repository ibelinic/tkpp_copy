namespace EntitiesLayer
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KategorijaLjubimca")]
    public partial class KategorijaLjubimca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KategorijaLjubimca()
        {
            PasminaLjubimcas = new HashSet<PasminaLjubimca>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PasminaLjubimca> PasminaLjubimcas { get; set; }
    }
}
