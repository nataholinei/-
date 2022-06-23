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

namespace ClinicApp
{
    public partial class PatientsForDoctorsForm : Form
    {
        ClinicModel clinicModel;
        public PatientsForDoctorsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += PatientsForDoctorsForm_Load;
        }

        private void PatientsForDoctorsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.History.Load();
            historyBindingSource.DataSource = clinicModel.History.Local.ToBindingList();
            clinicModel.Doctors.Load();
            doctorsBindingSource.DataSource = clinicModel.Doctors.Local.ToBindingList();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            historyBindingSource.EndEdit();
            clinicModel.SaveChanges();
        }

        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHistory();
        }
        private void SetHistory()
        {
            historyBindingSource.DataSource = clinicModel.History.Local
                .Where(history => history.idDoctor == (doctorsComboBox.SelectedItem as Doctors).idDoctor).ToList();
        }
    }
}
