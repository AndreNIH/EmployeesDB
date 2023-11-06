using BaseDeDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.View
{
    public class EmployeeListViewAdapter : IEmployeeView
    {
        private ListView _view;
        public void Update(List<Employee> employeeRecords)
        {
            _view.Items.Clear();
            foreach (var e in employeeRecords)
            {
                var item = new ListViewItem(new string[] {
                    e.EmpNo.ToString(),
                    e.FirstName,
                    e.LastName,
                    e.Gender == 0 ? "Hombre" : "Mujer",
                    e.BirthDate.ToLongDateString(),
                    e.HireDate.ToLongDateString(),
                });

                _view.Items.Add(item);
            }
        }

        public ListView.SelectedIndexCollection Selected()
        {
            return _view.SelectedIndices;
        }

        public EmployeeListViewAdapter(ListView view)
        {
            _view = view;
        }
    }
}
