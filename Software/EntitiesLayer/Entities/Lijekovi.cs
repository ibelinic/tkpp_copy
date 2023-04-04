namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Lijekovi")]
    public partial class Lijekovi
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(100)]
        public string Opis { get; set; }

        public int PosjetaLjubimcaID { get; set; }

        public virtual PosjetaLjubimca PosjetaLjubimca { get; set; }
    }
}
