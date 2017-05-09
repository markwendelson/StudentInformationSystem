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
    public partial class MainForm : Form
    {
        public static int _id;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAllStudent_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            this.tbl_studentTableAdapter.Fill(this.studentdbDataSet.tbl_student);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Nothing to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            this.tbl_studentTableAdapter.DeleteQuery(_id);
            MessageBox.Show("Student deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_studentTableAdapter.Fill(this.studentdbDataSet.tbl_student);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Nothing to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            Form frm = new StudentAE();
            StudentAE.State = FormState.FORM_STATE.Edit_Mode;
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {           

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new StudentAE();
            StudentAE.State = FormState.FORM_STATE.Add_Mode;
            frm.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.tbl_studentTableAdapter.Fill(this.studentdbDataSet.tbl_student);
            this.tblstudentBindingSource.Filter = ("lastname like '%" + TxtSearch.Text + "%' OR firstname like '%" + TxtSearch.Text + "%'");
        }
    }
}
