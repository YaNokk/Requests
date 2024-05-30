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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView ()
        {
            dataGridViewClient.DataSource = new DB().Requests.Select(i => new { i.masterID, bla = i.problemDescription, Статус = i.Status.Name }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClientFormCreate(dataGridViewClient).Show();
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
