namespace ClinicApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic.Doctors")]
    public partial class Doctors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctors()
        {
            History = new HashSet<History>();
        }

        [Key]
        public int idDoctor { get; set; }

        public int idPerson { get; set; }

        public int idSpecialization { get; set; }

        public virtual Persons Persons { get; set; }

        public virtual Specialization Specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }
        public override string ToString() => Persons.LastName + ' ' + Persons.FirstName + ' ' + Persons.MiddleName;
    }
}
