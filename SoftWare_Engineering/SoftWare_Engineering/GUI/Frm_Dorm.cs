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
using SoftWare_Engineering.Dorm;
namespace SoftWare_Engineering.GUI
{
    public partial class Frm_Dorm : Form
    {
        MyContext context = new MyContext();
        bool ok = true;
        public Frm_Dorm()
        {
            InitializeComponent();
        }
        #region Load
        private void LoaddgvDorm()
        {
            var list = from p in context.Rooms
                       select new
                       {
                           ID = p.ID,
                           NumberStudent = p.Number,
                           MaxNumber = p.MaxNumber,
                           DormitoryName = context.Dormitories.Where(z => z.ID == p.ID_Dormitori).FirstOrDefault().Name,
                           TypeRoom = context.TypeRooms.Where(z => z.ID == p.ID_TypeR).FirstOrDefault().Name
                       };
            gridDorm.DataSource = list.ToList();
        }
        private void LoadControl()
        {
            var ListDorm = context.Dormitories.ToList();
            cbbDorm.DataSource = ListDorm;
            cbbDorm.ValueMember = "ID";
            cbbDorm.DisplayMember = "Name";

            cbbTypeRoom.DataSource = context.TypeRooms.ToList();
            cbbTypeRoom.ValueMember = "ID";
            cbbTypeRoom.DisplayMember = "Name";
        }
        private void LoadStudentOfRoom()
        {
            int i = 0;
            int id = (int)griDorm.GetFocusedRowCellValue("ID");
            var list = context.Students.Where(p => p.Room_ID == id).ToList()
                .Select(p => new
                {
                    STT = ++i,
                    StudentID = p.ID,
                    StudentName = p.Name
                }).ToList();
            dgvStudent.DataSource = list;
        }
        private void Frm_Dorm_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoaddgvDorm();
        }
        #endregion
        #region Lấy dữ liệu từ form
        private Room GetRoomByForm()
        {
            Room r = new Room();
            r.ID_Dormitori =(int) cbbDorm.SelectedValue;
            r.ID_TypeR = (int)cbbTypeRoom.SelectedValue;
            r.MaxNumber =Convert.ToInt32( txtMaxNumber.Text);
            r.Number = Convert.ToInt32( txtNumber.Text);
            return r;
        }
        #endregion
        #region Sự kiện của room
        private void griDorm_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (griDorm.FocusedRowHandle >= 0)
            {
                try
                {
                    txtID.Text = griDorm.GetFocusedRowCellValue("ID").ToString();
                    txtMaxNumber.Text = griDorm.GetFocusedRowCellValue("MaxNumber").ToString();
                    txtNumber.Text = griDorm.GetFocusedRowCellValue("NumberStudent").ToString();
                    cbbDorm.Text = griDorm.GetFocusedRowCellValue("DormitoryName").ToString();
                    cbbTypeRoom.Text = griDorm.GetFocusedRowCellValue("TypeRoom").ToString();
                    LoadStudentOfRoom();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            barAdd.Enabled = false;
            barEdit.Enabled = false;
            barDelete.Enabled = false;
            barSave.Enabled = true;
            barCancel.Enabled = true;
            txtMaxNumber.Clear();
            txtNumber.Clear();
            ok = true;
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barAdd.Enabled = false;
            barEdit.Enabled = false;
            barDelete.Enabled = false;
            barSave.Enabled = true;
            barCancel.Enabled = true;
            ok = false;
        }

        private void barDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)griDorm.GetFocusedRowCellValue("ID");
            var listST = context.Students.Where(p => p.Room_ID == id).FirstOrDefault();
            if (listST != null)
            {
                MessageBox.Show("This room does not empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want delete this room?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        // int id = (int)griDorm.GetFocusedRowCellValue("ID");
                        Room tg = context.Rooms.Find(id);
                        context.Rooms.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvDorm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
        }

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    Room tg = new Room();
                    tg = GetRoomByForm();
                    context.Rooms.Add(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    LoaddgvDorm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    int id = (int)griDorm.GetFocusedRowCellValue("ID");
                    Room tg = context.Rooms.Where(p => p.ID == id).FirstOrDefault();
                    tg = GetRoomByForm();
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    LoaddgvDorm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            barEdit.Enabled = true;
            barDelete.Enabled = true;
            barAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
        }

        private void barCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Dorm_Load(sender,e);
            barEdit.Enabled = true;
            barDelete.Enabled = true;
            barAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( griDorm.GetFocusedRowCellValue("ID").ToString());
            Bill_M bill = new Bill_M(id);
            bill.ShowDialog();
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString());
            Assessment ass = new Assessment(id);
            ass.ShowDialog();
        }
        #endregion
    }
}
