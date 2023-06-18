namespace Cinemaxx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pagamento")]
    public partial class pagamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? ingresso { get; set; }

        [StringLength(255)]
        public string nome_filme { get; set; }

        public int? filme { get; set; }

        [StringLength(50)]
        public string sala { get; set; }

        [StringLength(50)]
        public string fileira { get; set; }

        public int? metodo_pagamento { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor { get; set; }

        public virtual ingresso ingresso1 { get; set; }
    }
}
