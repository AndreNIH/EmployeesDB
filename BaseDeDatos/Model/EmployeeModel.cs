using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Model
{
    internal class EmployeeModel : IEmployeeModel
    {
        private string _connectionString = Properties.Resources.ConnectionString;
        public bool Create(Employee employee)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = @"INSERT INTO employees 
                                        VALUES(@empNo, @birthDate, @firstName, @lastName, @gender, @hireDate)";

                command.Parameters.AddWithValue("@empNo", employee.EmpNo);
                command.Parameters.AddWithValue("@birthDate", employee.BirthDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@gender", employee.Gender);
                command.Parameters.AddWithValue("@hireDate", employee.HireDate.ToString("yyyy-MM-dd"));
                command.Prepare();
                command.ExecuteNonQuery();
            }
            return true;
        }

        public bool Delete(int employeeId)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = $"DELETE FROM employees WHERE emp_no={employeeId}";
                return command.ExecuteNonQuery() > 0;
            }
            
        }

        public List<Employee> Read()
        {
            List<Employee> list = new List<Employee>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = reader.GetInt32(0);
                    emp.BirthDate = reader.GetDateTime(1);
                    emp.FirstName = reader.GetString(2);
                    emp.LastName = reader.GetString(3);
                    emp.Gender = reader.GetInt32(4);
                    emp.HireDate = reader.GetDateTime(5);
                    list.Add(emp);
                }
            }
            return list;
        }

        public Employee? ReadOne(int employeeId)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = $"SELECT * FROM employees WHERE emp_no={employeeId}";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = reader.GetInt32(0);
                    emp.BirthDate = reader.GetDateTime(1);
                    emp.FirstName = reader.GetString(2);
                    emp.LastName = reader.GetString(3);
                    emp.Gender = reader.GetInt32(4);
                    emp.HireDate = reader.GetDateTime(5);
                    return emp;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Update(int employeeId, Employee employee)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = @"UPDATE `employee_db`.`employees`
                                        SET
                                        `emp_no` = @empNo,
                                        `birth_date` = @birthDate,
                                        `first_name` = @firstName,
                                        `last_name` = @lastName,
                                        `gender` = @gender,
                                        `hire_date` = @hireDate
                                        WHERE `emp_no` = @empNo;
                                        ";
                
                command.Parameters.AddWithValue("@empNo", employee.EmpNo);
                command.Parameters.AddWithValue("@birthDate", employee.BirthDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@gender", employee.Gender);
                command.Parameters.AddWithValue("@hireDate", employee.HireDate.ToString("yyyy-MM-dd"));
                command.Prepare();
                command.ExecuteNonQuery();
            }
            return true;
        }

        
    }
}
