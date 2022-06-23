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
    public partial class BadDrugsForm : Form
    {
        ClinicModel clinicModel;
        public BadDrugsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += BadDrugsForm_Load;
        }

        private void BadDrugsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.BadDrugs.Load();
            badDrugsBindingSource.DataSource = clinicModel.BadDrugs.Local.ToBindingList();
            clinicModel.Patients.Load();
            patientsBindingSource.DataSource = clinicModel.Patients.Local.ToBindingList();
        }

        private void badDrugsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            badDrugsDataGridView.EndEdit();
            clinicModel.SaveChanges();
        }

        private void patientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBadDrugs();
        }
        private void SetBadDrugs()
        {
            badDrugsBindingSource.DataSource = clinicModel.BadDrugs.Local
                .Where(badDrugs => badDrugs.idPatient == (patientsComboBox.SelectedItem as Patients).idPatient).ToList();
        }
    }
}
