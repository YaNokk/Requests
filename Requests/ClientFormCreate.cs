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
    public partial class ClientFormCreate : Form
    {
        DataGridView DataGridView;
        DB db = new DB();
        public ClientFormCreate(DataGridView dataGridView)
        {
            this.DataGridView = dataGridView;
            InitializeComponent();
        }

        private int GetNextRequestID()
        {
            int lastRequestID = db.Requests.OrderByDescending(r => r.requestID).FirstOrDefault()?.requestID ?? 0;
            return lastRequestID + 1;
        }

        private void clientFormCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Requests
                {
                    problemDescription = clientFormCreateDescription.Text,
                    homeTechModel = clientFormCreateModel.Text,
                    homeTechType = clientFormCreateType.Text,
                    startDate = DateTime.Now,
                    requestID = GetNextRequestID(),
                    clientID = Auth.currentUser.userID,
                    masterID = Auth.currentUser.userID,
                    Status_ID = (int)Status.Statuses.NEW
                };
                db.Requests.Add(request);
                db.SaveChanges();
                DataGridView.DataSource = db.Requests.ToList();
                clientFormCreateDescription.ResetText();
                clientFormCreateModel.ResetText();
                clientFormCreateType.ResetText();
            } catch (Exception exception)
            {
                MessageBox.Show("Ошибка при создании заявки!" + exception.Message);
            }
            
        }

        private void ClientFormCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
