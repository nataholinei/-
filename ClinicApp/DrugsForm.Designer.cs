namespace ClinicApp
{
    partial class DrugsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diagnosesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.drugsListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.diagnosesComboBox = new System.Windows.Forms.ComboBox();
            this.drugsComponentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsComponentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.drugsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsComponentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsComponentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosesBindingSource
            // 
            this.diagnosesBindingSource.DataSource = typeof(ClinicApp.Diagnoses);
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataSource = typeof(ClinicApp.Drugs);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.splitContainer1.Panel1.Controls.Add(this.drugsListDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.diagnosesComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.splitContainer1.Panel2.Controls.Add(this.drugsComponentsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.drugsComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 529);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 2;
            // 
            // drugsListDataGridView
            // 
            this.drugsListDataGridView.AutoGenerateColumns = false;
            this.drugsListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.drugsListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drugsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.drugsListDataGridView.DataSource = this.drugsListBindingSource;
            this.drugsListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drugsListDataGridView.Location = new System.Drawing.Point(0, 138);
            this.drugsListDataGridView.Name = "drugsListDataGridView";
            this.drugsListDataGridView.RowHeadersWidth = 62;
            this.drugsListDataGridView.RowTemplate.Height = 28;
            this.drugsListDataGridView.Size = new System.Drawing.Size(505, 391);
            this.drugsListDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDrugsList";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idDiagnosis";
            this.dataGridViewTextBoxColumn2.HeaderText = "idDiagnosis";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idDrugs";
            this.dataGridViewTextBoxColumn3.HeaderText = "idDrugs";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Diagnoses";
            this.dataGridViewTextBoxColumn4.HeaderText = "Діагноз";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Drugs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Назва препарату";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 161;
            // 
            // drugsListBindingSource
            // 
            this.drugsListBindingSource.DataSource = typeof(ClinicApp.DrugsList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть діагноз";
            // 
            // diagnosesComboBox
            // 
            this.diagnosesComboBox.DataSource = this.diagnosesBindingSource;
            this.diagnosesComboBox.FormattingEnabled = true;
            this.diagnosesComboBox.Location = new System.Drawing.Point(58, 72);
            this.diagnosesComboBox.Name = "diagnosesComboBox";
            this.diagnosesComboBox.Size = new System.Drawing.Size(337, 28);
            this.diagnosesComboBox.TabIndex = 2;
            this.diagnosesComboBox.SelectedIndexChanged += new System.EventHandler(this.diagnosesComboBox_SelectedIndexChanged);
            // 
            // drugsComponentsDataGridView
            // 
            this.drugsComponentsDataGridView.AutoGenerateColumns = false;
            this.drugsComponentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.drugsComponentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drugsComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsComponentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.drugsComponentsDataGridView.DataSource = this.drugsComponentsBindingSource;
            this.drugsComponentsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drugsComponentsDataGridView.Location = new System.Drawing.Point(0, 138);
            this.drugsComponentsDataGridView.Name = "drugsComponentsDataGridView";
            this.drugsComponentsDataGridView.RowHeadersWidth = 62;
            this.drugsComponentsDataGridView.RowTemplate.Height = 28;
            this.drugsComponentsDataGridView.Size = new System.Drawing.Size(508, 391);
            this.drugsComponentsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idDrugsComponents";
            this.dataGridViewTextBoxColumn6.HeaderText = "№";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idDrugs";
            this.dataGridViewTextBoxColumn7.HeaderText = "idDrugs";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "idIngredient";
            this.dataGridViewTextBoxColumn8.HeaderText = "idIngredient";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 129;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Drugs";
            this.dataGridViewTextBoxColumn9.HeaderText = "Назва препарату";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 175;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ingredients";
            this.dataGridViewTextBoxColumn10.HeaderText = "Складова";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 121;
            // 
            // drugsComponentsBindingSource
            // 
            this.drugsComponentsBindingSource.DataSource = typeof(ClinicApp.DrugsComponents);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оберіть препарат";
            // 
            // drugsComboBox
            // 
            this.drugsComboBox.DataSource = this.drugsBindingSource;
            this.drugsComboBox.DisplayMember = "Name";
            this.drugsComboBox.FormattingEnabled = true;
            this.drugsComboBox.Location = new System.Drawing.Point(58, 72);
            this.drugsComboBox.Name = "drugsComboBox";
            this.drugsComboBox.Size = new System.Drawing.Size(337, 28);
            this.drugsComboBox.TabIndex = 1;
            this.drugsComboBox.ValueMember = "DrugsComponents";
            this.drugsComboBox.SelectedIndexChanged += new System.EventHandler(this.drugsComboBox_SelectedIndexChanged);
            // 
            // DrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 529);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "DrugsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Діагнози та ліки";
            this.Load += new System.EventHandler(this.DrugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsComponentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsComponentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diagnosesBindingSource;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox diagnosesComboBox;
        private System.Windows.Forms.ComboBox drugsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView drugsListDataGridView;
        private System.Windows.Forms.BindingSource drugsListBindingSource;
        private System.Windows.Forms.DataGridView drugsComponentsDataGridView;
        private System.Windows.Forms.BindingSource drugsComponentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}