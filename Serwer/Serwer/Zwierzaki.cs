namespace Serwer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zwierzaki")]
    public partial class Zwierzaki
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(5)]
        public string imie { get; set; }

        [StringLength(50)]
        public string rasa { get; set; }

        public int? wiek { get; set; }

        [StringLength(20)]
        public string kontakt { get; set; }

        [StringLength(50)]
        public string zdj { get; set; }
    }
}
