using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatos.Controller;
using BaseDeDatos.Model;
using BaseDeDatos.View;

namespace BaseDeDatos
{
    public partial class EmployeDataForm : Form, IEmployeeView
    {

        private IEmployeeModel _employeeModel;
        private IEmployeeController _employeeController;
        private int? _employeeId;
        private bool _updateMode = false;

        public EmployeDataForm()
        {
            _employeeModel = new EmployeeModel();
            _employeeController = new EmployeeController(_employeeModel, this);
            InitializeComponent();
        }

        public EmployeDataForm(int employeeId)
        {
            InitializeComponent();
            _employeeModel = new EmployeeModel();
            _employeeController = new EmployeeController(_employeeModel, this);
            _employeeId = employeeId;
            _updateMode = true;
            this.Text += $" | Empleado #{_employeeController.ReadOne(employeeId).EmpNo}";
            _employeeController.RefreshView(employeeId);
        }

        void IEmployeeView.Update(List<Employee> employeeRecords)
        {
            if (employeeRecords.Count > 0)
            {
                employeeNumTextbox.Text = employeeRecords[0].EmpNo.ToString();
                firstNameTextbox.Text = employeeRecords[0].FirstName;
                lastNameTextbox.Text = employeeRecords[0].LastName;
                hireDatePicker.Value = employeeRecords[0].HireDate;
                birthDatePicker.Value = employeeRecords[0].BirthDate;
                genderBox.SelectedIndex = employeeRecords[0].Gender;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                //Este campo es read-only, la asignacion de ids es autonumerica
                employee.EmpNo = int.Parse(employeeNumTextbox.Text);
                employee.FirstName = firstNameTextbox.Text;
                employee.Gender = genderBox.SelectedIndex;
                employee.LastName = lastNameTextbox.Text;
                employee.HireDate = hireDatePicker.Value;
                employee.BirthDate = birthDatePicker.Value;

                if (_updateMode)
                {
                    _employeeModel.Update(_employeeId.Value, employee);
                }
                else
                {
                    _employeeModel.Create(employee);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EmployeDataForm_Load(object sender, EventArgs e)
        {
            _employeeController.RefreshView();
        }
    }
}