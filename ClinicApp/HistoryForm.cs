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
    public partial class HistoryForm : Form
    {
        ClinicModel clinicModel;
        public HistoryForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += HistoryForm_Load;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.History.Load();
            historyBindingSource.DataSource = clinicModel.History.Local.ToBindingList();
            clinicModel.Patients.Load();
            patientsBindingSource.DataSource = clinicModel.Patients.Local.ToBindingList();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            historyBindingSource.EndEdit();
            clinicModel.SaveChanges();
        }

        private void patientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHistory();
        }

        private void SetHistory()
        {
            historyBindingSource.DataSource = clinicModel.History.Local
                .Where(history => history.idPatient == (patientsComboBox.SelectedItem as Patients).idPatient).ToList();
        }
    }
}
