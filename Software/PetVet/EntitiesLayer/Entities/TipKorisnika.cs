namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipKorisnika")]
    public partial class TipKorisnika
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipKorisnika()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
