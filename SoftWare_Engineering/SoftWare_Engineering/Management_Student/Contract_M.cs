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
    public partial class Contract_M : Form
    {
        MyContext context = new MyContext();
        bool ok = true;
        public Contract_M()
        {
            InitializeComponent();
        }
        #region Load dữ liệu
        private void LoadControl()
        {


            cbbStaff.Properties.DataSource = context.Staffs.ToList()
                .Select(p => new
                {
                    ID=p.ID,
                    Name=p.Name
                }).ToList();             
            cbbStaff.Properties.ValueMember = "ID";
            cbbStaff.Properties.DisplayMember = "Name";
            
            cbbStudent.Properties.DataSource = context.Students
                .Select(p=>new {
                    ID=p.ID,
                    Name=p.Name
                }).ToList();
            cbbStudent.Properties.ValueMember = "ID";
            cbbStudent.Properties.DisplayMember = "Name";

           
        }
        private void LoaddgvContract()
        {
            var listContract = from p in context.Contracts
                               select new
                               {
                                   IDOfContract = p.ID,
                                   IDOfStudent = p.ID_Student,
                                   StudentID = p.ID_Student,//context.Students.Where(z=>z.ID==p.ID_Student).FirstOrDefault().Name,
                                   IDOfStaff = p.ID_Staff,
                                   StaffID = p.ID_Staff,//context.Staffs.Where(z=>z.ID==p.ID_Staff).FirstOrDefault().Name,
                                   IDOfRoom = p.ID_Room,
                                   DateStart = p.DateStart,
                                   DateEnd = p.DateEnd,
                                   DateFound=p.DateFound,
                                   Expired = ((bool)p.Expired) ? "Hết hạn" : "Chưa hết hạn"
                               };
            gridContract.DataSource = listContract.ToList();
        }

        private void Contract_M_Load(object sender, EventArgs e)
        {
            
            LoadControl();
            LoaddgvContract();
        }
        #endregion

        #region Lấy dữ liệu
        public bool checkDL()
        {
            if (dateEnd.Value < dateStart.Value) { MessageBox.Show("date end incorrect "); return false; }
            return true;
        }
        private Contract GetContractByForm(Contract contract)
        {
            contract.ID_Student = Convert.ToInt32( cbbStudent.EditValue);
            contract.ID_Room = (int)context.Students.Find(contract.ID_Student).Room_ID;
            contract.ID_Staff = Convert.ToInt32(cbbStaff.EditValue);
            contract.DateEnd = dateEnd.Value;
            contract.DateFound = dateFound.Value;
            contract.DateStart = dateStart.Value;
            txtRoom.Text = contract.ID_Room.ToString();
            if (dateEnd.Value< DateTime.Now)
            {
                contract.Expired = true;
            }
            else contract.Expired = false;
            return contract;
        }
        #endregion

        #region Sự kiện
        private void gricontract_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gricontract.FocusedRowHandle >= 0)
            {
                try
                {
                    txtID.Text = gricontract.GetFocusedRowCellValue("IDOfContract").ToString();
                    cbbStudent.EditValue = gricontract.GetFocusedRowCellValue("StudentID").ToString();
                    cbbStaff.EditValue = gricontract.GetFocusedRowCellValue("StaffID").ToString();
                    txtRoom.Text= gricontract.GetFocusedRowCellValue("IDOfRoom").ToString();
                    dateStart.Value = (DateTime)gricontract.GetFocusedRowCellValue("DateStart");
                    dateEnd.Value = (DateTime)gricontract.GetFocusedRowCellValue("DateEnd");
                    dateFound.Value = (DateTime)gricontract.GetFocusedRowCellValue("DateFound");
                    if (dateEnd.Value < DateTime.Now)
                    {
                        check.Checked = true;
                    }
                    else { check.Checked = false; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ok = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Choose contract");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want delete this contract?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {

                    try
                    {
                        Contract tg = new Contract();
                        int id = Convert.ToInt32(txtID.Text);
                        tg = context.Contracts.Where(p => p.ID == id).FirstOrDefault();
                        context.Contracts.Remove(tg);
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        LoaddgvContract();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                    Contract tg = new Contract();
                    GetContractByForm(tg);
                    var test = context.Contracts.Where(p => p.ID_Student == tg.ID_Student).FirstOrDefault();
                    if (test != null) { MessageBox.Show("This student contract exists"); }
                    else
                    {
                        context.Contracts.Add(tg);
                        context.SaveChanges();
                        MessageBox.Show("Done");
                        LoaddgvContract();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Contract tg = new Contract();
                    int id = Convert.ToInt32(txtID.Text);
                    tg = context.Contracts.Where(p => p.ID == id).FirstOrDefault();
                    GetContractByForm(tg);
                    context.SaveChanges();
                    MessageBox.Show("Done");
                    LoaddgvContract();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoaddgvContract();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
