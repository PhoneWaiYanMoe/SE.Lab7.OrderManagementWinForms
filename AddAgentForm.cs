using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWinForms
{
    public partial class AddAgentForm : Form
    {
        private readonly AgentRepository _agentRepository;

        public AddAgentForm()
        {
            InitializeComponent();
            _agentRepository = new AgentRepository();
        }


        private void txtAgentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent
            {
                AgentID = int.Parse(txtAgentID.Text),
                AgentName = txtAgentName.Text,
                Address = txtAddress.Text
            };

            _agentRepository.AddAgent(agent);
            MessageBox.Show("Agent added successfully!");
            this.Close();
        }

        private void AddAgentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
