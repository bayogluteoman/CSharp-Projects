using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class OwnersListForm : Form
    {
        public OwnersListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void OwnersListForm_Load(object sender, EventArgs e)
        {

            //populate the datagridview
            Database dbfunc3 = new Database();

            MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `house_owner`");
            dataGridView1.DataSource = dbfunc3.getData(command);

            //clear the selection from datagridview
            dataGridView1.ClearSelection();
        }
    }
}
