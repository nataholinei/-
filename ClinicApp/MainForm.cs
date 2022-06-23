using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class MainForm : Form
    {
        ClinicModel clinicModel;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonsForm personsForm = new PersonsForm();
            personsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpecializationForm specializationForm = new SpecializationForm();
            specializationForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DrugsForm drugsForm = new DrugsForm();
            drugsForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BadDrugsForm badDrugsForm = new BadDrugsForm();
            badDrugsForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientsForDoctorsForm patientsForDoctorsForm = new PatientsForDoctorsForm();
            patientsForDoctorsForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmploymentForm employmentForm = new EmploymentForm();
            employmentForm.ShowDialog();
        }
    }
}
