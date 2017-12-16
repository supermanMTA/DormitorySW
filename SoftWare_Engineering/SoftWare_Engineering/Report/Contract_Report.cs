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
    public partial class Contract_Report : Form
    {
        Contract contract = new Contract();
        MyContext context = new MyContext();
        public Contract_Report(int a)
        {
            InitializeComponent();
            contract.ID_Student = a;
        }

        private void Contract_Report_Load(object sender, EventArgs e)
        {
            try
            {
                
                Student st = context.Students.Find(contract.ID_Student);
                Contract ct = context.Contracts.Where(p => p.ID_Student == contract.ID_Student).FirstOrDefault();
                Staff staff = context.Staffs.Find(ct.ID_Staff);
                Class cl = context.Classes.Find(st.Class_ID);
                Faculty fl = context.Faculties.Find(cl.ID_Faculty);
                Room r = context.Rooms.Find(st.Room_ID);
                Dormitory dor = context.Dormitories.Find(r.ID_Dormitori);
                ReportParameter[] listPara = new ReportParameter[]{
                  new ReportParameter("StudentName",st.Name.ToUpper()),
                  new ReportParameter("StaffName",staff.Name.ToUpper()),
                  new ReportParameter("Gender",st.Gender.ToLower()),
                  new ReportParameter("Birth",st.DateOfBirth.Value.ToString()),
                  new ReportParameter("IDStudent",st.ID.ToString().ToLower()),
                  new ReportParameter("Class",cl.Name.ToLower()),
                  new ReportParameter("Faculty",fl.Name.ToLower()),
                  new ReportParameter("Telephone",st.PhoneNumber.ToLower()),
                  new ReportParameter("IDRoom",st.Room_ID.ToString().ToLower()),
                  new ReportParameter("Dormitory",dor.Name),
                  new ReportParameter("DateFound",ct.DateFound.Value.ToString()),
                  new ReportParameter("DateStart",ct.DateStart.Value.ToString()),
                  new ReportParameter("DateEnd",ct.DateEnd.Value.ToString())
                };
                this.reportViewer1.LocalReport.SetParameters(listPara);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

       
    }
}
