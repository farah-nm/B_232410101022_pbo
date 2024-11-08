using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_232410101022_UTSPBO
{
    public partial class FormDashboardAdmin : Form
    {
        private List<Task> tasks = new List<Task>();
        public FormDashboardAdmin()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = 
            string deadline = 
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
