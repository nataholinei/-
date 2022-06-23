namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.BadDrugs")]
    public partial class BadDrugs
    {
        [Key]
        public int idBadDrugs { get; set; }

        public int idPatient { get; set; }

        public int idIngredient { get; set; }

        public virtual Ingredients Ingredients { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
