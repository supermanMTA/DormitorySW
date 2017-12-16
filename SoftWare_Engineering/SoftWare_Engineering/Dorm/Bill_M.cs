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
        public Bill_M(int a)
        {
            InitializeComponent();
            id = a;
        }
        private void LoadDgvBill()
        {
            var ListBill = from p in context.Bills.Where(p => p.ID_Room == id)
                           select new
                           {
                               IDOfBill = p.ID,
                               BillOfMonth = p.BillOfMonth,
                               Year = context.SchoolYears.Where(z => z.ID == p.BillOfYear).FirstOrDefault().Name,
                               WaterCharge=p.WaterCharge,
                               ElectricCharge=p.ElectricCharge,
                               Rent=p.Rent,
                               Surcharge=p.Surcharge,
                               StudentName= context.Students.Where(z=>z.ID== p.ID_Student).FirstOrDefault().Name,
                               RoomID=p.ID_Room,
                               StaffName=context.Staffs.Where(z=>z.ID== p.ID_Staff).FirstOrDefault().Name,
                               DateFound=p.DateFounded
                           };
            gridBill.DataSource = ListBill.ToList();
        }
        private void LoadControl()
        {
            cbbStaff.DataSource = context.Staffs.ToList();
            cbbStaff.ValueMember = "ID";
            cbbStaff.DisplayMember = "Name";

            cbbStudent.DataSource = context.Students.Where(p => p.Room_ID == id).ToList();
            cbbStudent.ValueMember = "ID";
            cbbStudent.DisplayMember = "Name";

            cbbYear.DataSource = context.SchoolYears.ToList();
            cbbYear.ValueMember = "ID";
            cbbYear.DisplayMember = "Name";
        }
        private void Bill_M_Load(object sender, EventArgs e)
        {
            LoadDgvBill();
            LoadControl();
        }

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
                cbbStaff.Text= dgvBill.GetFocusedRowCellValue("StaffName").ToString();
                cbbStudent.Text= dgvBill.GetFocusedRowCellValue("StudentName").ToString();
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
    }
}
