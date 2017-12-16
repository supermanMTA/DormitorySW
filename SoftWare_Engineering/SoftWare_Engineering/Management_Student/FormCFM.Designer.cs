namespace SoftWare_Engineering.Management_Student
{
    partial class FormCFM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridF = new DevExpress.XtraGrid.GridControl();
            this.gridFaculty = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddressFaculty = new System.Windows.Forms.TextBox();
            this.txtNameFaculty = new System.Windows.Forms.TextBox();
            this.txtIDFaculty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridC = new DevExpress.XtraGrid.GridControl();
            this.gridClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddClass = new System.Windows.Forms.ToolStripButton();
            this.btnEditClass = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteClass = new System.Windows.Forms.ToolStripButton();
            this.btnSaveClass = new System.Windows.Forms.ToolStripButton();
            this.btnCancelClass = new System.Windows.Forms.ToolStripButton();
            this.btnExitClass = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameClass = new System.Windows.Forms.TextBox();
            this.txtIDClass = new System.Windows.Forms.TextBox();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaculty)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 316);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridF);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Faculty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridF
            // 
            this.gridF.Location = new System.Drawing.Point(344, 62);
            this.gridF.MainView = this.gridFaculty;
            this.gridF.Name = "gridF";
            this.gridF.Size = new System.Drawing.Size(393, 200);
            this.gridF.TabIndex = 92;
            this.gridF.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFaculty});
            // 
            // gridFaculty
            // 
            this.gridFaculty.GridControl = this.gridF;
            this.gridFaculty.Name = "gridFaculty";
            this.gridFaculty.OptionsFind.AlwaysVisible = true;
            this.gridFaculty.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridFaculty_FocusedRowChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.BtnDelete,
            this.btnSave,
            this.btnCancel,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(383, 27);
            this.toolStrip1.TabIndex = 91;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::SoftWare_Engineering.Properties.Resources.add_1_icon;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::SoftWare_Engineering.Properties.Resources.Actions_document_edit_icon;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 24);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::SoftWare_Engineering.Properties.Resources.delete_icon;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(73, 24);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SoftWare_Engineering.Properties.Resources._04_download_128;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::SoftWare_Engineering.Properties.Resources.Cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 24);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::SoftWare_Engineering.Properties.Resources.Close_icon1;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 24);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddressFaculty);
            this.groupBox1.Controls.Add(this.txtNameFaculty);
            this.groupBox1.Controls.Add(this.txtIDFaculty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information ";
            // 
            // txtAddressFaculty
            // 
            this.txtAddressFaculty.Location = new System.Drawing.Point(114, 149);
            this.txtAddressFaculty.Name = "txtAddressFaculty";
            this.txtAddressFaculty.Size = new System.Drawing.Size(210, 24);
            this.txtAddressFaculty.TabIndex = 5;
            // 
            // txtNameFaculty
            // 
            this.txtNameFaculty.Location = new System.Drawing.Point(114, 91);
            this.txtNameFaculty.Name = "txtNameFaculty";
            this.txtNameFaculty.Size = new System.Drawing.Size(216, 24);
            this.txtNameFaculty.TabIndex = 4;
            // 
            // txtIDFaculty
            // 
            this.txtIDFaculty.Enabled = false;
            this.txtIDFaculty.Location = new System.Drawing.Point(114, 39);
            this.txtIDFaculty.Name = "txtIDFaculty";
            this.txtIDFaculty.Size = new System.Drawing.Size(210, 24);
            this.txtIDFaculty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridC);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Class";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridC
            // 
            this.gridC.Location = new System.Drawing.Point(356, 51);
            this.gridC.MainView = this.gridClass;
            this.gridC.Name = "gridC";
            this.gridC.Size = new System.Drawing.Size(378, 228);
            this.gridC.TabIndex = 93;
            this.gridC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridClass});
            // 
            // gridClass
            // 
            this.gridClass.GridControl = this.gridC;
            this.gridClass.Name = "gridClass";
            this.gridClass.OptionsFind.AlwaysVisible = true;
            this.gridClass.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridClass_FocusedRowChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddClass,
            this.btnEditClass,
            this.btnDeleteClass,
            this.btnSaveClass,
            this.btnCancelClass,
            this.btnExitClass});
            this.toolStrip2.Location = new System.Drawing.Point(6, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(383, 27);
            this.toolStrip2.TabIndex = 92;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Image = global::SoftWare_Engineering.Properties.Resources.add_1_icon;
            this.btnAddClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(57, 24);
            this.btnAddClass.Text = "Add";
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.Image = global::SoftWare_Engineering.Properties.Resources.Actions_document_edit_icon;
            this.btnEditClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(55, 24);
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Image = global::SoftWare_Engineering.Properties.Resources.delete_icon;
            this.btnDeleteClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(73, 24);
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Enabled = false;
            this.btnSaveClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClass.Image = global::SoftWare_Engineering.Properties.Resources._04_download_128;
            this.btnSaveClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(60, 24);
            this.btnSaveClass.Text = "Save";
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Enabled = false;
            this.btnCancelClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Image = global::SoftWare_Engineering.Properties.Resources.Cancel;
            this.btnCancelClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(73, 24);
            this.btnCancelClass.Text = "Cancel";
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // btnExitClass
            // 
            this.btnExitClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitClass.Image = global::SoftWare_Engineering.Properties.Resources.Close_icon1;
            this.btnExitClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExitClass.Name = "btnExitClass";
            this.btnExitClass.Size = new System.Drawing.Size(53, 24);
            this.btnExitClass.Text = "Exit";
            this.btnExitClass.Click += new System.EventHandler(this.btnExitClass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameClass);
            this.groupBox2.Controls.Add(this.txtIDClass);
            this.groupBox2.Controls.Add(this.cbbFaculty);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information ";
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(102, 97);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(223, 24);
            this.txtNameClass.TabIndex = 7;
            // 
            // txtIDClass
            // 
            this.txtIDClass.Enabled = false;
            this.txtIDClass.Location = new System.Drawing.Point(102, 36);
            this.txtIDClass.Name = "txtIDClass";
            this.txtIDClass.Size = new System.Drawing.Size(223, 24);
            this.txtIDClass.TabIndex = 6;
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Location = new System.Drawing.Point(102, 163);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(223, 26);
            this.cbbFaculty.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Faculty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Class ID";
            // 
            // FormCFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCFM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCFM";
            this.Load += new System.EventHandler(this.FormCFM_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaculty)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddressFaculty;
        private System.Windows.Forms.TextBox txtNameFaculty;
        private System.Windows.Forms.TextBox txtIDFaculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddClass;
        private System.Windows.Forms.ToolStripButton btnEditClass;
        private System.Windows.Forms.ToolStripButton btnDeleteClass;
        private System.Windows.Forms.ToolStripButton btnSaveClass;
        private System.Windows.Forms.ToolStripButton btnCancelClass;
        private System.Windows.Forms.ToolStripButton btnExitClass;
        private System.Windows.Forms.TextBox txtNameClass;
        private System.Windows.Forms.TextBox txtIDClass;
        private DevExpress.XtraGrid.GridControl gridF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFaculty;
        private DevExpress.XtraGrid.GridControl gridC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridClass;
    }
}