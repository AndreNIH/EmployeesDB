using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos.Model;

namespace BaseDeDatos.View
{
    internal interface IEmployeeView
    {
        void Update(List<Employee> employeeRecords);
    }
}
