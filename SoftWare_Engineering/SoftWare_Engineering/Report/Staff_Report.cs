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
namespace SoftWare_Engineering.Report
{
    public partial class Staff_Report : Form
    {
        MyContext context = new MyContext();
        public Staff_Report()
        {
            InitializeComponent();
        }

        private void Staff_Report_Load(object sender, EventArgs e)
        {
            dormMSDataSet1BindingSource.DataSource = context.Staffs.ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
