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
using SoftWare_Engineering.Report;
using SoftWare_Engineering.Management_Student;

namespace SoftWare_Engineering.GUI
{
    public partial class StudentForm : Form
    {
        MyContext context = new MyContext();
        bool ok = true;

        #region Load DL
        public StudentForm()
        {
            InitializeComponent();
        }
        
        private void LoadDgvStudent()
        {
            var dbST = from p in context.Students
                       select new
                       {
                           ID = p.ID,
                           Name = p.Name,
                           Gender = p.Gender,
                           Object = p.Object,
                           Address = p.Address,
                           Telephone = p.PhoneNumber,
                           Identity_Card = p.IdentityCard,
                         //  ClassName = context.Classes.Where(z => z.ID == p.ID).FirstOrDefault().Name,
                           IDClass=p.Class_ID,
                           room_ID = p.Room_ID,
                           Birthday = p.DateOfBirth,
                           Nation = p.Nation,
                           Religion = p.Religion,
                           Email=p.Email
                       };
            gridStudnet.DataSource = dbST.ToList();
        }
        
        private void LoadControl()
        {
            cbbClass.DataSource = context.Classes.ToList();
            cbbClass.ValueMember = "ID";
            cbbClass.DisplayMember = "Name";

            //   cbbRoom.DataSource = context.Rooms.Where(p=>p.Number<p.MaxNumber).ToList();
            cbbRoom.DataSource = context.Rooms.ToList();
            cbbRoom.ValueMember = "ID";
            cbbRoom.DisplayMember = "ID";
        }

        private void LoadRelative()
        {
            int id = Convert.ToInt32(gridStudent.GetFocusedRowCellValue("ID").ToString());
            var ListRelative = from p in context.Relatives.Where(p => p.ID_Student == id)
                               select new
                               {
                                   StudentID = p.ID_Student,
                                   RelativeName = p.Name,
                                   JobOfRelative = p.Job,
                                   Relationship=p.Relationship
                               };
            dgvRelative.DataSource = ListRelative.ToList();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            //if (id == true)
            //{
                LoadControl();
                LoadDgvStudent();
            //}
            //else
            //{
            //    LoadDgvStudent();
            //    RegistrationForm tg = new RegistrationForm();
            //    tg = context.RegistrationForms.Find(idRegistration);
            //    txtAddress.Text = tg.Address;
            //    txtIdentity.Text = tg.IdentityCard;
            //    txtPhone.Text = tg.PhoneNumber;
            //    txtName.Text = tg.Name;
            //    cbbGender.Text = tg.Gender;
            //    cbbNation.Text = tg.Nation;
            //    cbbObject.Text = tg.Object;
            //    cbbClass.Text = context.Classes.Where(p => p.ID == tg.ID_Class).FirstOrDefault().Name;
            //    cbbReligion.Text = tg.Religion;
            //    dateTimeDOB.Text = tg.DateOfBirth.ToString();
            //    int idroom = context.TypeRooms.Where(p => p.Name == tg.Gender).FirstOrDefault().ID;
            //    cbbRoom.DataSource = context.Rooms.Where(p => p.ID_TypeR == idroom).ToList();
            //}
        }
        #endregion

        #region Lấy DL
        private Student getStudentByForm(Student st)
        {
            st.Address = txtAddress.Text;
            st.Room_ID = (int)cbbRoom.SelectedValue;
            st.Gender = cbbGender.Text;
            st.Class_ID = (int)cbbClass.SelectedValue;
            st.Name = txtName.Text;
            st.Nation = cbbNation.Text;
            st.Religion = cbbReligion.Text;
            st.Object = cbbObject.Text;
            st.IdentityCard = txtIdentity.Text;
            st.DateOfBirth = dateTimeDOB.Value;
            st.PhoneNumber = txtPhone.Text;
            return st;
        }

        private Relative getRelativeByForm(Relative Re)
        {
            int id = Convert.ToInt32(gridStudent.GetFocusedRowCellValue("ID").ToString());
            Re.ID_Student = id;
            Re.Job = txtJob.Text;
            Re.Name = txtNameRelative.Text;
            Re.Relationship = txtRelationship.Text;
            return Re;
        }
        #endregion

