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

namespace SoftWare_Engineering.GUI
{
    public partial class Frm_Calendar : Form
    {
        MyContext context = new MyContext();
        public Frm_Calendar()
        {
            InitializeComponent();
        }

        public void LoadDL()
        {
            gridCalendar.DataSource = from p in context.Calendars.ToList()
                                      select new
                                      {
                                          Day = p.Day,
                                          Dormitory = context.Dormitories.Where(z => z.ID == p.Dormitory).FirstOrDefault().Name,
                                          Staff = context.Staffs.Where(z => z.ID == p.ID_Staff).FirstOrDefault().Name
                                           
                                      };
        }
        public void LoadControl()
        {
            cbbDormitory.DataSource = context.Dormitories.ToList();
            cbbDormitory.ValueMember = "ID";
            cbbDormitory.DisplayMember = "Name";

            cbbStaff.DataSource = context.Staffs.ToList();
            cbbStaff.ValueMember = "ID";
            cbbStaff.DisplayMember = "Name";
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Day = date.Value;
            calendar.Dormitory =(int) cbbDormitory.SelectedValue;
            calendar.ID_Staff =(int) cbbStaff.SelectedValue;
            context.Calendars.Add(calendar);
            context.SaveChanges();
            Calendar_Load(sender, e);
        }       
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Excel |*.xls";
            savefile.Title = "Save with excel ";
            savefile.ShowDialog();
            string filename = savefile.FileName.ToString();
            try
            {
                gridCalendar.ExportToXls(filename);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}
