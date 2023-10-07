
namespace Hospital_Project
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hospitalDataSet = new Hospital_Project.HospitalDataSet();
            this.medicalRecorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_RecorderTableAdapter = new Hospital_Project.HospitalDataSetTableAdapters.Medical_RecorderTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Hospital_Project.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.receptionTableAdapter = new Hospital_Project.HospitalDataSetTableAdapters.ReceptionTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKReceptionMedicalRecorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKReceptionMedicalRecorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReceptionMedicalRecorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReceptionMedicalRecorderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalRecorderBindingSource
            // 
            this.medicalRecorderBindingSource.DataMember = "Medical Recorder";
            this.medicalRecorderBindingSource.DataSource = this.hospitalDataSet;
            // 
            // medical_RecorderTableAdapter
            // 
            this.medical_RecorderTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // receptionTableAdapter
            // 
            this.receptionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pEmailDataGridViewTextBoxColumn,
            this.pPhoneDataGridViewTextBoxColumn,
            this.pAddressDataGridViewTextBoxColumn,
            this.pGenderDataGridViewTextBoxColumn,
            this.pAgeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "P_Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pEmailDataGridViewTextBoxColumn
            // 
            this.pEmailDataGridViewTextBoxColumn.DataPropertyName = "P_Email";
            this.pEmailDataGridViewTextBoxColumn.HeaderText = "P_Email";
            this.pEmailDataGridViewTextBoxColumn.Name = "pEmailDataGridViewTextBoxColumn";
            // 
            // pPhoneDataGridViewTextBoxColumn
            // 
            this.pPhoneDataGridViewTextBoxColumn.DataPropertyName = "P_Phone";
            this.pPhoneDataGridViewTextBoxColumn.HeaderText = "P_Phone";
            this.pPhoneDataGridViewTextBoxColumn.Name = "pPhoneDataGridViewTextBoxColumn";
            // 
            // pAddressDataGridViewTextBoxColumn
            // 
            this.pAddressDataGridViewTextBoxColumn.DataPropertyName = "P_Address";
            this.pAddressDataGridViewTextBoxColumn.HeaderText = "P_Address";
            this.pAddressDataGridViewTextBoxColumn.Name = "pAddressDataGridViewTextBoxColumn";
            // 
            // pGenderDataGridViewTextBoxColumn
            // 
            this.pGenderDataGridViewTextBoxColumn.DataPropertyName = "P_Gender";
            this.pGenderDataGridViewTextBoxColumn.HeaderText = "P_Gender";
            this.pGenderDataGridViewTextBoxColumn.Name = "pGenderDataGridViewTextBoxColumn";
            // 
            // pAgeDataGridViewTextBoxColumn
            // 
            this.pAgeDataGridViewTextBoxColumn.DataPropertyName = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.HeaderText = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.Name = "pAgeDataGridViewTextBoxColumn";
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // fKReceptionMedicalRecorderBindingSource
            // 
            this.fKReceptionMedicalRecorderBindingSource.DataMember = "FK_Reception_Medical Recorder";
            this.fKReceptionMedicalRecorderBindingSource.DataSource = this.medicalRecorderBindingSource;
            // 
            // fKReceptionMedicalRecorderBindingSource1
            // 
            this.fKReceptionMedicalRecorderBindingSource1.DataMember = "FK_Reception_Medical Recorder";
            this.fKReceptionMedicalRecorderBindingSource1.DataSource = this.medicalRecorderBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(334, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Project.Properties.Resources.istockphoto_1179324818_612x612;
            this.ClientSize = new System.Drawing.Size(757, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReceptionMedicalRecorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReceptionMedicalRecorderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource medicalRecorderBindingSource;
        private HospitalDataSetTableAdapters.Medical_RecorderTableAdapter medical_RecorderTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource fKReceptionMedicalRecorderBindingSource;
        private HospitalDataSetTableAdapters.ReceptionTableAdapter receptionTableAdapter;
        private System.Windows.Forms.BindingSource fKReceptionMedicalRecorderBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}