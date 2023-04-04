namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Raspored")]
    public partial class Raspored
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Datum { get; set; }

        public TimeSpan Pocetak { get; set; }

        public TimeSpan Zavrsetak { get; set; }

        [Required]
        [StringLength(100)]
        public string OpisZauzetosti { get; set; }

        public int KorisnikID { get; set; }

        public int LjubimacID { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Ljubimac Ljubimac { get; set; }
    }
}
