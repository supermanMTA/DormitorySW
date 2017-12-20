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
using SoftWare_Engineering.Report;
namespace SoftWare_Engineering.Dorm
{
    public partial class Bill_M : Form
    {
        MyContext context = new MyContext();
        int id = 0;
        bool ok = true;
        double test;
        public Bill_M(int a)
        {
            InitializeComponent();
            id = a;
        }
        #region Load DL
        private void LoadDgvBill()
        {
            var ListBill = from p in context.Bills.Where(p => p.ID_Room == id)
                           select new
                           {
                               IDOfBill = p.ID,
                               BillOfMonth = p.BillOfMonth,
                               Year = context.SchoolYears.Where(z => z.ID == p.BillOfYear).FirstOrDefault().Name,
                               WaterCharge = p.WaterCharge,
                               ElectricCharge = p.ElectricCharge,
                               Rent = p.Rent,
                               Surcharge = p.Surcharge,
                               StudentID = p.ID_Student,// context.Students.Where(z=>z.ID== p.ID_Student).FirstOrDefault().Name,
                               RoomID=p.ID_Room,
                               StaffID=p.ID,//context.Staffs.Where(z=>z.ID== p.ID_Staff).FirstOrDefault().Name,
                               DateFound=p.DateFounded
                           };
            gridBill.DataSource = ListBill.ToList();
        }
        private void LoadControl()
        {

            cbbStaff.Properties.DataSource = context.Staffs.ToList()
                .Select(p => new
                {
                    ID = p.ID,
                    Name = p.Name
                }).ToList();

            cbbStaff.Properties.ValueMember = "ID";
            cbbStaff.Properties.DisplayMember = "Name";

            cbbStudent.Properties.DataSource = context.Students.Where(p => p.Room_ID == id)
                .Select(p => new
                {
                    ID=p.ID,
                    Name=p.Name
                }).ToList();
                
            cbbStudent.Properties.ValueMember = "ID";
            cbbStudent.Properties.DisplayMember = "Name";

            cbbYear.DataSource = context.SchoolYears.ToList();
            cbbYear.ValueMember = "ID";
            cbbYear.DisplayMember = "Name";
        }
        private void Bill_M_Load(object sender, EventArgs e)
        {
            LoadDgvBill();
            LoadControl();
        }
        #endregion
        #region Lấy và KT dữ liệu
        public bool check()
        {
            
            if (double.TryParse(txtElectric.Text,out test) == false) { MessageBox.Show("The data is not accurate"); return false; }
            if (double.TryParse(txtRent.Text, out test) == false) { MessageBox.Show("The data is not accurate");return false; }
            if (double.TryParse(txtSurcharge.Text, out test) == false) { MessageBox.Show("The data is not accurate");return false; }
            if (double.TryParse(txtWater.Text, out test) == false) { MessageBox.Show("The data is not accurate");return false; }
            else return true;
        }
        public void GetByForm(Bill bill)
        {
            bill.BillOfMonth = Convert.ToInt32(cbbMonth.Text);
            bill.BillOfYear =(int) cbbYear.SelectedValue;
            bill.DateFounded = cbbDate.Value;
            bill.ElectricCharge =Convert.ToInt32( txtElectric.Text);
            bill.Rent = Convert.ToInt32(txtRent.Text);
            bill.Surcharge = Convert.ToInt32(txtSurcharge.Text);
            bill.WaterCharge = Convert.ToInt32(txtWater.Text);
            bill.ID_Student = (int)cbbStudent.EditValue;
            bill.ID_Staff = (int)cbbStaff.EditValue;
            bill.ID_Room = Convert.ToInt32(txtRoom.Text);
            
        }
        #endregion
        #region Sự kiện 
        private void dgvBill_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtElectric.Text = dgvBill.GetFocusedRowCellValue("ElectricCharge").ToString();
                txtRent.Text= dgvBill.GetFocusedRowCellValue("Rent").ToString();
                txtSurcharge.Text= dgvBill.GetFocusedRowCellValue("Surcharge").ToString();
                txtWater.Text= dgvBill.GetFocusedRowCellValue("WaterCharge").ToString();
                cbbMonth.Text= dgvBill.GetFocusedRowCellValue("BillOfMonth").ToString();
                cbbYear.Text=dgvBill.GetFocusedRowCellValue("Year").ToString();
                cbbStaff.EditValue= dgvBill.GetFocusedRowCellValue("StaffID").ToString();
                cbbStudent.EditValue= dgvBill.GetFocusedRowCellValue("StudentID").ToString();
                txtRoom.Text = dgvBill.GetFocusedRowCellValue("RoomID").ToString();
                cbbDate.Text= dgvBill.GetFocusedRowCellValue("DateFound").ToString();
                txtID.Text= dgvBill.GetFocusedRowCellValue("IDOfBill").ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32( dgvBill.GetFocusedRowCellValue("IDOfBill").ToString());
            Bill_Report bill = new Bill_Report(id);
            bill.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ok = true;
            txtElectric.Clear();
            txtRent.Clear();
            txtSurcharge.Clear();
            txtWater.Clear();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ok = false;
            
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Bill");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this bill?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Bill tg = new Bill();
                        int id = Convert.ToInt32(txtID.Text);
                        tg = context.Bills.Where(p => p.ID == id).FirstOrDefault();
                        context.Bills.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoadDgvBill();
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
                try {
                    if (check() == true)
                    {
                        Bill bill = new Bill();                       
                        GetByForm(bill);
                        var t = context.Bills.Where(p => p.BillOfMonth == bill.BillOfMonth & p.BillOfYear == bill.BillOfYear).FirstOrDefault();
                        if (t!=null)
                        {
                            MessageBox.Show("This month has been invoiced");
                        }
                        else
                        {
                            context.Bills.Add(bill);
                            context.SaveChanges();
                            MessageBox.Show("Done");
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = true;
                            btnSave.Enabled = false;
                            BtnDelete.Enabled = true;
                            btnCancel.Enabled = false;
                            LoadDgvBill();
                        }
                       
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
                    if (check() == true)
                    {
                        int id =Convert.ToInt32( dgvBill.GetFocusedRowCellValue("IDOfBill").ToString());
                        Bill bill = context.Bills.Find(id);
                        GetByForm(bill);
                        context.SaveChanges();
                        MessageBox.Show("Done");
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnSave.Enabled = false;
                        BtnDelete.Enabled = true;
                        btnCancel.Enabled = false;
                        LoadDgvBill();
                    }
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
            btnSave.Enabled = false;
            BtnDelete.Enabled = true;
            btnCancel.Enabled = false;
        }
        #endregion
    }
}
