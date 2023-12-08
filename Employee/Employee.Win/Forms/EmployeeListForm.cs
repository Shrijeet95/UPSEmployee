using Employee.Win.Forms;
using Employee.Win.Models.ViewModel;
using Employee.Win.Services.Employee.Interface;
using Employee.Win.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.Win
{
    public partial class EmployeeListForm : Form
    {
        #region "variable"
        private const string tryAgainLater = "Try again later";
        private const string downloadPath = @"C:\Users\Shrijeet\Downloads\Employee_{0}.csv";
        private readonly IEmployeeService employeeService;
        private readonly Forms.EmployeeForm employee;
        #endregion
        public EmployeeListForm(IEmployeeService employeeService, Employee.Win.Forms.EmployeeForm employee)
        {
            InitializeComponent();
            this.employeeService = employeeService;
            this.employee = employee;
            LoadEmployees();
        }

        #region "Event"
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgEmployeeList.DataSource = null;
                var employeeList = await employeeService.GetEmployeesByName(txtSearchEmployeeName.Text);
                BindEmployees(employeeList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{tryAgainLater}");
            }
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeList = await employeeService.GetEmployeesByName(txtSearchEmployeeName.Text);
                string strCSV = convertListDataToCSV(employeeList);
                if (!string.IsNullOrEmpty(strCSV))
                {
                    if (DownloadData(strCSV) == 1)
                    {
                        MessageBox.Show("Record(s) download successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{tryAgainLater}");
            }

        }
        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee.ShowDialogue(id: null);
        }
        private async void dgEmpoyeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv != null && e.RowIndex >= 0)
                {
                    string id = Convert.ToString(dgv.Rows[e.RowIndex].Cells["id"].Value);
                    employee.ShowDialogue(id: Convert.ToInt32(id));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{tryAgainLater}");
            }
        }
        #endregion

        #region "Private"
        private async void LoadEmployees()
        {
            try
            {
                var employees = await employeeService.GetEmployees();
                BindEmployees(employees);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void BindEmployees(List<EmployeeView> employees)
        {
            if (employees != null && employees.Any())
            {
                dgEmployeeList.DataSource = employees;
            }
            else
            {
                MessageBox.Show("No record found");
            }
        }
        private int DownloadData(string strData)
        {
            if (!string.IsNullOrEmpty(strData))
            {
                File.WriteAllText(string.Format(downloadPath, DateTime.Now.ToString("dd-MM-yy-ss-mm-hh")), strData);
                return 1;
            }
            return 0;
        }
        private string convertListDataToCSV(List<EmployeeView> employeeViews)
        {
            if (employeeViews != null && employeeViews.Any())
            {
                string str = "Id,Name,EmailId,Gender,Status,\r\n";
                str += string.Join("\r\n", employeeViews.Select(x => $"{x.id},{x.name},{x.email},{x.gender},{x.status}"));
                return str;
            }
            else
            {
                MessageBox.Show("No record found");
            }
            return string.Empty;
        }
        #endregion
    }
}
