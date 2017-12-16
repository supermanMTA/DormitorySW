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
    public partial class FormCFM : Form
    {
        MyContext context = new MyContext();
        bool ok = true;
        public FormCFM()
        {
            InitializeComponent();
        }
        #region Load dữ liệu
        private void LoaddgvFaculty()
        {
            var dbFaculty = from p in context.Faculties
                            select new
                            {
                                IDOfFaculty=p.ID,
                                Name=p.Name,
                                Address=p.Address
                            };
            gridF.DataSource = dbFaculty.ToList();
                
        }
        private void LoaddgvClass()
        {
            var dbClass = from p in context.Classes
                          select new
                          {
                              IDOfClass = p.ID,
                              Name = p.Name,
                              FacultyName = context.Faculties.Where(z => z.ID == p.ID_Faculty).FirstOrDefault().Name
                            };
            gridC.DataSource = dbClass.ToList();
        }
        private void LoadControl()
        {
            cbbFaculty.DataSource = context.Faculties.ToList();
            cbbFaculty.ValueMember = "ID";
            cbbFaculty.DisplayMember = "Name";
        }
        private void FormCFM_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoaddgvClass();
            LoaddgvFaculty();
        }
        #endregion

        #region Lấy dữ liệu từ form
        private Faculty GetFacultyByForm(Faculty faculty)
        {
            faculty.Name = txtNameFaculty.Text;
            faculty.Address = txtAddressFaculty.Text;

            return faculty;
        }
        private Class GetClassByForm(Class cl)
        {
            cl.ID_Faculty = Convert.ToInt32( cbbFaculty.SelectedValue);
            cl.Name = txtNameClass.Text;
            return cl;
        }
        #endregion

        #region Sự kiện của Faculty
        private void gridFaculty_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtIDFaculty.Text = gridFaculty.GetFocusedRowCellValue("IDOfFaculty").ToString();
            txtNameFaculty.Text = gridFaculty.GetFocusedRowCellValue("Name").ToString();
            txtAddressFaculty.Text = gridFaculty.GetFocusedRowCellValue("Address").ToString(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtIDFaculty.Clear();
            txtNameFaculty.Clear();
            txtAddressFaculty.Clear(); 
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
            if (txtIDFaculty.Text == "")
            {
                MessageBox.Show("Choose Faculty");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this Faculty?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Faculty tg = new Faculty();
                        int id = Convert.ToInt32(txtIDFaculty.Text);
                        tg = context.Faculties.Where(p => p.ID == id).FirstOrDefault();
                        context.Faculties.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvFaculty();
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
                    Faculty tg = new Faculty();
                    GetFacultyByForm(tg);
                    context.Faculties.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvFaculty();
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
                    Faculty tg = new Faculty();
                    int id = Convert.ToInt32(txtIDFaculty.Text);
                    tg = context.Faculties.Where(p => p.ID == id).FirstOrDefault();
                    GetFacultyByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvFaculty();
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
            FormCFM_Load(sender, e);
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Sự kiện của Class
        private void gridClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtIDClass.Text = gridClass.GetFocusedRowCellValue("IDOfClass").ToString();
                txtNameClass.Text = gridClass.GetFocusedRowCellValue("Name").ToString();
                cbbFaculty.Text = gridClass.GetFocusedRowCellValue("FacultyName").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            LoadControl();
            groupBox2.Enabled = true;
            txtIDClass.Clear();
            txtNameClass.Clear();
            //cbbFaculty .Clear();
            btnAddClass.Enabled = false;
            btnEditClass.Enabled = false;
            btnDeleteClass.Enabled = false;
            btnSaveClass.Enabled = true;
            btnCancelClass.Enabled = true;
            ok = true;
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            LoadControl();
            groupBox2.Enabled = true;
            btnAddClass.Enabled = false;
            btnEditClass.Enabled = false;
            btnDeleteClass.Enabled = false;
            btnSaveClass.Enabled = true;
            btnCancelClass.Enabled = true;
            ok = false;
            
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (txtIDClass.Text == "")
            {
                MessageBox.Show("Choose Class");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this Class?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Class tg = new Class();
                        int id = Convert.ToInt32(txtIDClass.Text);
                        tg = context.Classes.Where(p => p.ID == id).FirstOrDefault();
                        context.Classes.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvClass();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    Class tg = new Class();
                    GetClassByForm(tg);
                    context.Classes.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvClass();
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
                    Class tg = new Class();
                    int id = Convert.ToInt32(txtIDClass.Text);
                    tg = context.Classes.Where(p => p.ID == id).FirstOrDefault();
                    GetClassByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvClass();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            btnAddClass.Enabled = true;
            btnEditClass.Enabled = true;
            btnDeleteClass.Enabled = true;
            btnSaveClass.Enabled = false;
            btnCancelClass.Enabled = false;
            groupBox2.Enabled = false;
            ok = true;
        }

        private void btnCancelClass_Click(object sender, EventArgs e)
        {
            FormCFM_Load(sender,e);
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnAddClass.Enabled = true;
            btnEditClass.Enabled = true;
            btnDeleteClass.Enabled = true;
            btnSaveClass.Enabled = false;
            btnCancelClass.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnExitClass_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
