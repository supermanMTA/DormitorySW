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
using SoftWare_Engineering.GUI;

namespace SoftWare_Engineering.Management_Student
{
    public partial class ListRegister : Form
    {
        MyContext context = new MyContext();
        public ListRegister()
        {
            InitializeComponent();
        }
        #region Load dữ liệu
        private void LoadStudent()
        {
            var list = from p in context.RegistrationForms
                       select new
                       {
                           ID=p.ID,
                           StudentName = p.Name,
                           DateOfBirth = dateTimeDOB.Value,
                           Gender=p.Gender,
                           Object=p.Object,
                           ClassN=p.ID_Class,
                           Address=p.Address

                       };
            gridRe.DataSource = list.ToList();
        }
        private void LoadControl()
        {
            
        }
        private void ListRegister_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }
        #endregion
        #region Sự kiện
        private void gridRegister_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtName.Text = gridRegister.GetFocusedRowCellValue("StudentName").ToString();
                cbbClass.Text = gridRegister.GetFocusedRowCellValue("ClassN").ToString();
                cbbGender.Text = gridRegister.GetFocusedRowCellValue("Gender").ToString();
                cbbObject.Text = gridRegister.GetFocusedRowCellValue("Object").ToString();
                txtAddress.Text = gridRegister.GetFocusedRowCellValue("Address").ToString();
                dateTimeDOB.Text = gridRegister.GetFocusedRowCellValue("DateOfBirth").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridRegister.GetFocusedRowCellValue("ID"));
            cbbRoom.Enabled = true;
            button2.Enabled = true;
            if (cbbGender.Text == "Nữ") {
                var list = context.Rooms.Where(p => p.ID_TypeR == 2&&p.Number<p.MaxNumber);
                cbbRoom.DataSource = list.ToList();
                cbbRoom.ValueMember = "ID";
                cbbRoom.DisplayMember = "ID";
            }
            else {
                var list = context.Rooms.Where(p => p.ID_TypeR == 1 && p.Number < p.MaxNumber);
                cbbRoom.DataSource = list.ToList();
                cbbRoom.ValueMember = "ID";
                cbbRoom.DisplayMember = "ID";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridRegister.GetFocusedRowCellValue("ID"));
                RegistrationForm RG = context.RegistrationForms.Find(id);
                Student st = new Student();
                st.Name = RG.Name;
                st.IdentityCard = RG.IdentityCard;
                st.Nation = RG.Nation;
                st.Object = RG.Object;
                st.PhoneNumber = RG.PhoneNumber;
                st.Religion = RG.Religion;
                st.Room_ID = Convert.ToInt32(cbbRoom.Text);
                st.Address = RG.Address;
                st.Class_ID = RG.ID_Class;
                st.DateOfBirth = RG.DateOfBirth;
                st.Gender = RG.Gender;
                st.Email = RG.Email;
                context.Students.Add(st);
                context.SaveChanges();
                context.RegistrationForms.Remove(RG);
                context.SaveChanges();
                MessageBox.Show("Done");              
                Room r = context.Rooms.Find(st.Room_ID);
                r.Number++;
                context.SaveChanges();
                Relative RL = new Relative();
                RL.ID_Student = st.ID;
                RL.Name = RG.NameFather;
                RL.Job = RG.JobOfFather;
                RL.Relationship = "Bố";
                context.Relatives.Add(RL);
                context.SaveChanges();
                Relative RL1 = new Relative();
                RL1.ID_Student = st.ID;
                RL1.Name = RG.NameMother;
                RL1.Job = RG.JobOfMother;
                RL1.Relationship = "Mẹ";
                context.Relatives.Add(RL1);
                context.SaveChanges();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
