using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos.Model;

namespace BaseDeDatos.Controller
{
    internal interface IEmployeeController
    {
        void Create(Employee employee);
        List<Employee> Read();
        Employee? ReadOne(int id);
        void Update(int employeeId, Employee employee);
        void Delete(int employeeId);

        void RefreshView(int? filterId=null);
    }
}
