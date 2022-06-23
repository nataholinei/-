namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.SpecialAccount")]
    public partial class SpecialAccount
    {
        [Key]
        public int idSpecialAccount { get; set; }

        public int idPatient { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
