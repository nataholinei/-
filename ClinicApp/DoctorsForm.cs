using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ClinicApp
{
    public partial class DoctorsForm : Form
    {
        ClinicModel clinicModel;
        public DoctorsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += DoctorsForm_Load;
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Doctors.Load();
            doctorsBindingSource.DataSource = clinicModel.Doctors.Local.ToBindingList();
            clinicModel.Persons.Load();
            personsBindingSource.DataSource = clinicModel.Persons.Local.ToBindingList();
            clinicModel.Specialization.Load();
            specializationBindingSource.DataSource = clinicModel.Specialization.Local.ToBindingList();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            doctorsDataGridView.EndEdit();
            clinicModel.SaveChanges();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlParameter idPerson = new SqlParameter("@idPerson", (personsComboBox.SelectedItem as Persons).idPerson);
            SqlParameter idSpecialization = new SqlParameter("@idSpecialization", (specializationComboBox.SelectedItem as Specialization).idSpecialization);
            clinicModel.Database.ExecuteSqlCommand("AddDoctor @idPerson, @idSpecialization", idPerson, idSpecialization);
            doctorsBindingSource.DataSource = clinicModel.Doctors.AsEnumerable().ToList();
        }
    }
}
