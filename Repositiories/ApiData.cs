using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.Repositiories
{
    public class ApiData
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=excelWinformDB;Integrated Security=True";
   
        public List<ProjectModel> GetData()
        {
            HttpClient http = new HttpClient();

            var data = new List<ProjectModel>();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM ProjectData ORDER BY id DESC";

                    using(SqlCommand command = new SqlCommand(sql,connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                ProjectModel projectModel = new ProjectModel();
                                projectModel.ProjectName = reader.GetString(1);

                                data.Add(projectModel);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return data;
        }
    }
}
