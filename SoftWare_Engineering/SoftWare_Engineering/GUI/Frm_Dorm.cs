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
                           Name = p.Name,
                           NumberStudent = p.Number,
                           MaxNumber = p.MaxNumber,
                           DormitoryName = context.Dormitories.Where(z => z.ID == p.ID_Dormitori).FirstOrDefault().Name,
                           TypeRoom = context.TypeRooms.Where(z => z.ID == p.ID_TypeR).FirstOrDefault().Name,
                           Status = p.Status == true ? "Sử dụng" : "Không sử dụng"
                       };
            gridDorm.DataSource = list.ToList();
        }

        public void LoadAssets(int id)
        {
            var assets = context.Assets.Find(id);
            txtBed.Text = assets.Bed.ToString();
            txtFan.Text = assets.Fan.ToString();
            txtCabinets.Text = assets.Cabinets.ToString();
            txtLights.Text = assets.Lights.ToString();
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

        #region Lấy và ktr dữ liệu từ form
        private Room GetRoomByForm(Room r)
        {

            r.Name = txtRoomName.Text;
            r.ID_Dormitori = (int)cbbDorm.SelectedValue;
            r.ID_TypeR = (int)cbbTypeRoom.SelectedValue;
            r.MaxNumber = Convert.ToInt32(txtMaxNumber.Text);
            r.Number = Convert.ToInt32(txtNumber.Text);
            if (checkbox1.Checked == true) r.Status = true;
            else r.Status = false;
            return r;
        }

        public bool check()
        {
            int test = 0;
            if (Int32.TryParse(txtMaxNumber.Text, out test) == false)
            {
                MessageBox.Show("Incorrect format");
                return false;
            }
            if (Int32.TryParse(txtNumber.Text, out test) == false)
            {
                MessageBox.Show("Incorrect format");
                return false;
            }
            else return true;
        }
        public bool checkAssets()
        {
            int test = 0;
            if (int.TryParse(txtBed.Text, out test) == false)
            {
                MessageBox.Show("Wrong format");
                return false;
            }
            else if (int.TryParse(txtFan.Text, out test) == false)
            {
                MessageBox.Show("Wrong format");
                return false;
            }
            else if (int.TryParse(txtLights.Text, out test) == false)
            {

                MessageBox.Show("Wrong format");
                return false;
            }
            else if (int.TryParse(txtCabinets.Text, out test) == false)
            {

                MessageBox.Show("Wrong format");
                return false;
            }
            else return true;
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
                    txtRoomName.Text = griDorm.GetFocusedRowCellValue("Name").ToString();
                    txtMaxNumber.Text = griDorm.GetFocusedRowCellValue("MaxNumber").ToString();
                    txtNumber.Text = griDorm.GetFocusedRowCellValue("NumberStudent").ToString();
                    cbbDorm.Text = griDorm.GetFocusedRowCellValue("DormitoryName").ToString();
                    cbbTypeRoom.Text = griDorm.GetFocusedRowCellValue("TypeRoom").ToString();
                    if (griDorm.GetFocusedRowCellValue("Status").ToString() == "Sử dụng")
                        checkbox1.Checked = true;
                    else checkbox1.Checked = false;
                    LoadStudentOfRoom();
                    LoadAssets(Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString()));
                }
                catch (Exception ex)
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
            txtRoomName.Clear();
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
                        tg.Status = false;
                        //  context.Rooms.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvDorm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ok == true)
            {
                if (check() == true)
                {
                    try
                    {
                        Room tg = new Room();
                        GetRoomByForm(tg);
                        context.Rooms.Add(tg);
                        context.SaveChanges();
                        MessageBox.Show("Done!");
                        LoaddgvDorm();
                        barEdit.Enabled = true;
                        barDelete.Enabled = true;
                        barAdd.Enabled = true;
                        barSave.Enabled = false;
                        barCancel.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Communique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                try
                {
                    int id = (int)griDorm.GetFocusedRowCellValue("ID");
                    Room tg = context.Rooms.Where(p => p.ID == id).FirstOrDefault();
                    GetRoomByForm(tg);
                    if (tg.Status == false)
                    {
                        var listST = context.Students.Where(p => p.Room_ID == id).FirstOrDefault();
                        if (listST != null)
                        {
                            MessageBox.Show("This room does not empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            context.SaveChanges();
                            MessageBox.Show("Done!");
                            LoaddgvDorm();
                            barEdit.Enabled = true;
                            barDelete.Enabled = true;
                            barAdd.Enabled = true;
                            barSave.Enabled = false;
                            barCancel.Enabled = false;
                        }
                    }
                    else
                    {
                        context.SaveChanges();
                        MessageBox.Show("Done!");
                        LoaddgvDorm();
                        barEdit.Enabled = true;
                        barDelete.Enabled = true;
                        barAdd.Enabled = true;
                        barSave.Enabled = false;
                        barCancel.Enabled = false;

                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void barCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Dorm_Load(sender, e);
            barEdit.Enabled = true;
            barDelete.Enabled = true;
            barAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString());
            Bill_M bill = new Bill_M(id);
            bill.ShowDialog();
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString());
            Assessment ass = new Assessment(id);
            ass.ShowDialog();
        }

        private void btnEditAssets_Click(object sender, EventArgs e)
        {
            var AssetsRoom = context.Assets.Find(Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString()));
            if (AssetsRoom != null)
            {
                if (checkAssets() == true)
                {
                    AssetsRoom.Bed = Convert.ToInt32(txtBed.Text);
                    AssetsRoom.Fan = Convert.ToInt32(txtFan.Text);
                    AssetsRoom.Lights = Convert.ToInt32(txtLights.Text);
                    AssetsRoom.Cabinets = Convert.ToInt32(txtCabinets.Text);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                }

            }
            else
            {
                if (checkAssets() == true)
                {
                    var assetsRoom = new Asset();
                    assetsRoom.RoomID = Convert.ToInt32(griDorm.GetFocusedRowCellValue("ID").ToString());
                    assetsRoom.Bed = Convert.ToInt32(txtBed.Text);
                    assetsRoom.Fan = Convert.ToInt32(txtFan.Text);
                    assetsRoom.Lights = Convert.ToInt32(txtLights.Text);
                    assetsRoom.Cabinets = Convert.ToInt32(txtCabinets.Text);
                    context.Assets.Add(assetsRoom);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                }

            }


        }

        #endregion

    }
}
