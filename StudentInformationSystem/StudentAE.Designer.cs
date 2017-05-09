namespace StudentInformationSystem
{
    partial class StudentAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtMiddlename = new System.Windows.Forms.TextBox();
            this.TxtCourse = new System.Windows.Forms.TextBox();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.studentdbDataSet = new StudentInformationSystem.studentdbDataSet();
            this.tbl_studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_studentTableAdapter = new StudentInformationSystem.studentdbDataSetTableAdapters.tbl_studentTableAdapter();
            this.tableAdapterManager = new StudentInformationSystem.studentdbDataSetTableAdapters.TableAdapterManager();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middlename:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year:";
            // 
            // TxtLastname
            // 
            this.TxtLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_studentBindingSource, "lastname", true));
            this.TxtLastname.Location = new System.Drawing.Point(36, 126);
            this.TxtLastname.MaxLength = 100;
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(298, 26);
            this.TxtLastname.TabIndex = 7;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_studentBindingSource, "firstname", true));
            this.TxtFirstname.Location = new System.Drawing.Point(36, 189);
            this.TxtFirstname.MaxLength = 100;
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(298, 26);
            this.TxtFirstname.TabIndex = 8;
            // 
            // TxtMiddlename
            // 
            this.TxtMiddlename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_studentBindingSource, "middlename", true));
            this.TxtMiddlename.Location = new System.Drawing.Point(36, 251);
            this.TxtMiddlename.MaxLength = 100;
            this.TxtMiddlename.Name = "TxtMiddlename";
            this.TxtMiddlename.Size = new System.Drawing.Size(298, 26);
            this.TxtMiddlename.TabIndex = 9;
            // 
            // TxtCourse
            // 
            this.TxtCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_studentBindingSource, "course", true));
            this.TxtCourse.Location = new System.Drawing.Point(36, 314);
            this.TxtCourse.MaxLength = 100;
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.Size = new System.Drawing.Size(298, 26);
            this.TxtCourse.TabIndex = 10;
            // 
            // CboYear
            // 
            this.CboYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_studentBindingSource, "year", true));
            this.CboYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_studentBindingSource, "year", true));
            this.CboYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbl_studentBindingSource, "year", true));
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CboYear.Location = new System.Drawing.Point(36, 377);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(298, 28);
            this.CboYear.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(228, 425);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 43);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(116, 425);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(106, 43);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // studentdbDataSet
            // 
            this.studentdbDataSet.DataSetName = "studentdbDataSet";
            this.studentdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_studentBindingSource
            // 
            this.tbl_studentBindingSource.DataMember = "tbl_student";
            this.tbl_studentBindingSource.DataSource = this.studentdbDataSet;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_studentTableAdapter = this.tbl_studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentInformationSystem.studentdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Green;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitle.Size = new System.Drawing.Size(384, 64);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Student";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentAE
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(384, 490);
            this.ControlBox = false;
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.TxtCourse);
            this.Controls.Add(this.TxtMiddlename);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private studentdbDataSet studentdbDataSet;
        private System.Windows.Forms.BindingSource tbl_studentBindingSource;
        private studentdbDataSetTableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private studentdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox TxtLastname;
        public System.Windows.Forms.TextBox TxtFirstname;
        public System.Windows.Forms.TextBox TxtMiddlename;
        public System.Windows.Forms.TextBox TxtCourse;
        public System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.Label LblTitle;
    }
}