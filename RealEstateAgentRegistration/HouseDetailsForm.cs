using System;
using System.Data;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class HouseDetailsForm : Form
    {
        Property property = new Property();
        public HouseDetailsForm()
        {
            InitializeComponent();
        }

        //fill the datagridview with house details
        private void HouseDetails_Load(object sender, EventArgs e)
        {
            LoadDataGridviewProperty();
            dataGridView1.Columns[0].HeaderCell.Value = "Owner ID";
            dataGridView1.Columns[1].HeaderCell.Value = "House ID";
            dataGridView1.Columns[2].HeaderCell.Value = "Type";
            dataGridView1.Columns[3].HeaderCell.Value = "Room No";
            dataGridView1.Columns[4].HeaderCell.Value = "Floor";
            dataGridView1.Columns[5].HeaderCell.Value = "Price";
            dataGridView1.Columns[6].HeaderCell.Value = "Address";
            dataGridView1.Columns[7].HeaderCell.Value = "Size";
            dataGridView1.Columns[8].HeaderCell.Value = "Comment";
        }


        //search propery by id
        private void btnHouseIdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //get the property id
                int id = Convert.ToInt32(txtHouseId.Text);

                //get the property data using id
                DataTable propertyData = property.getPropertyById(id);

                //display the property data
                txtOwnerId.Text = propertyData.Rows[0]["owner_id"].ToString();
                txtSize.Text = propertyData.Rows[0]["house_size"].ToString();
                txtPrice.Text = propertyData.Rows[0]["house_price"].ToString();
                txtAddress.Text = propertyData.Rows[0]["house_address"].ToString();
                txtComment.Text = propertyData.Rows[0]["house_comment"].ToString();
                cmbFloor.SelectedItem = propertyData.Rows[0]["house_floor"].ToString();
                cmbNumOfRooms.SelectedItem = propertyData.Rows[0]["room_no"].ToString();
                cmbRentSale.SelectedItem = propertyData.Rows[0]["type"].ToString();
            }
            catch 
            {
                if (txtHouseId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter The House Id First", "House Id Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearAllFields();
                }
                else
                {
                    MessageBox.Show("This House Id Does Not Exists", "House Id Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearAllFields();
                }
            }
        }

        // open a new form to select the property owner
        private void btnSelectOwner_Click(object sender, EventArgs e)
        {
            OwnersListForm ownersF = new OwnersListForm();
            ownersF.ShowDialog();
            txtOwnerId.Text = ownersF.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        //insert new house 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(txtSize.Text); 
                string price = txtPrice.Text;
                int owner = Convert.ToInt32(txtOwnerId.Text);
                string rentSale = cmbRentSale.Text.ToString();
                string numOfRooms = cmbNumOfRooms.Text.ToString();
                string floor = cmbFloor.Text.ToString();
                string address = txtAddress.Text;
                string comment = txtComment.Text;
                string image = string.Empty;

               
                property = new Property(0, owner, rentSale, numOfRooms, floor, price, address, size, comment,image);

                if (verifyTextBoxes())
                {
                    if (property.insertHouse(property))
                    {
                        MessageBox.Show("New house added", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridviewProperty();
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("New house not added", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter The Required Fields(Size-Address-Price-Owner)", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSizeAstri.Visible = true;
                    lblPriceAstri.Visible = true;
                    lblOwnerAstri.Visible = true;
                    lblAddressAstri.Visible = true;
                }
            }
            catch 
            {
                MessageBox.Show("You can't left any textbox empty ! ", "Add Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update the selected house property
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtHouseId.Text); 
                int size = Convert.ToInt32(txtSize.Text); 
                string price = txtPrice.Text;
                int owner = Convert.ToInt32(txtOwnerId.Text); 
                string rentSale = cmbRentSale.Text.ToString();
                string numOfRooms = cmbNumOfRooms.Text.ToString();
                string floor = cmbFloor.Text.ToString();
                string address = txtAddress.Text;
                string comment = txtComment.Text;
                string image = string.Empty;

               
                property = new Property(id, owner, rentSale, numOfRooms, floor, price, address, size, comment,image);

                if (verifyTextBoxes())
                {

                    if (property.updateHouse(property))
                    {
                        MessageBox.Show("House Detail(s) Updated", "Edit Detail(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridviewProperty();
                        clearAllFields();
                    }
                    else
                    {
                        MessageBox.Show("House detail(s) Not Updated", "Edit Detail(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Required Fields(Size-Address-Price-Owner)", "Edit Detail(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //remove the selected house
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtHouseId.Text);

                if(MessageBox.Show("Are You Sure You Want To Delete This House ?","Delete House",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (property.deleteHouse(id))
                    {
                        MessageBox.Show("House Deleted", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridviewProperty();

                       
                        clearAllFields();

                    }
                    else
                    {
                        MessageBox.Show("House Not Deleted", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("House Id Error", "Delete House", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            
            if (txtHouseId.Text != string.Empty) 
            {
                ImagePopupForm img = new ImagePopupForm();
                img.Show();
            }
            else
            {
                MessageBox.Show("Please enter a house ID number");
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


        //create a function to verify if any of the required fields is empty
        public bool verifyTextBoxes()
        {
            string owner = txtOwnerId.Text.Trim();
            string size = txtSize.Text.Trim();
            string price = txtPrice.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (size.Equals("") || price.Equals("") || address.Equals("") || owner.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //fill the datagridview
        public void LoadDataGridviewProperty()
        {
            dataGridView1.DataSource = property.getAllProperty("house");
        }

        //clear textboxes and comboboxes
        public void clearAllFields()
        {
            txtHouseId.Text = "";
            txtSize.Text = "";
            txtPrice.Text = "";
            txtOwnerId.Text = "";
            txtComment.Text = "";
            txtAddress.Text = "";
            cmbFloor.SelectedIndex = -1;
            cmbNumOfRooms.SelectedIndex = -1;
            cmbRentSale.SelectedIndex = -1;
        }


        //don't allow to write a letter
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        //don't allow to write a letter
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
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
