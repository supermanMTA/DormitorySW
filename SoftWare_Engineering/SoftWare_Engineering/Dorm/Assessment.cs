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

namespace SoftWare_Engineering.Dorm
{
    public partial class Assessment : Form
    {
        MyContext context = new MyContext();
        int id = 0;
        bool ok = true;
        public Assessment(int a)
        {
            id = a;
            InitializeComponent();
        }
        #region Load DL
        public void LoadDL()
        {
            var listAss = from p in context.RoomAssessments.Where(p => p.ID_Room == id)
                          select new
                          {
                              IDOfAssessment = p.ID,
                              IDOfRoom = p.ID_Room,
                              IDOfStaff = p.ID_Staff,
                              IDOfYear = p.ID_Year,
                              Purport = p.Purport,
                          };
            gridAss.DataSource = listAss.ToList();
        }
        public void LoadControl()
        {
            cbbYear.DataSource = context.SchoolYears.ToList();
            cbbYear.ValueMember = "ID";
            cbbYear.DisplayMember = "Name";
            cbbStaff.DataSource = context.Staffs.ToList();
            cbbStaff.ValueMember = "ID";
            cbbStaff.DisplayMember = "Name";
        }
        private void Assessment_Load(object sender, EventArgs e)
        {
            txtRoomID.Text = id.ToString();
            LoadControl();
            LoadDL();
        }
        #endregion
        #region Lấy Dl
        public void GetByForm(RoomAssessment am)
        {
            am.ID_Staff =(int) cbbStaff.SelectedValue;
            am.ID_Year = (int)cbbYear.SelectedValue;
            am.Purport = txtPurport.Text;
            am.ID_Room = id;
        }
        #endregion
        #region Sự kiện
        private void gridAssessment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtID.Text = gridAssessment.GetFocusedRowCellValue("IDOfAssessment").ToString();
                txtRoomID.Text = gridAssessment.GetFocusedRowCellValue("IDOfRoom").ToString();
                cbbStaff.SelectedIndex = (int)gridAssessment.GetFocusedRowCellValue("IDOfStaff");
                cbbYear.SelectedIndex = (int)gridAssessment.GetFocusedRowCellValue("IDOfYear");
                txtPurport.Text = gridAssessment.GetFocusedRowCellValue("Purport").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            groupBox1.Enabled = true;
            txtPurport.Clear();
            ok = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Assessment");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this assessment?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        RoomAssessment tg = new RoomAssessment();
                        int id = Convert.ToInt32(txtID.Text);
                        tg = context.RoomAssessments.Where(p => p.ID == id).FirstOrDefault();
                        context.RoomAssessments.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoadDL();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ok = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            groupBox1.Enabled = true;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    RoomAssessment tg = new RoomAssessment();
                    GetByForm(tg);
                    var year = context.RoomAssessments.Where(p => p.ID_Year == tg.ID_Year).FirstOrDefault();
                    if (year != null)
                    {
                        MessageBox.Show("The rating of this year entered");
                    }
                    else
                    {
                        context.RoomAssessments.Add(tg);
                        context.SaveChanges();
                        MessageBox.Show("Done");
                        LoadDL();
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                        groupBox1.Enabled = false;
                    }
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
                    int id =Convert.ToInt32( gridAssessment.GetFocusedRowCellValue("IDOfAssessment").ToString());
                    var tg = context.RoomAssessments.Where(p => p.ID == id).FirstOrDefault();
                    GetByForm(tg);
                //    context.RoomAssessments.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoadDL();
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    groupBox1.Enabled = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = false;
        }
        #endregion


    }
}
