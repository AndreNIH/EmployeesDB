using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Model
{


    internal interface IEmployeeModel
    {
        bool Create(Employee employee);
        List<Employee> Read();
        Employee? ReadOne(int employeeId);
        bool Update(int employeeId, Employee employee);
        bool Delete(int employeeId);

    }
}
