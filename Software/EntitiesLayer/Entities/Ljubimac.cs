namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ljubimac")]
    public partial class Ljubimac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ljubimac()
        {
            PosjetaLjubimcas = new HashSet<PosjetaLjubimca>();
            Rasporeds = new HashSet<Raspored>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }

        public int BrojIskaznice { get; set; }

        public int BrojChipa { get; set; }

        public double Tezina_Kg { get; set; }

        public double Visina_Cm { get; set; }

        public int BrojKartona { get; set; }

        [Required]
        [StringLength(150)]
        public string Biljeske { get; set; }

        public int KorisnikID { get; set; }

        public int TipLjubimcaID { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual PasminaLjubimca PasminaLjubimca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosjetaLjubimca> PosjetaLjubimcas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Raspored> Rasporeds { get; set; }
    }
}
