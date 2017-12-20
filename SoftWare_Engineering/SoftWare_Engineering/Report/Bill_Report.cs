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
using Microsoft.Reporting.WinForms;
namespace SoftWare_Engineering.Report
{
    public partial class Bill_Report : Form
    {
        Bill bill = new Bill();
        MyContext context = new MyContext();
        int id = 0;
        public Bill_Report(int a)
        {
            id = a;
            InitializeComponent();
        }

        private void Bill_Report_Load(object sender, EventArgs e)
        {
            try
            {
                bill = context.Bills.Find(id);
                int sum = (int)(bill.Rent + bill.WaterCharge + bill.ElectricCharge + bill.Surcharge);
                Student st = context.Students.Where(p => p.ID == bill.ID_Student).FirstOrDefault();
                Staff sf = context.Staffs.Where(p => p.ID == bill.ID_Staff).FirstOrDefault();
                dormMSDataSet3BindingSource.DataSource = bill;
                ReportParameter[] listPara = new ReportParameter[]{
                  new ReportParameter("Student",st.Name.ToUpper()),
                  new ReportParameter("Staff",sf.Name.ToUpper()),
                  new ReportParameter("ID",bill.ID.ToString()),
                  new ReportParameter("Date",bill.DateFounded.Value.ToString()),
                  new ReportParameter("Room",bill.ID_Room.ToString()),                  
                  new ReportParameter("Sum",sum.ToString()),
                  new ReportParameter("Year",context.SchoolYears.Where(p=>p.ID== bill.BillOfYear).FirstOrDefault().Name),
                  new ReportParameter("Month",bill.BillOfMonth.ToString())
                };
                this.reportViewer1.LocalReport.SetParameters(listPara);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
