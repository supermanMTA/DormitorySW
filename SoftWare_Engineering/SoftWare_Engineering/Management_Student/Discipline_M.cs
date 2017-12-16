using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftWare_Engineering.Data;
namespace SoftWare_Engineering.Management_Student
{
    public partial class Discipline_M : Form
    {
        Discipline discipline = new Discipline();
        MyContext context = new MyContext();
        bool ok = true;
        int ID = 0;
        public Discipline_M(int a)
        {
            InitializeComponent();
            discipline.ID_Student = a;
        }
        private void LoaddgvDiscipline()
        {
            var dbDiscipline = context.Disciplines.Where(p => p.ID_Student == discipline.ID_Student).ToList()
                              .Select(p => new
                              {
                                  IDOfDiscipline = p.ID,
                                  Reason = p.Reason,
                                  Degree = p.Degree,
                                  LevelOfDiscipline=p.Level_Dis,
                                  DateDiscipline = p.Date,
                                  Note = p.Note,
                                  StudentID = p.ID_Student
                              }).ToList();
            dgvDiscipline.DataSource = dbDiscipline;
        }
        private void Discipline_M_Load(object sender, EventArgs e)
        {
            LoaddgvDiscipline();
        }

        private Discipline GetDisciplineByForm(Discipline dc)
        {
            dc.ID_Student = discipline.ID_Student;  
            dc.Note = txtNote.Text;
            dc.Reason = txtReason.Text;
            dc.Date = dateDiscipline.Value;
            dc.Degree = cbbDegree.Text;
            dc.Level_Dis = txtLevel.Text;
            
            return dc;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvDiscipline.CurrentRow.Cells["IDOfDiscipline"].Value.ToString();

            txtNote.Text = dgvDiscipline.CurrentRow.Cells["Note"].Value.ToString();
            cbbDegree.Text = dgvDiscipline.CurrentRow.Cells["Degree"].Value.ToString();
            txtStudentID.Text = discipline.ID_Student.ToString();
            txtReason.Text = dgvDiscipline.CurrentRow.Cells["Reason"].Value.ToString();
            dateDiscipline.Text = dgvDiscipline.CurrentRow.Cells["DateDiscipline"].Value.ToString();
            txtLevel.Text = dgvDiscipline.CurrentRow.Cells["LevelOfDiscipline"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtID.Clear();
            txtLevel.Clear();
            txtNote.Clear();
            txtReason.Clear();
          
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Discipline");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Discipline tg = new Discipline();
                        int id = Convert.ToInt32(txtID.Text);
                        tg = context.Disciplines.Where(p => p.ID == id).FirstOrDefault();
                        context.Disciplines.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvDiscipline();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    Discipline tg = new Discipline();
                    GetDisciplineByForm(tg);
                    context.Disciplines.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvDiscipline();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Discipline tg = new Discipline();
                    int id = Convert.ToInt32(txtID.Text);
                    tg = context.Disciplines.Where(p => p.ID == id).FirstOrDefault();
                    GetDisciplineByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvDiscipline();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoaddgvDiscipline();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
