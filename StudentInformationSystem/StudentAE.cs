using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class StudentAE : Form
    {
        public static StudentAE myForm = new StudentAE();
        public static FormState.FORM_STATE State = new FormState.FORM_STATE();
        public int _id;
        public StudentAE()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtLastname.Text == string.Empty)
            {
                MessageBox.Show("Enter Lastname", "Lastname required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (TxtFirstname.Text == string.Empty)
            {
                MessageBox.Show("Enter firstname", "Firstname required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (TxtMiddlename.Text == string.Empty)
            {
                MessageBox.Show("Enter middlename", "Middlename required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (TxtCourse.Text == string.Empty)
            {
                MessageBox.Show("Enter course", "Course required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Student s = new Student()
            {
                StudentID = _id,
                Lastname = TxtLastname.Text,
                Firstname = TxtFirstname.Text,
                Middlename = TxtMiddlename.Text,
                Course = TxtCourse.Text,
                Year = Int32.Parse(CboYear.Text)
            };
            

            if (State == FormState.FORM_STATE.Add_Mode)
            {
                tbl_studentTableAdapter.InsertQuery(s.Lastname, s.Firstname, s.Middlename, s.Course, s.Year);
                MessageBox.Show("New Student Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (State == FormState.FORM_STATE.Edit_Mode)
            {
                tbl_studentTableAdapter.UpdateQuery(s.Lastname, s.Firstname, s.Middlename, s.Course, s.Year, s.StudentID );
                MessageBox.Show("Student updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        private void tbl_studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentdbDataSet);
        }

        private void StudentAE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentdbDataSet.tbl_student' table. You can move, or remove it, as needed.
            // this.tbl_studentTableAdapter.Fill(this.studentdbDataSet.tbl_student);
            if (State == FormState.FORM_STATE.Add_Mode)
            {
                LblTitle.Text = "Add Student";
                this.Text = LblTitle.Text;
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
                CboYear.SelectedIndex = 0;
                return;
            }
            else if (State == FormState.FORM_STATE.Edit_Mode)
            {
                LblTitle.Text = "Edit Student";
                this.Text = LblTitle.Text;
                _id = MainForm._id;
                tbl_studentTableAdapter.FillByID(studentdbDataSet.tbl_student, _id);
                return;
            }
        }
    }
}
