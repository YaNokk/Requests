using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Auth.AuthenticateUser(loginField.Text, passwordField.Text);
                switch (user.Role_ID)
                {
                    case 1:
                        new ClientForm().Show();
                        break;
                    case 2:
                        new ExecutorForm().Show();
                        break;
                }
                this.Hide();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
