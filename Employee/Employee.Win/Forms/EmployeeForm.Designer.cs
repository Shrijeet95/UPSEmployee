using System.Windows.Forms;

namespace Employee.Win.Forms
{
    partial class EmployeeForm
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
            this.gbEmployeeDetail = new System.Windows.Forms.GroupBox();
            this.lblEdId = new System.Windows.Forms.Label();
            this.lblEdName = new System.Windows.Forms.Label();
            this.lblEdEmailId = new System.Windows.Forms.Label();
            this.lblEdGender = new System.Windows.Forms.Label();
            this.lblEdStatus = new System.Windows.Forms.Label();
            this.txtEdId = new System.Windows.Forms.TextBox();
            this.txtEdName = new System.Windows.Forms.TextBox();
            this.txtEdEmailId = new System.Windows.Forms.TextBox();
            this.rbEdGenderMale = new System.Windows.Forms.RadioButton();
            this.rbEdStatusActive = new System.Windows.Forms.RadioButton();
            this.rbEdGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbEdStatusInActive = new System.Windows.Forms.RadioButton();
            this.pnGender = new System.Windows.Forms.Panel();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.btnBack= new System.Windows.Forms.Button();
            this.btnSave= new System.Windows.Forms.Button();
            this.btnUpdate= new System.Windows.Forms.Button();
            this.btnDelete= new System.Windows.Forms.Button();
            this.gbEmployeeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            //
            this.gbEmployeeDetail.Controls.Add(this.lblEdId);
            this.gbEmployeeDetail.Controls.Add(this.lblEdName);
            this.gbEmployeeDetail.Controls.Add(this.lblEdEmailId);
            this.gbEmployeeDetail.Controls.Add(this.lblEdGender);
            this.gbEmployeeDetail.Controls.Add(this.lblEdStatus);
            this.gbEmployeeDetail.Controls.Add(this.txtEdId);
            this.gbEmployeeDetail.Controls.Add(this.txtEdName);
            this.gbEmployeeDetail.Controls.Add(this.txtEdEmailId);
            this.gbEmployeeDetail.Controls.Add(this.btnSave);
            this.gbEmployeeDetail.Controls.Add(this.btnUpdate);
            this.gbEmployeeDetail.Controls.Add(this.btnDelete);
            this.gbEmployeeDetail.Controls.Add(this.btnBack);
            //this.gbEmployeeDetail.Controls.Add(this.rbEdGenderMale);
            //this.gbEmployeeDetail.Controls.Add(this.rbEdGenderFemale);
            //this.gbEmployeeDetail.Controls.Add(this.rbEdStatusActive);
            //this.gbEmployeeDetail.Controls.Add(this.rbEdStatusInActive);
            this.gbEmployeeDetail.Controls.Add(this.pnGender);
            this.gbEmployeeDetail.Controls.Add(this.pnStatus);
            this.gbEmployeeDetail.Location = new System.Drawing.Point(15, 0);
            this.gbEmployeeDetail.Name = "gbEmployeeDetail";
            //this.gbEmployeeDetail.Size = new System.Drawing.Size(776, 438);
            this.gbEmployeeDetail.Size = new System.Drawing.Size(710, 180);
            this.gbEmployeeDetail.TabIndex = 0;
            this.gbEmployeeDetail.TabStop = false;
            this.gbEmployeeDetail.Text = "Employee Detail";
            // 
            // lblId
            //
            this.lblEdId.AutoSize = true;
            this.lblEdId.Location = new System.Drawing.Point(6, 34);
            this.lblEdId.Name = "lblEdId";
            this.lblEdId.Size = new System.Drawing.Size(18, 15);
            this.lblEdId.TabIndex = 0;
            this.lblEdId.Text = "ID";
            this.lblEdId.Visible = true;
            // 
            // lblName
            //
            this.lblEdName.AutoSize = true;
            this.lblEdName.Location = new System.Drawing.Point(374, 34);
            this.lblEdName.Name = "lblName";
            this.lblEdName.Size = new System.Drawing.Size(39, 15);
            this.lblEdName.TabIndex = 1;
            this.lblEdName.Text = "Name";
            // 
            // lblEmailid
            //
            this.lblEdEmailId.AutoSize = true;
            this.lblEdEmailId.Location = new System.Drawing.Point(6, 66);
            this.lblEdEmailId.Name = "lblEmailId";
            this.lblEdEmailId.Size = new System.Drawing.Size(81, 15);
            this.lblEdEmailId.TabIndex = 2;
            this.lblEdEmailId.Text = "Email Address";
            // 
            // lblGender
            //
            this.lblEdGender.AutoSize = true;
            this.lblEdGender.Location = new System.Drawing.Point(374, 66);
            this.lblEdGender.Name = "lblGender";
            this.lblEdGender.Size = new System.Drawing.Size(45, 15);
            this.lblEdGender.TabIndex = 3;
            this.lblEdGender.Text = "Gender";
            // 
            // lblStatus
            //
            this.lblEdStatus.AutoSize = true;
            this.lblEdStatus.Location = new System.Drawing.Point(6, 101);
            this.lblEdStatus.Name = "lblStatus";
            this.lblEdStatus.Size = new System.Drawing.Size(39, 15);
            this.lblEdStatus.TabIndex = 4;
            this.lblEdStatus.Text = "Status";
            // 
            // txtEdId
            //
            this.txtEdId.Location = new System.Drawing.Point(93, 26);
            this.txtEdId.Name = "txtEdId";
            this.txtEdId.Size = new System.Drawing.Size(240, 23);
            this.txtEdId.TabIndex = 7;
            this.txtEdId.Enabled = false;
            // 
            // txtEdName
            //
            this.txtEdName.Location = new System.Drawing.Point(447, 26);
            this.txtEdName.Name = "txtEdName";
            this.txtEdName.Size = new System.Drawing.Size(240, 23);
            this.txtEdName.TabIndex = 5;
            // 
            // txtEdEmailId
            //
            this.txtEdEmailId.Location = new System.Drawing.Point(93, 58);
            this.txtEdEmailId.Name = "txtEdEmailId";
            this.txtEdEmailId.Size = new System.Drawing.Size(240, 23);
            this.txtEdEmailId.TabIndex = 5;
            // 
            // rbEdGenderMale
            //
            this.rbEdGenderMale.AutoSize = true;
            this.rbEdGenderMale.Location = new System.Drawing.Point(593, 62);
            this.rbEdGenderMale.Name = "rbGender";
            this.rbEdGenderMale.Size = new System.Drawing.Size(94, 19);
            this.rbEdGenderMale.TabIndex = 10;
            this.rbEdGenderMale.TabStop = true;
            this.rbEdGenderMale.Text = "Male";
            this.rbEdGenderMale.UseVisualStyleBackColor = true;
            this.rbEdGenderMale.Checked = true;
            // 
            // rbEdGenderFemale
            //
            this.rbEdGenderFemale.AutoSize = true;
            this.rbEdGenderFemale.Location = new System.Drawing.Point(447, 62);
            this.rbEdGenderFemale.Name = "rbGender";
            this.rbEdGenderFemale.Size = new System.Drawing.Size(94, 19);
            this.rbEdGenderFemale.TabIndex = 10;
            this.rbEdGenderFemale.TabStop = true;
            this.rbEdGenderFemale.Text = "Female";
            this.rbEdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbEdStatusActive
            //
            this.rbEdStatusActive.AutoSize = true;
            this.rbEdStatusActive.Location = new System.Drawing.Point(93, 99);
            this.rbEdStatusActive.Name = "rbStatus";
            this.rbEdStatusActive.Size = new System.Drawing.Size(94, 19);
            this.rbEdStatusActive.TabIndex = 10;
            this.rbEdStatusActive.TabStop = true;
            this.rbEdStatusActive.Text = "Active";
            this.rbEdStatusActive.UseVisualStyleBackColor = true;
            this.rbEdStatusActive.Checked = true;
            // 
            // rbEdStatusInActive
            //
            this.rbEdStatusInActive.AutoSize = true;
            this.rbEdStatusInActive.Location = new System.Drawing.Point(239, 99);
            this.rbEdStatusInActive.Name = "rbStatus";
            this.rbEdStatusInActive.Size = new System.Drawing.Size(94, 19);
            this.rbEdStatusInActive.TabIndex = 11;
            this.rbEdStatusInActive.TabStop = true;
            this.rbEdStatusInActive.Text = "Inactive";
            this.rbEdStatusInActive.UseVisualStyleBackColor = true;
            //
            //pnGender
            //
            this.pnGender.AutoSize = true;
            this.pnGender.Controls.Add(rbEdGenderMale);
            this.pnGender.Controls.Add(rbEdGenderFemale);
            //
            //pnStatus
            //
            this.pnStatus.AutoSize = true;
            this.pnStatus.Controls.Add(rbEdStatusInActive);
            this.pnStatus.Controls.Add(rbEdStatusActive);
            //
            //btnBack
            //
            this.btnBack.Name = "btnBack";
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Location = new System.Drawing.Point(12, 132);
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            //btnSubmit
            //
            this.btnSave.Name = "btnSubmit";
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Location = new System.Drawing.Point(112, 132);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Click += new System.EventHandler(btnSave_Click);
            //
            //btnUpdate
            //
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Location = new System.Drawing.Point(112, 132);
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
            //
            //btnDelete
            //
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(212, 132);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);


            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoScaleDimensions = new System.Drawing.Size(7, 15);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 200);
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Controls.Add(this.gbEmployeeDetail);
            this.Text = "Employee Details";
            this.gbEmployeeDetail.ResumeLayout(false);
            this.gbEmployeeDetail.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.GroupBox gbEmployeeDetail;
        private System.Windows.Forms.Label lblEdId, lblEdName, lblEdEmailId, lblEdGender, lblEdStatus;
        private System.Windows.Forms.TextBox txtEdId, txtEdName, txtEdEmailId;
        private System.Windows.Forms.RadioButton rbEdGenderMale, rbEdGenderFemale, rbEdStatusActive, rbEdStatusInActive;
        private System.Windows.Forms.Button btnBack, btnSave, btnDelete,btnUpdate;
        Panel pnGender, pnStatus;
        #endregion
    }
}