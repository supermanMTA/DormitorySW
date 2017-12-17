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
    public partial class Information : Form
    {
        Student st = new Student();
        MyContext context = new MyContext();
        public Information(User user)
        {
            st = context.Students.Where(p => p.Email == user.Email).FirstOrDefault();
            InitializeComponent();
        }
        public void LoadInfor()
        {
            txtId.Text = st.ID.ToString();
            txtStudentName.Text=st.Name;
            cbbGender.Text=st.Gender;
            cbbObject.Text=st.Object;
            txtAddress.Text=st.Address;
            dateBirth.Value=(DateTime)st.DateOfBirth;
            txtIdentity.Text=st.IdentityCard;
            cbbNation.Text=st.Nation;
            cbbReligion.Text=st.Religion;
            txtPhone.Text=st.PhoneNumber;
            cbbClass.SelectedValue=st.Class_ID;
            txtEmail.Text = st.Email;

        }

        private void Information_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadInfor();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
        private void LoadControl()
        {
            cbbClass.DataSource = context.Classes.ToList();
            cbbClass.ValueMember = "ID";
            cbbClass.DisplayMember = "Name";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            st.Name = txtStudentName.Text;
            st.Gender = cbbGender.Text;
            st.Object = cbbObject.Text;
            st.Address = txtAddress.Text;
            st.DateOfBirth = dateBirth.Value;
            st.IdentityCard = txtIdentity.Text;
            st.Nation = cbbNation.Text;
            st.Religion = cbbReligion.Text;
            st.PhoneNumber = txtPhone.Text;
            st.Class_ID = Convert.ToInt32(cbbClass.SelectedValue);
            context.SaveChanges();
            MessageBox.Show("Done");
        }
    }
}
