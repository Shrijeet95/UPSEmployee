using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Employee.Win
{
    partial class EmployeeListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.gbEmployeeList = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDownload= new System.Windows.Forms.Button();
            this.txtSearchEmployeeName = new System.Windows.Forms.TextBox();
            this.lblSearchEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeNote = new System.Windows.Forms.Label();
            this.dgEmployeeList = new System.Windows.Forms.DataGridView();
            this.gbSearch.SuspendLayout();
            this.gbOperation.SuspendLayout();
            this.gbEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            //
            this.gbSearch.Controls.Add(this.btnSearch);
            //this.gbSearch.Controls.Add(this.btnAddEmployee);
            this.gbSearch.Controls.Add(this.txtSearchEmployeeName);
            this.gbSearch.Controls.Add(this.lblSearchEmployeeName);
            this.gbSearch.Text = "Employee Search";
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Location = new System.Drawing.Point(12, 4);
            this.gbSearch.Size = new System.Drawing.Size(565, 100);
            // 
            // 
            // gbOperation
            //
            this.gbOperation.Controls.Add(this.btnAddEmployee);
            this.gbOperation.Controls.Add(this.btnDownload);
            this.gbOperation.Text = "Operation";
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Location = new System.Drawing.Point(580, 4);
            this.gbOperation.Size = new System.Drawing.Size(208, 100);
            // 
            // btnSearch
            //
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Location = new System.Drawing.Point(480, 42);
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //this.btnAddEmployee.Click += new System.EventHandler(btnAddEmployee_Click);
            // 
            // btnAddEmployee
            //
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Emp";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Location = new System.Drawing.Point(20, 42);
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDownload
            //
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Location = new System.Drawing.Point(110, 42);
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtSearchEmployeeName
            //
            this.txtSearchEmployeeName.Name = "txtSearchEmployeeName";
            this.txtSearchEmployeeName.TabIndex = 1;
            this.txtSearchEmployeeName.Location = new System.Drawing.Point(130, 42);
            this.txtSearchEmployeeName.Size = new System.Drawing.Size(337, 23);

            // 
            // label1
            //
            this.lblSearchEmployeeName.AutoSize = true;
            this.lblSearchEmployeeName.Name = "lblSearchEmployeeName";
            this.lblSearchEmployeeName.TabIndex = 0;
            this.lblSearchEmployeeName.Text = "Employee Name";
            this.lblSearchEmployeeName.Location = new System.Drawing.Point(12, 46);
            this.lblSearchEmployeeName.Size = new System.Drawing.Size(104, 15);
            // 
            // groupBox1
            //
            this.gbEmployeeList.Controls.Add(this.dgEmployeeList);
            this.gbEmployeeList.Controls.Add(this.lblEmployeeNote);
            this.gbEmployeeList.Name = "EmployeeList";
            this.gbEmployeeList.Location = new System.Drawing.Point(12, 110);
            this.gbEmployeeList.Size = new System.Drawing.Size(776, 328);
            // 
            // dgEmployeeList
            //
            // 
            this.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeList.Location = new System.Drawing.Point(12,28);
            this.dgEmployeeList.Name = "dgEmployeeList";
            this.dgEmployeeList.RowTemplate.Height = 25;
            this.dgEmployeeList.Size = new System.Drawing.Size(758, 290);
            this.dgEmployeeList.TabIndex = 0;
            this.dgEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEmployeeList.Dock = DockStyle.Fill;
            this.dgEmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpoyeeList_CellContentClick);
            this.dgEmployeeList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            this.dgEmployeeList.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.dgEmployeeList.EnableHeadersVisualStyles= false;
            this.dgEmployeeList.ReadOnly = true;
            this.dgEmployeeList.AllowUserToResizeColumns= false;
            this.dgEmployeeList.AllowUserToResizeRows= false;
            this.dgEmployeeList.RowHeadersVisible= false;
            this.dgEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //lblEmployeeNote
            this.lblEmployeeNote.AutoSize = true;
            this.lblEmployeeNote.Name = "lblEmployeeNote";
            this.lblEmployeeNote.TabIndex = 0;
            this.lblEmployeeNote.Text = "Click on Employee data to update it";
            this.lblEmployeeNote.Location = new System.Drawing.Point(280, 10);
            this.lblEmployeeNote.Size = new System.Drawing.Size(104, 15);
            // Form1
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Controls.Add(this.gbEmployeeList);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbOperation);
            Name = "EmployeeList";
            Text = "Employee Search";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.dgEmployeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblSearchEmployeeName,lblEmployeeNote;
        private System.Windows.Forms.TextBox txtSearchEmployeeName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddEmployee,btnDownload;
        private System.Windows.Forms.GroupBox gbEmployeeList,gbOperation;
        private System.Windows.Forms.DataGridView dgEmployeeList;
    }
}
