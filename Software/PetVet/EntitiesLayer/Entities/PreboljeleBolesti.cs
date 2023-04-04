namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PreboljeleBolesti")]
    public partial class PreboljeleBolesti
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(150)]
        public string Opis { get; set; }

        [Column(TypeName = "date")]
        public DateTime DatumBolesti { get; set; }

        public int PosjetaLjubimcaID { get; set; }

        public virtual PosjetaLjubimca PosjetaLjubimca { get; set; }
    }
}
