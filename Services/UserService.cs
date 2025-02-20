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
}
}