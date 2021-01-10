using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class HouseOwnerForm : Form
    {
        People people = new People();

        public HouseOwnerForm()
        {
            InitializeComponent();
        }

        //show the datagridview
        private void HouseOwner_Load(object sender, EventArgs e)
        {
            LoadDataGridviewOwners();
            showOwnersCount();
            dataGridView1.Columns[1].HeaderCell.Value = "ID";
            dataGridView1.Columns[2].HeaderCell.Value = "First Name";
            dataGridView1.Columns[3].HeaderCell.Value = "Last Name";
            dataGridView1.Columns[4].HeaderCell.Value = "Phone";
            dataGridView1.Columns[5].HeaderCell.Value = "E-mail";
            dataGridView1.Columns[6].HeaderCell.Value = "Address";
        }

        //take data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFirstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        //insert a new house owner
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            people = new People(id, fname, lname, phone, email, address);

            if (verifyTextBoxes())
            {
                if (people.insertPeople("house_owner", people))
                {
                    MessageBox.Show("New Owner Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridviewOwners();
                    showOwnersCount();
                    clearAllFields();

                }
                else
                {
                    MessageBox.Show("New Owner Not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter THe Owner First, Last Name + The Phone Number", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update the selected house owner
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            try
            {
                int id = Convert.ToInt32(txtId.Text);

                if (verifyTextBoxes())
                {
                    if (people.updatePeople("house_owner", new People(id, fname, lname, phone, email, address)))
                    {
                        MessageBox.Show("Owner Updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridviewOwners();
                        showOwnersCount();
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("Owner Not Updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter THe Owner First, Last Name and  Phone Number", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Owner Id Error", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete the selected house owner
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                if (people.deletePeople("house_owner", id))
                {
                    MessageBox.Show("Owner Deleted", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridviewOwners();
                    showOwnersCount();
                    clearAllFields();
                }
                else
                {
                    MessageBox.Show("Owner Not Deleted", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Owner Id Error", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //display the selected house owner data from datagridview to textbox
        public bool verifyTextBoxes()
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string phone = txtPhone.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //fill the datagridview
        public void LoadDataGridviewOwners()
        {
            dataGridView1.DataSource = people.getAllPeople("house_owner");
        }

        // show how many owners in system
        public void showOwnersCount()
        {
            string Count = people.getAllPeople("house_owner").Rows.Count.ToString();
            if (Convert.ToInt32(Count) > 1)
            {
                lblCountOwners.Text = Count + " Owners";
            }
            else
            {
                lblCountOwners.Text = Count + " Owner";
            }
        }

       //show selected owner's house details
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    DetailsListForm detListform = new DetailsListForm();

                    int id = Convert.ToInt32(txtId.Text);

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `house` WHERE `owner_id`=@ownerId");
                    command.Parameters.Add("@ownerId", MySqlDbType.Int32).Value = id;

                    detListform.populateDataGridview(command);

                    detListform.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Please first select a row ");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? The information you have entered will be lost!";
            string title = "Congratulations!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        //if user click once,show the warning
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                lblWarning.Visible = true;
            }
        }

        //clear textboxes
        public void clearAllFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        //don't allow to write a letter
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
