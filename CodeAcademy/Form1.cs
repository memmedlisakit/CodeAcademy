using CodeAcademy.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_AddSubject_Click(object sender, EventArgs e)
        {
            new AddSubject().Show();
        }

        private void Btn_AddTeacher_Click(object sender, EventArgs e)
        {
            new AddTeacher().Show();
        }
    }
}
