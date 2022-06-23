namespace ClinicApp
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.patientsComboBox = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.idHisroryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingNavigator)).BeginInit();
            this.historyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.splitContainer1.Panel1.Controls.Add(this.patientsComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.historyDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 529);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.DataSource = this.patientsBindingSource;
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(58, 107);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(337, 28);
            this.patientsComboBox.TabIndex = 7;
            this.patientsComboBox.SelectedIndexChanged += new System.EventHandler(this.patientsComboBox_SelectedIndexChanged);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(ClinicApp.Patients);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть пацієнта";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.historyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHisroryDataGridViewTextBoxColumn,
            this.patientsDataGridViewTextBoxColumn,
            this.diagnosesDataGridViewTextBoxColumn,
            this.doctorsDataGridViewTextBoxColumn,
            this.idPatientDataGridViewTextBoxColumn,
            this.idDiagnosisDataGridViewTextBoxColumn,
            this.idDoctorDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.RowHeadersWidth = 62;
            this.historyDataGridView.RowTemplate.Height = 28;
            this.historyDataGridView.Size = new System.Drawing.Size(1017, 353);
            this.historyDataGridView.TabIndex = 0;
            // 
            // idHisroryDataGridViewTextBoxColumn
            // 
            this.idHisroryDataGridViewTextBoxColumn.DataPropertyName = "idHisrory";
            this.idHisroryDataGridViewTextBoxColumn.HeaderText = "№";
            this.idHisroryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idHisroryDataGridViewTextBoxColumn.Name = "idHisroryDataGridViewTextBoxColumn";
            this.idHisroryDataGridViewTextBoxColumn.Width = 60;
            // 
            // patientsDataGridViewTextBoxColumn
            // 
            this.patientsDataGridViewTextBoxColumn.DataPropertyName = "Patients";
            this.patientsDataGridViewTextBoxColumn.HeaderText = "Пацієнт";
            this.patientsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patientsDataGridViewTextBoxColumn.Name = "patientsDataGridViewTextBoxColumn";
            this.patientsDataGridViewTextBoxColumn.Visible = false;
            this.patientsDataGridViewTextBoxColumn.Width = 105;
            // 
            // diagnosesDataGridViewTextBoxColumn
            // 
            this.diagnosesDataGridViewTextBoxColumn.DataPropertyName = "Diagnoses";
            this.diagnosesDataGridViewTextBoxColumn.HeaderText = "Діагноз";
            this.diagnosesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diagnosesDataGridViewTextBoxColumn.Name = "diagnosesDataGridViewTextBoxColumn";
            this.diagnosesDataGridViewTextBoxColumn.Width = 102;
            // 
            // doctorsDataGridViewTextBoxColumn
            // 
            this.doctorsDataGridViewTextBoxColumn.DataPropertyName = "Doctors";
            this.doctorsDataGridViewTextBoxColumn.HeaderText = "Лікар";
            this.doctorsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.doctorsDataGridViewTextBoxColumn.Name = "doctorsDataGridViewTextBoxColumn";
            this.doctorsDataGridViewTextBoxColumn.Width = 86;
            // 
            // idPatientDataGridViewTextBoxColumn
            // 
            this.idPatientDataGridViewTextBoxColumn.DataPropertyName = "idPatient";
            this.idPatientDataGridViewTextBoxColumn.HeaderText = "idPatient";
            this.idPatientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPatientDataGridViewTextBoxColumn.Name = "idPatientDataGridViewTextBoxColumn";
            this.idPatientDataGridViewTextBoxColumn.Visible = false;
            this.idPatientDataGridViewTextBoxColumn.Width = 107;
            // 
            // idDiagnosisDataGridViewTextBoxColumn
            // 
            this.idDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "idDiagnosis";
            this.idDiagnosisDataGridViewTextBoxColumn.HeaderText = "idDiagnosis";
            this.idDiagnosisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDiagnosisDataGridViewTextBoxColumn.Name = "idDiagnosisDataGridViewTextBoxColumn";
            this.idDiagnosisDataGridViewTextBoxColumn.Visible = false;
            this.idDiagnosisDataGridViewTextBoxColumn.Width = 127;
            // 
            // idDoctorDataGridViewTextBoxColumn
            // 
            this.idDoctorDataGridViewTextBoxColumn.DataPropertyName = "idDoctor";
            this.idDoctorDataGridViewTextBoxColumn.HeaderText = "idDoctor";
            this.idDoctorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDoctorDataGridViewTextBoxColumn.Name = "idDoctorDataGridViewTextBoxColumn";
            this.idDoctorDataGridViewTextBoxColumn.Visible = false;
            this.idDoctorDataGridViewTextBoxColumn.Width = 105;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "Дата початку";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 148;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Дата кінця";
            this.dateEndDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.Width = 126;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 95;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(ClinicApp.History);
            // 
            // historyBindingNavigator
            // 
            this.historyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historyBindingNavigator.BindingSource = this.historyBindingSource;
            this.historyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historyBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.historyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historyBindingNavigatorSaveItem});
            this.historyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historyBindingNavigator.Name = "historyBindingNavigator";
            this.historyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historyBindingNavigator.Size = new System.Drawing.Size(1017, 33);
            this.historyBindingNavigator.TabIndex = 1;
            this.historyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // historyBindingNavigatorSaveItem
            // 
            this.historyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historyBindingNavigatorSaveItem.Image = global::ClinicApp.Properties.Resources.save;
            this.historyBindingNavigatorSaveItem.Name = "historyBindingNavigatorSaveItem";
            this.historyBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.historyBindingNavigatorSaveItem.Text = "Save";
            this.historyBindingNavigatorSaveItem.Click += new System.EventHandler(this.historyBindingNavigatorSaveItem_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 529);
            this.Controls.Add(this.historyBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Історії хвороби";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingNavigator)).EndInit();
            this.historyBindingNavigator.ResumeLayout(false);
            this.historyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator historyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historyBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox patientsComboBox;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHisroryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}