        #region Sự kiện
        private void gridStudent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridStudent.FocusedRowHandle >= 0)
            {
                try
                {
                    int id =Convert.ToInt32( gridStudent.GetFocusedRowCellValue("IDClass").ToString());
                    txtID.Text = gridStudent.GetFocusedRowCellValue("ID").ToString();
                    if (gridStudent.GetFocusedRowCellValue("Address").ToString() != null)
                        txtAddress.Text = (string)gridStudent.GetFocusedRowCellValue("Address");
                    cbbGender.Text = (string)gridStudent.GetFocusedRowCellValue("Gender");
                    cbbObject.Text = (string)gridStudent.GetFocusedRowCellValue("Object");
                    txtName.Text = (string)gridStudent.GetFocusedRowCellValue("Name");
                    if (gridStudent.GetFocusedRowCellValue("Identity_Card") != null)
                        txtIdentity.Text = (string)gridStudent.GetFocusedRowCellValue("Identity_Card");
                    if (gridStudent.GetFocusedRowCellValue("Telephone") != null)
                        txtPhone.Text = (string)gridStudent.GetFocusedRowCellValue("Telephone");
                    cbbNation.Text = (string)gridStudent.GetFocusedRowCellValue("Nation");
                    cbbReligion.Text = (string)gridStudent.GetFocusedRowCellValue("Religion");
                    var cl = context.Classes.Find(id).Name;
                    cbbClass.Text = cl;
                    cbbRoom.Text = gridStudent.GetFocusedRowCellValue("room_ID").ToString();
                    dateTimeDOB.Text = gridStudent.GetFocusedRowCellValue("Birthday").ToString();
                    LoadRelative();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BarAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //groupControl1.Enabled = true;
            ////txtAddress.Clear();
            ////txtIdentity.Clear();
            ////txtName.Clear();
            ////txtPhone.Clear();
            ////txtID.Clear();
            //barEdit.Enabled = false;
            //barDelete.Enabled = false;
            //BarAdd.Enabled = false;
            //barSave.Enabled = true;
            //barCancel.Enabled = true;
            //ok = true;
           
            ListRegister list = new ListRegister();
            list.Show();
          
        }

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                try
                {
                    int id = (int)gridStudent.GetFocusedRowCellValue("ID");
                    Student tg = context.Students.Find(id);
                    getStudentByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    Student_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            barEdit.Enabled = true;
            BarNew.Enabled = true;
            barDelete.Enabled = true;
            BarAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupControl1.Enabled = true;
            barEdit.Enabled = false;
            BarNew.Enabled = false;
            barDelete.Enabled = false;
            BarAdd.Enabled = false;
            barSave.Enabled = true;
            barCancel.Enabled = true;
           
        }

        private void barCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Student_Load(sender, e);
            barEdit.Enabled = true;
            BarNew.Enabled = true;
            barDelete.Enabled = true;
            BarAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void barDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Student");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        int id = (int)gridStudent.GetFocusedRowCellValue("ID");
                        Student st = context.Students.Find(id);
                        context.Students.Remove(st);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoadDgvStudent();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCompliment_Click(object sender, EventArgs e)
        {
            int id = (int)gridStudent.GetFocusedRowCellValue("ID");
            Compliment_M compliment = new Compliment_M(id);
            compliment.ShowDialog();
        }

        private void btnDiscipline_Click(object sender, EventArgs e)
        {
            int id = (int)gridStudent.GetFocusedRowCellValue("ID");
            Discipline_M discipline = new Discipline_M(id);
            discipline.ShowDialog();
        }

        private void barCFM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCFM cfm = new FormCFM();
            cfm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRelationship.Clear();
            txtJob.Clear();
            txtNameRelative.Clear();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtNameRelative.Text == "")
            {
                MessageBox.Show("Choose Relation");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this Relative?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        int id = (int)gridStudent.GetFocusedRowCellValue("ID");
                        string name = gridStudent.GetFocusedRowCellValue("RelativeName").ToString();
                        Relative tg = context.Relatives.Find(id,name);
                        context.Relatives.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoadDgvStudent();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    Relative tg = new Relative();
                    getRelativeByForm(tg);
                    context.Relatives.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    // Student_Load(sender, e);
                    LoadRelative();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    int id = (int)gridStudent.GetFocusedRowCellValue("ID");
                    string name= gridStudent.GetFocusedRowCellValue("RelativeName").ToString();
                    Relative tg = context.Relatives.Find(name,id);
                    getRelativeByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    LoadRelative();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadRelative();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void dgvRelative_SelectionChanged(object sender, EventArgs e)
        {
            txtJob.Text= dgvRelative.CurrentRow.Cells["JobOfRelative"].Value.ToString();
            txtNameRelative.Text= dgvRelative.CurrentRow.Cells["RelativeName"].Value.ToString();
            txtRelationship.Text= dgvRelative.CurrentRow.Cells["Relationship"].Value.ToString();
        }

        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Student_Load(sender, e);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            int id = (int)gridStudent.GetFocusedRowCellValue("ID");
            Contract_Report contract = new Contract_Report(id);
            contract.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract_M contract = new Contract_M();
            contract.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StudentReport report = new StudentReport(2);
            report.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StudentReport report = new StudentReport(1);
            report.Show();
        }

        #endregion

    }
}
