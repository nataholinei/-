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
    public partial class PersonsForm : Form
    {
        ClinicModel clinicModel;
        public PersonsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += PersonsForm_Load;
        }
        
        private void PersonsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Persons.Load();
            personsBindingSource.DataSource = clinicModel.Persons.Local.ToBindingList();
        }


        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            personsDataGridView.EndEdit();
            clinicModel.SaveChanges();
        }
    }
}
