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

namespace SoftWare_Engineering.GUIStudent
{
    public partial class Extension : Form
    {
        MyContext context = new MyContext();
        User user = new User();
        public Extension(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            Student st = context.Students.Where(p => p.Email == user.Email).FirstOrDefault();
            var contract = context.Contracts.Where(p => p.ID_Student == st.ID).FirstOrDefault();
            contract.DateStart = DateTime.Now;
            if (cbbTime.Text == "1 year") contract.DateEnd = DateTime.Now.AddDays(365);
            if (cbbTime.Text == "1 term") contract.DateEnd = DateTime.Now.AddDays(365);
            context.SaveChanges();
            MessageBox.Show("Successful");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Extension_Load(object sender, EventArgs e)
        {
            Student st = context.Students.Where(p => p.Email == user.Email).FirstOrDefault();
            var contract = context.Contracts.Where(p => p.ID_Student == st.ID).FirstOrDefault();
            txtID.Text = contract.ID.ToString();
            txtStudentID.Text= st.ID.ToString();
            txtRoomID.Text = st.Room_ID.ToString();

         }
    }
}
