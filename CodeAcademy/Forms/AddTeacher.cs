using CodeAcademy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademy.Forms
{
    public partial class AddTeacher : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeDB"].ConnectionString;


        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, teach_name, teach_surname, sub_name FROM getAllTeachersAndSubjects";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            teachers.Add(new Teacher
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Name = dr["teach_name"].ToString(),
                                Surname = dr["teach_surname"].ToString(),
                                SubName = dr["sub_name"].ToString(),
                            });
                        }
                        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvData.DataSource = teachers;
                    }
                }
            }
        }
    }
}
