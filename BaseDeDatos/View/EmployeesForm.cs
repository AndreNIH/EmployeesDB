using BaseDeDatos.Controller;
using BaseDeDatos.Model;
using BaseDeDatos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class EmployeesForm : Form
    {
        private IEmployeeModel _model;
        private IEmployeeController _controller;

        public EmployeesForm()
        {
            InitializeComponent();
            _model = new EmployeeModel();
            _controller = new EmployeeTableController(_model, new EmployeeListViewAdapter(empListView));

        }

        protected override void OnLoad(EventArgs e)
        {
            _controller.RefreshView();

        }

        //Botones de Menu CRUD
        private void createButton_Click_1(object sender, EventArgs e)
        {
            EmployeDataForm form = new EmployeDataForm();
            form.ShowDialog();
            _controller.RefreshView();
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            var selected = _controller.Read();
            if (selected.Count > 0)
            {
                EmployeDataForm form = new EmployeDataForm(selected[0].EmpNo);
                form.ShowDialog();
                _controller.RefreshView();
            }

        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            var selected = _controller.Read();
            if (selected.Count > 0)
            {
                _controller.Delete(selected[0].EmpNo);
                _controller.RefreshView();
            }

        }
    }
}
