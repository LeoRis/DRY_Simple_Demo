using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void GenerateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            employeeIdText.Text = GenerateEmployeeId(firstNameText.Text, lastNameText.Text);
        }

        private string GenerateEmployeeId(string firstName, string lastName)
        {
            string employeeId = $@"{ firstName.Substring(0, 4) }{ lastName.Substring(0, 4) }{ DateTime.Now.Millisecond }";
            return employeeId;
        }
    }
}
