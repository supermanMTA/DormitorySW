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
    public partial class Compliment_M : Form
    {
        Compliment compliment = new Compliment();
        MyContext context = new MyContext();
        bool ok = true;
        int ID = 0;
        public Compliment_M(int a)
        {
            InitializeComponent();
            compliment.ID_Student = a;
        }
        private void LoaddgvCompliment()
        {
            var dbCompliment = context.Compliments.Where(p => p.ID_Student == compliment.ID_Student).ToList()
                               .Select(p => new
                               {
                                   IDOfCompliment=p.ID,
                                   NameOfCompliment=p.Name,
                                   Reason=p.Reason,
                                   Degree=p.Degree,
                                   DateCompliment=p.Date,
                                   Note=p.Note,
                                   StudentID=p.ID_Student
                               }).ToList();
            dgvCompliment.DataSource = dbCompliment;
        }
        private void Compliment_M_Load(object sender, EventArgs e)
        {
            LoaddgvCompliment();
        }  
        private Compliment GetComplimentByForm(Compliment cp)
        {
            cp.ID_Student = compliment.ID_Student;
            cp.Name = txtName.Text;
            cp.Note = txtNote.Text;
            cp.Reason = txtReason.Text;
            cp.Date = dateCompliment.Value;
            cp.Degree = cbbDegree.Text;
            return cp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtID.Clear();
            txtName.Clear();
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
            ok = false; ;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Compliment");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this Compliment?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Compliment tg = new Compliment();
                        int id = Convert.ToInt32(txtID.Text);
                        tg = context.Compliments.Where(p => p.ID == id).FirstOrDefault();
                        context.Compliments.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvCompliment();
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
                try{
                    Compliment tg = new Compliment();
                    GetComplimentByForm(tg);
                    context.Compliments.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvCompliment();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Compliment tg = new Compliment();
                    int id = Convert.ToInt32(txtID.Text);
                    tg = context.Compliments.Where(p => p.ID == id).FirstOrDefault();
                    GetComplimentByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvCompliment();
                }
                catch(Exception ex)
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
            Compliment_M_Load(sender, e);
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

        private void dgCompliment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtID.Text =dgCompliment.GetFocusedRowCellValue("IDOfCompliment").ToString();
                txtName.Text = dgCompliment.GetFocusedRowCellValue("NameOfCompliment").ToString();
                txtNote.Text = dgCompliment.GetFocusedRowCellValue("Note").ToString(); 
                cbbDegree.Text = dgCompliment.GetFocusedRowCellValue("Degree").ToString(); 
                txtStudentID.Text = compliment.ID_Student.ToString();
                txtReason.Text = dgCompliment.GetFocusedRowCellValue("Reason").ToString();
                dateCompliment.Text = dgCompliment.GetFocusedRowCellValue("DateCompliment").ToString(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
