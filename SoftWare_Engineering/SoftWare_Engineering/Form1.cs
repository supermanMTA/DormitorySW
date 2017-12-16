using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftWare_Engineering.GUI;
//using SoftWare_Engineering.Report;
using SoftWare_Engineering.Management_Student;
using SoftWare_Engineering.GUIStudent;
namespace SoftWare_Engineering
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStudentM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StudentForm st = new StudentForm();
            panelMain.Controls.Clear();
            st.TopLevel = false;
            st.Dock = DockStyle.Fill;
            panelMain.Controls.Add(st);
            st.Show();
        }

        private void btnStaffM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Staff sf = new Frm_Staff();

            panelMain.Controls.Clear();
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            panelMain.Controls.Add(sf);
            sf.Show();
        }

        private void btnDormM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Dorm nv = new Frm_Dorm();

            panelMain.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nv);
            nv.Show();
        }

        private void btnRegistration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListRegistration list = new ListRegistration();
            panelMain.Controls.Clear();
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start nv = new Start();

            panelMain.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nv);
            nv.Show();
        }

        private void barExtension_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Extension nv = new Extension();

            panelMain.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nv);
            nv.Show();
        }
    }
}
