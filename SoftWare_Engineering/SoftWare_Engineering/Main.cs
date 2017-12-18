using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftWare_Engineering.GUI;
using SoftWare_Engineering.Data;
//using SoftWare_Engineering.Report;
using SoftWare_Engineering.Management_Student;
using SoftWare_Engineering.GUIStudent;
namespace SoftWare_Engineering
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User user = new User();
        MyContext context = new MyContext();
        public Main()
        {
            InitializeComponent();
        }
        public Main(User u)
        {
            InitializeComponent();
            user = u;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnRegis.Enabled = false;
        }
        public  void LoadUser()
        {
            if (user != null)
            {
                if (user.Object == 1)
                {
                    btnDormM.Enabled = true;
                    btnStaffM.Enabled = true;
                    btnStudentM.Enabled = true;                    
                }
                if(user.Object==2)
                {                   
                    var student = context.Students.Where(p => p.Email == user.Email).FirstOrDefault();
                    if (student != null)
                    {
                        var contract = context.Contracts.Where(p => p.ID_Student == student.ID).FirstOrDefault();
                        if (contract.DateEnd>DateTime.Now)
                        {
                            btnInfor.Enabled = true; barExtension.Enabled = false; btnRegistration.Enabled = false;
                        }
                        else
                        {
                            btnInfor.Enabled = true; barExtension.Enabled = true; btnRegistration.Enabled = false;
                        }
                        
                    }
                    else { btnInfor.Enabled = false; btnRegistration.Enabled = true;barExtension.Enabled = false; }
                    
                }
            }
            else { return; }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Start nv = new Start();
            panelMain.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nv);
            nv.Show();
            LoadUser();
        }
        #region Manager
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
        #endregion

        #region Student
        private void btnRegistration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListRegistration list = new ListRegistration(user);
            panelMain.Controls.Clear();
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Information list = new Information(user);
            panelMain.Controls.Clear();
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            panelMain.Controls.Add(list);
            list.Show();
        }

        private void barExtension_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Extension nv = new Extension(user);
            panelMain.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nv);
            nv.Show();
        }
        #endregion

        #region System 
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void btnRegis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Regis regis = new Regis();
            regis.ShowDialog();
           
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
        #endregion
    }
}
