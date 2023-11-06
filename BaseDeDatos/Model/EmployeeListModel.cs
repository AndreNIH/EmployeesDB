using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseDeDatos.Model
{
    //Esta clase es solo para pruebas
    internal class EmployeeListModel : IEmployeeModel
    {
        private static List<Employee> _employees = new List<Employee>();
        public bool Create(Employee employee)
        {
            _employees.Add(employee);
            return true;
        }

        public bool Delete(int employeeId)
        {
            var obj = _employees.Find(e => e.EmpNo == employeeId);
            _employees.Remove(obj);
            return true;
        }

        public List<Employee> Read()
        {
            return _employees;
        }

        public Employee? ReadOne(int employeeId)
        {
            return _employees.Find(e => e.EmpNo == employeeId); 
        }

        public bool Update(int employeeId, Employee employee)
        {
            var obj = _employees.Find(e => e.EmpNo == employeeId);
            if (obj == null) return false;
            obj.EmpNo = employee.EmpNo;
            obj.BirthDate = employee.BirthDate;
            obj.HireDate = employee.HireDate;
            obj.FirstName = employee.FirstName;
            obj.LastName = employee.LastName;
            return true;
        }

        public EmployeeListModel()
        {
        }
    }
}
