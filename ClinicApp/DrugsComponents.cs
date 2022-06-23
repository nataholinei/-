namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.DrugsComponents")]
    public partial class DrugsComponents
    {
        [Key]
        public int idDrugsComponents { get; set; }

        public int idDrugs { get; set; }

        public int idIngredient { get; set; }

        public virtual Drugs Drugs { get; set; }

        public virtual Ingredients Ingredients { get; set; }
    }
}
