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
    public partial class DrugsForm : Form
    {
        ClinicModel clinicModel;
        public DrugsForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += DrugsForm_Load;
        }

        private void DrugsForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.Diagnoses.Load();
            diagnosesBindingSource.DataSource = clinicModel.Diagnoses.Local.ToBindingList();
            clinicModel.Drugs.Load();
            drugsBindingSource.DataSource = clinicModel.Drugs.Local.ToBindingList();
            clinicModel.DrugsList.Load();
            drugsListBindingSource.DataSource = clinicModel.DrugsList.Local.ToBindingList();
            clinicModel.DrugsComponents.Load();
            drugsComponentsBindingSource.DataSource = clinicModel.DrugsComponents.Local.ToBindingList();
        }

        private void diagnosesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDrugs();
        }

        private void drugsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIngredients();
        }
        private void SetDrugs()
        {
            drugsListBindingSource.DataSource = clinicModel.DrugsList.Local
                .Where(drugs => drugs.idDiagnosis == (diagnosesComboBox.SelectedItem as Diagnoses).idDiagnosis).ToList();
        }
        private void SetIngredients()
        {
            drugsComponentsBindingSource.DataSource = clinicModel.DrugsComponents.Local
                .Where(ingredients => ingredients.idDrugs == (drugsComboBox.SelectedItem as Drugs).idDrugs).ToList();
        }
    }
}
