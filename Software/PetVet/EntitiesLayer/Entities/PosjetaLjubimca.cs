namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PosjetaLjubimca")]
    public partial class PosjetaLjubimca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PosjetaLjubimca()
        {
            Lijekovis = new HashSet<Lijekovi>();
            PreboljeleBolestis = new HashSet<PreboljeleBolesti>();
        }

        public int ID { get; set; }

        public DateTime DatumPosjete { get; set; }

        [Required]
        [StringLength(100)]
        public string RazlogPosjete { get; set; }

        public int KorisnikID { get; set; }

        public int LjubimacID { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lijekovi> Lijekovis { get; set; }

        public virtual Ljubimac Ljubimac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreboljeleBolesti> PreboljeleBolestis { get; set; }
    }
}
