namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VeterinarskaStanica")]
    public partial class VeterinarskaStanica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeterinarskaStanica()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public TimeSpan RadnoVrijeme_od { get; set; }

        public TimeSpan RadnoVrijeme_do { get; set; }

        [Required]
        [StringLength(100)]
        public string AdresaStanice { get; set; }

        public int TipStaniceID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }

        public virtual TipStanice TipStanice { get; set; }
    }
}
