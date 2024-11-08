using Microsoft.Win32;
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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {
            LoginakunContext loginakunContext = new LoginakunContext();
            LoginAkun login = loginakunContext.Validate(usernametextbox.Text, passwordtextbox.Text);
            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                ClearTextBox();
            }
            else if (string.IsNullOrEmpty(usernametextbox.Text) ||
            string.IsNullOrEmpty(passwordtextbox.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!",
                "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            register2 addregister = new register2();
            addregister.ShowDialog();
            this.Show();
        }

    }
}
