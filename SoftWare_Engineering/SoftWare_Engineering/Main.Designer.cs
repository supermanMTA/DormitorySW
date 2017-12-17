namespace SoftWare_Engineering
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new System.Windows.Forms.Panel();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnRegis = new DevExpress.XtraBars.BarButtonItem();
            this.bar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnDorm = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnInfor = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegistration = new DevExpress.XtraBars.BarButtonItem();
            this.barExtension = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudentM = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaffM = new DevExpress.XtraBars.BarButtonItem();
            this.btnDormM = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountM = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 143);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1296, 551);
            this.panelMain.TabIndex = 1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup10,
            this.bar});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "System";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Login";
            this.btnLogin.Id = 15;
            this.btnLogin.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.lock_open_blue;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnRegis);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // btnRegis
            // 
            this.btnRegis.Caption = "Registration";
            this.btnRegis.Id = 16;
            this.btnRegis.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Login_Registration_icon;
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRegis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegis_ItemClick);
            // 
            // bar
            // 
            this.bar.ItemLinks.Add(this.btnLogout);
            this.bar.Name = "bar";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Log out";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 17;
            this.btnLogout.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Apps_Dialog_Logout_icon;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Login";
            this.btnStudent.Id = 1;
            this.btnStudent.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Student_3_icon;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "Staff";
            this.btnStaff.Id = 5;
            this.btnStaff.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Manager_icon;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDorm
            // 
            this.btnDorm.Caption = "Dormitory";
            this.btnDorm.Id = 6;
            this.btnDorm.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.House_icon;
            this.btnDorm.Name = "btnDorm";
            this.btnDorm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAccount
            // 
            this.btnAccount.Caption = "Account";
            this.btnAccount.Id = 7;
            this.btnAccount.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.user_info_icon;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Staff";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Dormitory";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Account";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnStudent,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnStaff,
            this.btnDorm,
            this.btnAccount,
            this.btnInfor,
            this.btnRegistration,
            this.barExtension,
            this.btnStudentM,
            this.btnStaffM,
            this.btnDormM,
            this.btnAccountM,
            this.btnLogin,
            this.btnRegis,
            this.btnLogout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1296, 143);
            // 
            // btnInfor
            // 
            this.btnInfor.Caption = "My Information ";
            this.btnInfor.Enabled = false;
            this.btnInfor.Id = 8;
            this.btnInfor.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.personal_information_icon;
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Caption = "Registration";
            this.btnRegistration.Enabled = false;
            this.btnRegistration.Id = 9;
            this.btnRegistration.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.ImageOptions.Image")));
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRegistration.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegistration_ItemClick);
            // 
            // barExtension
            // 
            this.barExtension.Caption = "Extension contract";
            this.barExtension.Enabled = false;
            this.barExtension.Id = 10;
            this.barExtension.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Contract_icon;
            this.barExtension.Name = "barExtension";
            this.barExtension.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barExtension.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExtension_ItemClick);
            // 
            // btnStudentM
            // 
            this.btnStudentM.Caption = "Student";
            this.btnStudentM.Enabled = false;
            this.btnStudentM.Id = 11;
            this.btnStudentM.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Student_3_icon;
            this.btnStudentM.Name = "btnStudentM";
            this.btnStudentM.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStudentM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudentM_ItemClick);
            // 
            // btnStaffM
            // 
            this.btnStaffM.Caption = "Staff";
            this.btnStaffM.Enabled = false;
            this.btnStaffM.Id = 12;
            this.btnStaffM.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.Manager_icon;
            this.btnStaffM.Name = "btnStaffM";
            this.btnStaffM.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStaffM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaffM_ItemClick);
            // 
            // btnDormM
            // 
            this.btnDormM.Caption = "Dormitory";
            this.btnDormM.Enabled = false;
            this.btnDormM.Id = 13;
            this.btnDormM.ImageOptions.Image = global::SoftWare_Engineering.Properties.Resources.House_icon;
            this.btnDormM.Name = "btnDormM";
            this.btnDormM.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDormM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDormM_ItemClick);
            // 
            // btnAccountM
            // 
            this.btnAccountM.Caption = "Account";
            this.btnAccountM.Id = 14;
            this.btnAccountM.Name = "btnAccountM";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Student";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfor);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRegistration);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barExtension);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Manager";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnStudentM);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnStaffM);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDormM);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Help";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 694);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DORMITORY MANAGEMENT SOFTWARE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnDorm;
        private DevExpress.XtraBars.BarButtonItem btnAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnInfor;
        private DevExpress.XtraBars.BarButtonItem btnRegistration;
        private DevExpress.XtraBars.BarButtonItem barExtension;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnStudentM;
        private DevExpress.XtraBars.BarButtonItem btnStaffM;
        private DevExpress.XtraBars.BarButtonItem btnDormM;
        private DevExpress.XtraBars.BarButtonItem btnAccountM;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnRegis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup bar;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
    }
}

