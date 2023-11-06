using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos.Model;
using BaseDeDatos.View;

namespace BaseDeDatos.Controller
{
    internal class EmployeeController : IEmployeeController
    {
        private IEmployeeModel _model;
        private IEmployeeView _view;
        public void Create(Employee employee)
        {
            _model.Create(employee);
        }

        public void Delete(int employeeId)
        {
            _model.Delete(employeeId);
        }

        public List<Employee> Read()
        {
            return _model.Read();
        }

        public void Update(int employeeId, Employee employee)
        {
            _model.Update(employeeId, employee);
        }


        public void RefreshView(int? filterId)
        {
            if (filterId.HasValue)
            {
                var emp = _model.ReadOne(filterId.Value);
                _view.Update(new List<Employee>{ emp });
            }
            else
            {
                
            }
        }

        public Employee? ReadOne(int id)
        {
            return _model.ReadOne(id);
        }

        public EmployeeController(
            IEmployeeModel employeeModel,
            IEmployeeView view)
        {
            _model = employeeModel;
            _view = view;
        }
    }
}
