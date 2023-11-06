using BaseDeDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos.View;

namespace BaseDeDatos.Controller
{
    internal class EmployeeTableController : IEmployeeController
    {
        private IEmployeeModel _model;
        private EmployeeListViewAdapter _view;
        private List<int> _listToEmployeelId = new List<int>();
        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int employeeId)
        {
            _model.Delete(employeeId);
            MapRowsToIds();
        }

        public List<Employee> Read()
        {
            List<Employee> list = new List<Employee>();
            var id = GetSelectedEmployeeId();
            if (id.HasValue)
            {
                list.Add(_model.ReadOne(id.Value));
            }
            return list;
            
        }

        public Employee? ReadOne(int id)
        {
            throw new NotImplementedException();
        }

        public void RefreshView(int? filterId = null)
        {
            var m = _model.Read();
            _view.Update(m);
            MapRowsToIds();
        }

        public void Update(int employeeId, Employee employee)
        {
            throw new NotImplementedException();
        }

        
        public EmployeeTableController(IEmployeeModel model, EmployeeListViewAdapter view)
        {
            _model = model;
            _view = view;
            MapRowsToIds();
            RefreshView();
        }


        //Id to list mappings
        private void MapRowsToIds()
        {
            _listToEmployeelId.Clear();
            foreach (var emp in _model.Read())
            {
                _listToEmployeelId.Add(emp.EmpNo);
            }
        }

        private int? GetSelectedEmployeeId()
        {
            var selected = _view.Selected();
            if (selected.Count > 0)
            {
                return _listToEmployeelId[selected[0]];
            }
            return null; ;
        }

    }

    
}
