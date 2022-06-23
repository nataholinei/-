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
    public partial class SpecializationForm : Form
    {
        ClinicModel clinicModel;
        public SpecializationForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += SpecializationForm_Load;
        }

        private void SpecializationForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Specialization.Load();
            specializationBindingSource.DataSource = clinicModel.Specialization.Local.ToBindingList();
        }

        private void specializationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            specializationDataGridView.EndEdit();
            clinicModel.SaveChanges();
        }
    }
}
