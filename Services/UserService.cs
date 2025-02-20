using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using setups.Models;

namespace Setup.Services // Namespace for the UserService class
{
    public class UserService
    {
        private readonly string _connectionString;

        public UserService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM employees";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Employee
                    {
                        Id = reader.GetInt32("id"),
                        FirstName = reader.GetString("first_name"),
                        LastName = reader.GetString("last_name"),
                        Email = reader.GetString("email"),
                        JobTitle = reader.GetString("job_title"),
                        DepartmentId = reader.GetInt32("department_id"),
                        Status = reader.GetString("status")
                    });
                }
            }
            return employees;
        }

        public List<TaskModel> GetTasks()
        {
            List<TaskModel> tasks = new List<TaskModel>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tasks";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new TaskModel
                    {
                        Id = reader.GetInt32("id"),
                        Title = reader.GetString("title"),
                        Description = reader.GetString("description"),
                        Status = reader.GetString("status"),
                        Priority = reader.GetString("priority"),
                        AssignedTo = reader.GetInt32("assigned_to"),
                        ProjectId = reader.GetInt32("project_id")
                    });
                }
            }
            return tasks;
        }

        public List<Attendance> GetAttendance()
        {
            List<Attendance> attendanceRecords = new List<Attendance>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM attendance";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    attendanceRecords.Add(new Attendance
                    {
                        Id = reader.GetInt32("id"),
                        EmployeeId = reader.GetInt32("employee_id"),
                        CheckIn = reader.GetDateTime("check_in"),
                        CheckOut = reader.IsDBNull(reader.GetOrdinal("check_out")) ? (DateTime?)null : reader.GetDateTime("check_out"),
                        Status = reader.GetString("status"),
                        CreatedAt = reader.GetDateTime("created_at")
                    });
                }
            }
            return attendanceRecords;
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM departments";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        ManagerId = reader.IsDBNull(reader.GetOrdinal("manager_id")) ? (int?)null : reader.GetInt32("manager_id")
                    });
                }
            }
            return departments;
        }
    }
}
