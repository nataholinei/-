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
    public partial class SpecialAccountForm : Form
    {
        ClinicModel clinicModel;
        public SpecialAccountForm()
        {
            this.clinicModel = clinicModel;
            InitializeComponent();
            Load += specialAccountForm_Load;
        }

        private void specialAccountForm_Load(object sender, EventArgs e)
        {
            clinicModel = new ClinicModel();
            clinicModel.SpecialAccount.Load();
            specialAccountBindingSource.DataSource = clinicModel.SpecialAccount.Local.ToBindingList();
        }
    }
}
