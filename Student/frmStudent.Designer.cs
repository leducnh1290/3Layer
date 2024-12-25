namespace Student
{
    partial class frmStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.grpStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.lblStudentID);
            this.grpStudentInfo.Controls.Add(this.lblFullName);
            this.grpStudentInfo.Controls.Add(this.lblFaculty);
            this.grpStudentInfo.Controls.Add(this.lblGPA);
            this.grpStudentInfo.Controls.Add(this.txtStudentID);
            this.grpStudentInfo.Controls.Add(this.txtFullName);
            this.grpStudentInfo.Controls.Add(this.txtGPA);
            this.grpStudentInfo.Controls.Add(this.cboFaculty);
            this.grpStudentInfo.Controls.Add(this.btnAddUpdate);
            this.grpStudentInfo.Controls.Add(this.btnDelete);
            this.grpStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(300, 300);
            this.grpStudentInfo.TabIndex = 0;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Thông Tin Sinh Viên";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(10, 30);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 20);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "Mã Sinh Viên";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(10, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 20);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Họ Tên";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(10, 110);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(46, 20);
            this.lblFaculty.TabIndex = 9;
            this.lblFaculty.Text = "Khoa";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(10, 150);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(127, 20);
            this.lblGPA.TabIndex = 10;
            this.lblGPA.Text = "Điểm Trung Bình";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(100, 30);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(180, 26);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(100, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 26);
            this.txtFullName.TabIndex = 2;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(100, 150);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(180, 26);
            this.txtGPA.TabIndex = 4;
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(100, 110);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(180, 28);
            this.cboFaculty.TabIndex = 3;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(40, 200);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnAddUpdate.TabIndex = 5;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(330, 12);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(663, 300);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(330, 330);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(208, 24);
            this.chkUnregisterMajor.TabIndex = 2;
            this.chkUnregisterMajor.Text = "Chưa ĐK Chuyên Ngành";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.Click += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // frmStudent
            // 
            this.ClientSize = new System.Drawing.Size(1005, 400);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.grpStudentInfo);
            this.Name = "frmStudent";
            this.Text = "Quản Lý Sinh Viên";
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblGPA;
    }
}
