namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.History")]
    public partial class History
    {
        [Key]
        public int idHisrory { get; set; }

        public int idPatient { get; set; }

        public int idDiagnosis { get; set; }

        public int idDoctor { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateEnd { get; set; }

        public int? Rating { get; set; }

        public virtual Diagnoses Diagnoses { get; set; }

        public virtual Doctors Doctors { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
