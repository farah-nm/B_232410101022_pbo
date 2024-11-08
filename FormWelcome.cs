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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormTugas formTugas = new FormTugas();
            formTugas.Show();
        }
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formLogin = new FormLoginAdmin();
            formLogin.Show();
        }
    }
}
