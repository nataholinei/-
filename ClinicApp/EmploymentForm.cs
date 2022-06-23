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
    public partial class EmploymentForm : Form
    {
        ClinicModel clinicModel;
        public EmploymentForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += EmploymentForm_Load;
        }

        private void EmploymentForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Doctors.Load();
            doctorsBindingSource.DataSource = clinicModel.Doctors.Local.ToBindingList();
            clinicModel.History.Load();
            historyBindingSource.DataSource = clinicModel.History.Local.ToBindingList();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            clinicModel.SaveChanges();
        }

        private void doctorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPatients();
        }

        private void SetPatients()
        {
            historyListBox.DataSource = clinicModel.History.Local
                .Where(history => history.idDoctor == 
                (doctorsListBox.SelectedItem as Doctors).idDoctor 
                && history.DateEnd == null).ToList();
            countTextBox.Text = historyListBox.Items.Count.ToString();
        }
    }
}
