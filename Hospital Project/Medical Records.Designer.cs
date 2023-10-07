
namespace Hospital_Project
{
    partial class Medical_Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitalDataSet = new Hospital_Project.HospitalDataSet();
            this.medicalRecorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_RecorderTableAdapter = new Hospital_Project.HospitalDataSetTableAdapters.Medical_RecorderTableAdapter();
            this.mRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRDiagnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mRIDDataGridViewTextBoxColumn,
            this.mRNoDataGridViewTextBoxColumn,
            this.mRDiagnosDataGridViewTextBoxColumn,
            this.mRDateDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicalRecorderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 174);
            this.dataGridView1.TabIndex = 0;
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
            // mRIDDataGridViewTextBoxColumn
            // 
            this.mRIDDataGridViewTextBoxColumn.DataPropertyName = "MR_ID";
            this.mRIDDataGridViewTextBoxColumn.HeaderText = "MR_ID";
            this.mRIDDataGridViewTextBoxColumn.Name = "mRIDDataGridViewTextBoxColumn";
            // 
            // mRNoDataGridViewTextBoxColumn
            // 
            this.mRNoDataGridViewTextBoxColumn.DataPropertyName = "MR_No";
            this.mRNoDataGridViewTextBoxColumn.HeaderText = "MR_No";
            this.mRNoDataGridViewTextBoxColumn.Name = "mRNoDataGridViewTextBoxColumn";
            // 
            // mRDiagnosDataGridViewTextBoxColumn
            // 
            this.mRDiagnosDataGridViewTextBoxColumn.DataPropertyName = "MR_Diagnos";
            this.mRDiagnosDataGridViewTextBoxColumn.HeaderText = "MR_Diagnos";
            this.mRDiagnosDataGridViewTextBoxColumn.Name = "mRDiagnosDataGridViewTextBoxColumn";
            // 
            // mRDateDataGridViewTextBoxColumn
            // 
            this.mRDateDataGridViewTextBoxColumn.DataPropertyName = "MR_Date";
            this.mRDateDataGridViewTextBoxColumn.HeaderText = "MR_Date";
            this.mRDateDataGridViewTextBoxColumn.Name = "mRDateDataGridViewTextBoxColumn";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(283, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medical_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Project.Properties.Resources.istockphoto_1179324818_612x612;
            this.ClientSize = new System.Drawing.Size(744, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medical_Records";
            this.RightToLeftLayout = true;
            this.Text = "Medical_Recorder";
            this.Load += new System.EventHandler(this.Medical_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource medicalRecorderBindingSource;
        private HospitalDataSetTableAdapters.Medical_RecorderTableAdapter medical_RecorderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRDiagnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}