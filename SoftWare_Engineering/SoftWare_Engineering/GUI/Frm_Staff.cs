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
using SoftWare_Engineering.Report;
namespace SoftWare_Engineering.GUI
{
    public partial class Frm_Staff : Form
    {
        MyContext context = new MyContext();
        bool ok = true;
        public Frm_Staff()
        {
            InitializeComponent();
        }
        #region Load DL
        private void LoaddgvStaff()
        {
            var list = from p in context.Staffs
                       select new
                       {
                           ID=p.ID,
                           StaffName=p.Name,
                           Nation=p.Nation,
                           Religion=p.Religion,
                           DateOfBirth=p.DateOfBirth,
                           Address=p.Address,
                           PhoneNumber=p.PhoneNumber,
                           Email=p.Email
                       };
            gridStaff.DataSource = list.ToList();
        }

        private void Frm_Staff_Load(object sender, EventArgs e)
        {
            LoaddgvStaff();
        }
        #endregion
        #region Lấy DL
        private Staff GetStaffByForm(Staff sf)
        {
          //  Staff sf = new Staff();
            sf.Name = txtName.Text;
            sf.PhoneNumber = txtPhone.Text;
            sf.Nation = cbbNation.Text;
            sf.Religion = cbbReligion.Text;
            sf.DateOfBirth = dtStaff.Value;
            sf.Address = txtAddress.Text;
            sf.Email = txtEmail.Text;
            sf.Pass = txtPass.Text;
            return sf;
        }
        #endregion
        #region Sự kiện của nhân viên
        /// <summary>
        /// Chi tiết nhân viên
        /// </summary>
        /// <returns></returns>
        private void griStaff_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (griStaff.FocusedRowHandle >= 0)
            {
                try
                {
                    txtID.Text = griStaff.GetFocusedRowCellValue("ID").ToString();
                    txtName.Text = griStaff.GetFocusedRowCellValue("StaffName").ToString();
                    txtPhone.Text = griStaff.GetFocusedRowCellValue("PhoneNumber").ToString();
                    txtAddress.Text = griStaff.GetFocusedRowCellValue("Address").ToString();
                    cbbNation.Text = griStaff.GetFocusedRowCellValue("Nation").ToString();
                    cbbReligion.Text = griStaff.GetFocusedRowCellValue("Religion").ToString();
                    dtStaff.Text = griStaff.GetFocusedRowCellValue("DateOfBirth").ToString();
                    txtEmail.Text= griStaff.GetFocusedRowCellValue("Email").ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barAdd.Enabled = false;
            barEdit.Enabled = false;
            barDelete.Enabled = false;
            barSave.Enabled = true;
            barCancel.Enabled = true;
            txtAddress.Clear();
            txtName.Clear();
            txtPhone.Clear();
            groupControl1.Enabled = true;
            ok = true;
        }
        /// <summary>
        /// lưu dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ok == true)
            {
                try
                {
                    Staff tg = new Staff();
                    GetStaffByForm(tg);
                    context.Staffs.Add(tg);
                    context.SaveChanges();
                    User user = new User();
                    user.Email = tg.Email;
                    user.Pass = tg.Pass;
                    user.Object = 1;
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    LoaddgvStaff();
                    barEdit.Enabled = true;
                    barDelete.Enabled = true;
                    barAdd.Enabled = true;
                    barSave.Enabled = false;
                    barCancel.Enabled = false;
                   
                    groupControl1.Enabled = false;
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
                    int id = (int)griStaff.GetFocusedRowCellValue("ID");
                    Staff tg = context.Staffs.Where(p => p.ID == id).FirstOrDefault();
                     GetStaffByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    LoaddgvStaff();
                    barEdit.Enabled = true;
                    barDelete.Enabled = true;
                    barAdd.Enabled = true;
                    barSave.Enabled = false;
                    barCancel.Enabled = false;
                    txtEmail.Enabled = true;
                    txtPass.Enabled = true;
                    groupControl1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
        /// <summary>
        /// Sửa nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barAdd.Enabled = false;
            barEdit.Enabled = false;
            barDelete.Enabled = false;
            barSave.Enabled = true;
            barCancel.Enabled = true;
            txtEmail.Enabled = false;
            txtPass.Enabled = false;
            ok =false;
            groupControl1.Enabled = true;
        }
        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose Staff");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this staff?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        int id = (int)griStaff.GetFocusedRowCellValue("ID");
                        var tg = context.Staffs.Find(id);
                        context.Staffs.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvStaff();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void barCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Staff_Load(sender, e);
            barEdit.Enabled = true;
            barDelete.Enabled = true;
            barAdd.Enabled = true;
            barSave.Enabled = false;
            barCancel.Enabled = false;
        }
        /// <summary>
        /// Danh sách nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Staff_Report report = new Staff_Report();
            report.Show();
        }
        #endregion

        private void btnCalendar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Calendar calendar = new Frm_Calendar();
            calendar.Show();
        }
    }
}
