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
    public partial class AddSubject : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["CodeDB"].ConnectionString;
        List<Subject> subjects = new List<Subject>();
         



        public AddSubject()
        {
            InitializeComponent(); 
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection =new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, sub_name FROM getAllSubjects";
                using(SqlCommand command =new SqlCommand(query, connection))
                {
                    using(SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            subjects.Add(new Subject
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Name = dr["sub_name"].ToString()
                            });
                        }
                        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvData.DataSource = subjects;
                    }
                }
            }
        }
    }
}
