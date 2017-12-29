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
        User user = new User();
        public ListRegistration(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void LoadControl()
        {
            cbbClass.DataSource = context.Classes.ToList();
            cbbClass.ValueMember = "ID";
            cbbClass.DisplayMember = "Name";
        }

        public bool check()
        {
            double test = 0;
            if (double.TryParse(txtIdentity.Text, out test) == false)
            {
                MessageBox.Show("format identity card number incorrect"); return false;
            }
            if (double.TryParse(txtPhone.Text, out test) == false)
            {
                MessageBox.Show("phone number format is not correct"); return false;
            }
            if (txtAddress.Text == "" || txtJobFather.Text == "" || txtJobMother.Text == "" || txtNameFather.Text == "" || txtNameMother.Text == "" || txtStudentName.Text == "")
            {
                MessageBox.Show("Enter full information");
                return false;
            }
            else return true;
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
            rf.ID_Class = Convert.ToInt32(cbbClass.SelectedValue);
            rf.NameFather = txtNameFather.Text;
            rf.BirthDayOfFather = dateBirthFather.Value;
            rf.JobOfFather = txtJobFather.Text;
            rf.NameMother = txtNameMother.Text;
            rf.BirthDayOfMother = dateBirthMother.Value;
            rf.JobOfMother = txtJobMother.Text;
            rf.Email = user.Email;
            return rf;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                try
                {
                    RegistrationForm tg = GetByForm();
                    var regis = context.RegistrationForms.Where(p => p.Email == tg.Email).FirstOrDefault();
                    if (regis != null) { MessageBox.Show("This student has registered"); }
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
