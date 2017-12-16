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
namespace SoftWare_Engineering.Management_Student
{
    public partial class ListRegistration : Form
    {
        MyContext context = new MyContext();
        public ListRegistration()
        {
            InitializeComponent();
        }
        private void LoadControl()
        {
            cbbClass.DataSource = context.Classes.ToList();
            cbbClass.ValueMember = "ID";
            cbbClass.DisplayMember = "Name";
        }
        private RegistrationForm GetByForm()
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Name = txtStudentName.Text;
            rf.Gender = cbbGender.Text;
            rf.Object = cbbObject.Text;
            rf.Address = txtAddress.Text;
            rf.DateOfBirth = dateBirth.Value;
            rf.IdentityCard = txtIdentity.Text;
            rf.Nation = cbbNation.Text;
            rf.Religion = cbbReligion.Text;
            rf.PhoneNumber = txtPhone.Text;
            rf.ID_Class = Convert.ToInt32( cbbClass.SelectedValue);
            rf.NameFather = txtNameFather.Text;
            rf.BirthDayOfFather = dateBirthFather.Value;
            rf.JobOfFather = txtJobFather.Text;
            rf.NameMother = txtNameMother.Text;
            rf.BirthDayOfMother = dateBirthMother.Value;
            rf.JobOfMother = txtJobMother.Text;
            return rf;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationForm tg = GetByForm();
                context.RegistrationForms.Add(tg);
                context.SaveChanges();
                MessageBox.Show("Done");
                txtAddress.Clear();
                txtIdentity.Clear();
                txtJobFather.Clear();
                txtJobMother.Clear();
                txtNameFather.Clear();
                txtNameMother.Clear();
                txtPhone.Clear();
                txtStudentName.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtIdentity.Clear();
            txtJobFather.Clear();
            txtJobMother.Clear();
            txtNameFather.Clear();
            txtNameMother.Clear();
            txtPhone.Clear();
            txtStudentName.Clear();
            
        }

        private void ListRegistration_Load(object sender, EventArgs e)
        {
            LoadControl();
        }
    }
}
