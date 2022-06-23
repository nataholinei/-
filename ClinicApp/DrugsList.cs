namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.DrugsList")]
    public partial class DrugsList
    {
        [Key]
        public int idDrugsList { get; set; }

        public int idDiagnosis { get; set; }

        public int idDrugs { get; set; }

        public virtual Diagnoses Diagnoses { get; set; }

        public virtual Drugs Drugs { get; set; }
    }
}
