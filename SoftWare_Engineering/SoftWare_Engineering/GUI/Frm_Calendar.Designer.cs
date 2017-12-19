namespace SoftWare_Engineering.GUI
{
    partial class Frm_Calendar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.cbbDormitory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCalendar = new DevExpress.XtraGrid.GridControl();
            this.griCalendar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AllowDrop = true;
            this.groupControl1.Controls.Add(this.cbbStaff);
            this.groupControl1.Controls.Add(this.cbbDormitory);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(306, 463);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Information ";
            // 
            // cbbStaff
            // 
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(81, 136);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(178, 21);
            this.cbbStaff.TabIndex = 12;
            // 
            // cbbDormitory
            // 
            this.cbbDormitory.FormattingEnabled = true;
            this.cbbDormitory.Location = new System.Drawing.Point(81, 42);
            this.cbbDormitory.Name = "cbbDormitory";
            this.cbbDormitory.Size = new System.Drawing.Size(178, 21);
            this.cbbDormitory.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Output";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(81, 89);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(178, 21);
            this.date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormitory";
            // 
            // gridCalendar
            // 
            this.gridCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCalendar.Location = new System.Drawing.Point(306, 0);
            this.gridCalendar.MainView = this.griCalendar;
            this.gridCalendar.Name = "gridCalendar";
            this.gridCalendar.Size = new System.Drawing.Size(548, 462);
            this.gridCalendar.TabIndex = 12;
            this.gridCalendar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griCalendar});
            // 
            // griCalendar
            // 
            this.griCalendar.GridControl = this.gridCalendar;
            this.griCalendar.Name = "griCalendar";
            this.griCalendar.OptionsFind.AlwaysVisible = true;
            this.griCalendar.OptionsView.ShowGroupPanel = false;
            // 
            // Frm_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 463);
            this.Controls.Add(this.gridCalendar);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridCalendar;
        private DevExpress.XtraGrid.Views.Grid.GridView griCalendar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.ComboBox cbbDormitory;
    }
}