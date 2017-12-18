using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftWare_Engineering.Report;
using SoftWare_Engineering.Data;
namespace SoftWare_Engineering.Report
{
    public partial class StudentReport : Form
    {
        MyContext context = new MyContext();
        int id = 0;
        public StudentReport(int a)
        {
            InitializeComponent();
            id = a;
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            if (id == 2) {

                dormMSDataSetBindingSource.DataSource = context.Students.ToList();
                this.reportViewer1.RefreshReport();
            }
           
            if (id == 1)
            {

                dormMSDataSetBindingSource.DataSource = context.Students.OrderBy(p => p.Room_ID).ToList();
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
