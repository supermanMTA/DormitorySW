﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftWare_Engineering.Data;

namespace SoftWare_Engineering.GUI
{
    public partial class Frm_Calendar : Form
    {
        MyContext context = new MyContext();
        public Frm_Calendar()
        {
            
            InitializeComponent();
            
        }

        public void LoadDL()
        {
            gridCalendar.DataSource = from p in context.Calendars.ToList()
                                      select new
                                      {
                                          Day = p.Day,
                                          DormitoryID=p.Dormitory,
                                          Dormitory = context.Dormitories.Where(z => z.ID == p.Dormitory).FirstOrDefault().Name,
                                          StaffID=p.ID_Staff,
                                          Staff = context.Staffs.Where(z => z.ID == p.ID_Staff).FirstOrDefault().Name
                                           
                                      };
        }
        public void LoadControl()
        {
            cbbDormitory.DataSource = context.Dormitories.ToList();
            cbbDormitory.ValueMember = "ID";
            cbbDormitory.DisplayMember = "Name";

            
            
            var list = context.Staffs.ToList()
               .Select(p => new
               {                  
                   ID = p.ID,
                   Name = p.Name
               }).ToList();
            gridLookUpStaff.Properties.DataSource = list;
            gridLookUpStaff.Properties.ValueMember = "ID";
            gridLookUpStaff.Properties.DisplayMember = "Name";
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Day = date.Value;
            calendar.Dormitory =(int) cbbDormitory.SelectedValue;
            calendar.ID_Staff = (int)gridLookUpStaff.EditValue;
            var test = context.Calendars.Where(p => p.Day == calendar.Day && p.ID_Staff == calendar.ID_Staff).FirstOrDefault();
            var test2 = context.Calendars.Where(p => p.Day == calendar.Day && p.Dormitory == calendar.Dormitory).FirstOrDefault();
            if ( test!= null)
            {
                MessageBox.Show("Existed");
            }
            else if (test2 != null) { MessageBox.Show("Existed "); }
            else
            {
                context.Calendars.Add(calendar);
                context.SaveChanges();
                Calendar_Load(sender, e);
            }
           
        }       
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Excel |*.xls";
            savefile.Title = "Save with excel ";
            savefile.ShowDialog();
            string filename = savefile.FileName.ToString();
            try
            {
                gridCalendar.ExportToXls(filename);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                var calendar = context.Calendars.Where(p => p.Day == date.Value && p.Dormitory == (int)cbbDormitory.SelectedValue).FirstOrDefault();
                calendar.ID_Staff = Convert.ToInt32(gridLookUpStaff.EditValue);
                var test = context.Calendars.Where(p => p.Day == calendar.Day && p.ID_Staff == calendar.ID_Staff).FirstOrDefault();
                if (test != null) { MessageBox.Show("Existed"); }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("done");
                    Calendar_Load(sender, e);
                }
               
            }
            catch
            {

            }

        }

        private void griCalendar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cbbDormitory.SelectedValue =Convert.ToInt32( griCalendar.GetFocusedRowCellValue("DormitoryID"));
            date.Text =griCalendar.GetFocusedRowCellValue("Day").ToString();
            gridLookUpStaff.EditValue = Convert.ToInt32(griCalendar.GetFocusedRowCellValue("StaffID"));
        }
    }
}
