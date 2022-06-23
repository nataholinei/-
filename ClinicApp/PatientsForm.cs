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
    public partial class PatientsForm : Form
    {
        ClinicModel clinicModel;
        public PatientsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += PatientsForm_Load;
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Patients.Load();
            patientsBindingSource.DataSource = clinicModel.Patients.Local.ToBindingList();
            clinicModel.Persons.Load();
            personsBindingSource.DataSource = clinicModel.Persons.Local.ToBindingList();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            patientsDataGridView.EndEdit();
            clinicModel.SaveChanges();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlParameter idPerson = new SqlParameter("@idPerson", (personsComboBox.SelectedItem as Persons).idPerson);
            SqlParameter Description = new SqlParameter("@Description", textBoxDescription.Text);
            clinicModel.Database.ExecuteSqlCommand("AddPatient @idPerson, @Description", idPerson, Description);
            patientsBindingSource.DataSource = clinicModel.Patients.AsEnumerable().ToList();
        }

        private void buttonSA_Click(object sender, EventArgs e)
        {
            SpecialAccountForm specialAccountForm = new SpecialAccountForm();
            specialAccountForm.ShowDialog();
        }
    }
}
