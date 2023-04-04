namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            Ljubimacs = new HashSet<Ljubimac>();
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

        [Required]
        [StringLength(100)]
        public string Adresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string BrojMobitela { get; set; }

        [Required]
        [StringLength(30)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(50)]
        public string Lozinka { get; set; }

        public int TipKorisnikaID { get; set; }

        public int? VeterinarskaStanicaID { get; set; }

        public virtual TipKorisnika TipKorisnika { get; set; }

        public virtual VeterinarskaStanica VeterinarskaStanica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ljubimac> Ljubimacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosjetaLjubimca> PosjetaLjubimcas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Raspored> Rasporeds { get; set; }
    }
}
