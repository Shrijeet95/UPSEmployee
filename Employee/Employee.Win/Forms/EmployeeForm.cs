using Employee.Win.Models.ViewModel;
using Employee.Win.Services.Employee.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.Win.Forms
{
    public partial class EmployeeForm : Form
    {
        private const string tryAgainLater = "Try again later";
        private readonly IEmployeeService employeeService;
        public EmployeeForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            this.employeeService = employeeService;
        }
        #region "Event"
        private async void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateEmployee())
                {
                    int result = await employeeService.SetEmployee(SetEmployeeView());
                    if (result == 1)
                    {
                        MessageBox.Show($"Record of {txtEdName.Text} added successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"{tryAgainLater}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = await employeeService.PutEmployee(SetEmployeeView());
                if (result == 1)
                {
                    MessageBox.Show($"Record of {txtEdName.Text} updated successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{tryAgainLater}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = await employeeService.DelEmployee(Convert.ToInt32(txtEdId.Text));
                if (result == 1)
                {
                    MessageBox.Show($"Record of {txtEdName.Text} deleted successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{tryAgainLater}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "private"
        private EmployeeView SetEmployeeView()
        {
            return new EmployeeView
            {
                email = txtEdEmailId.Text,
                id = string.IsNullOrEmpty(txtEdId.Text) ? 0 : Convert.ToInt32(txtEdId.Text),
                name = txtEdName.Text,
                gender = rbEdGenderMale.Checked ? "male" : "female",
                status = rbEdStatusActive.Checked ? "active" : "active"
            };
        }
        private bool ValidateEmployee()
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            if (string.IsNullOrEmpty(txtEdName.Text.Trim()))
            {
                MessageBox.Show("Employee name is mandatory");
                return false;
            }
            if (string.IsNullOrEmpty(txtEdEmailId.Text.Trim()))
            {
                MessageBox.Show("Employee emailid is mandatory");
                return false;
            }
            if (!regex.IsMatch(txtEdEmailId.Text.Trim()))
            {
                MessageBox.Show("Emailid is invalid");
                return false;
            }
            return true;
        }
        public void ShowDialogue(int? id)
        {
            LoadData(id);
            ConfigureUI(id);
            this.ShowDialog();
        }
        private async void LoadData(int? id)
        {
            if (id.HasValue && id.Value > 0)
            {
                var employee = await employeeService.GetEmployeesById(id.Value);
                if (employee != null && employee.Any())
                {
                    BindData(employee.FirstOrDefault());
                }
            }
        }
        private void BindData(EmployeeView employeeView)
        {
            txtEdEmailId.Text = employeeView.email;
            txtEdId.Text = Convert.ToString(employeeView.id);
            txtEdName.Text = employeeView.name;
            if (employeeView.gender.ToLower() == "male")
            {
                rbEdGenderMale.Checked = true;
            }
            else
            {
                rbEdGenderFemale.Checked = true;
            }

            if (employeeView.status.ToLower() == "active")
            {
                rbEdStatusActive.Checked = true;
            }
            else
            {
                rbEdStatusInActive.Checked = true;
            }
        }
        private void ConfigureUI(int? id)
        {
            if (id.HasValue && id.Value > 0)
            {
                btnSave.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                txtEdEmailId.Text = txtEdName.Text = txtEdId.Text = string.Empty;
                rbEdStatusActive.Checked = rbEdGenderMale.Checked = true;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
        }
        #endregion
    }
}
