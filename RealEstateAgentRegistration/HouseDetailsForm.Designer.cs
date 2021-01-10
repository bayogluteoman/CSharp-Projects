
namespace RealEstateAgentRegistration
{
    partial class HouseDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseDetailsForm));
            this.btnSelectOwner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHouseId = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbNumOfRooms = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumOfRooms = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.cmbRentSale = new System.Windows.Forms.ComboBox();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddressAstri = new System.Windows.Forms.Label();
            this.lblOwnerAstri = new System.Windows.Forms.Label();
            this.lblPriceAstri = new System.Windows.Forms.Label();
            this.lblSizeAstri = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHouseIdSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.BackColor = System.Drawing.Color.Black;
            this.btnSelectOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOwner.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOwner.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSelectOwner.Location = new System.Drawing.Point(260, 233);
            this.btnSelectOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(155, 43);
            this.btnSelectOwner.TabIndex = 71;
            this.btnSelectOwner.Text = "Select Owner";
            this.btnSelectOwner.UseVisualStyleBackColor = false;
            this.btnSelectOwner.Click += new System.EventHandler(this.btnSelectOwner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "House ID :";
            // 
            // txtHouseId
            // 
            this.txtHouseId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHouseId.Location = new System.Drawing.Point(177, 23);
            this.txtHouseId.Margin = new System.Windows.Forms.Padding(4);
            this.txtHouseId.MaxLength = 5;
            this.txtHouseId.Name = "txtHouseId";
            this.txtHouseId.Size = new System.Drawing.Size(64, 26);
            this.txtHouseId.TabIndex = 68;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwner.Location = new System.Drawing.Point(44, 247);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(88, 24);
            this.lblOwner.TabIndex = 67;
            this.lblOwner.Text = "Owner :";
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOwnerId.Location = new System.Drawing.Point(155, 244);
            this.txtOwnerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwnerId.MaxLength = 9;
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(64, 26);
            this.txtOwnerId.TabIndex = 71;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSize.Location = new System.Drawing.Point(155, 81);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSize.MaxLength = 4;
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSize.Size = new System.Drawing.Size(64, 22);
            this.txtSize.TabIndex = 69;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Goldenrod;
            this.label15.Location = new System.Drawing.Point(225, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 24);
            this.label15.TabIndex = 64;
            this.label15.Text = "m²";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSize.Location = new System.Drawing.Point(44, 87);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(62, 24);
            this.lblSize.TabIndex = 63;
            this.lblSize.Text = "Size :";
            // 
            // cmbFloor
            // 
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "13+"});
            this.cmbFloor.Location = new System.Drawing.Point(709, 162);
            this.cmbFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(76, 27);
            this.cmbFloor.TabIndex = 74;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFloor.Location = new System.Drawing.Point(437, 165);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(73, 24);
            this.lblFloor.TabIndex = 61;
            this.lblFloor.Text = "Floor :";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblComment.Location = new System.Drawing.Point(1363, 33);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(118, 24);
            this.lblComment.TabIndex = 60;
            this.lblComment.Text = "Comment :";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtComment.Location = new System.Drawing.Point(1499, 34);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComment.MaxLength = 150;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(207, 163);
            this.txtComment.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(298, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "₺";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAddress.Location = new System.Drawing.Point(911, 33);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(102, 24);
            this.lblAddress.TabIndex = 57;
            this.lblAddress.Text = "Address :";
            // 
            // cmbNumOfRooms
            // 
            this.cmbNumOfRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumOfRooms.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbNumOfRooms.FormattingEnabled = true;
            this.cmbNumOfRooms.Items.AddRange(new object[] {
            "0+1",
            "1+1",
            "2+1",
            "3+1",
            "4+1",
            "5+1",
            "6+1"});
            this.cmbNumOfRooms.Location = new System.Drawing.Point(709, 103);
            this.cmbNumOfRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNumOfRooms.Name = "cmbNumOfRooms";
            this.cmbNumOfRooms.Size = new System.Drawing.Size(121, 27);
            this.cmbNumOfRooms.TabIndex = 73;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(1060, 34);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(207, 163);
            this.txtAddress.TabIndex = 75;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(155, 143);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.MaxLength = 13;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrice.Size = new System.Drawing.Size(145, 22);
            this.txtPrice.TabIndex = 70;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPrice.Location = new System.Drawing.Point(44, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 24);
            this.lblPrice.TabIndex = 53;
            this.lblPrice.Text = "Price :";
            // 
            // lblNumOfRooms
            // 
            this.lblNumOfRooms.AutoSize = true;
            this.lblNumOfRooms.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfRooms.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNumOfRooms.Location = new System.Drawing.Point(434, 107);
            this.lblNumOfRooms.Name = "lblNumOfRooms";
            this.lblNumOfRooms.Size = new System.Drawing.Size(197, 24);
            this.lblNumOfRooms.TabIndex = 52;
            this.lblNumOfRooms.Text = "Number of Rooms :";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRent.Location = new System.Drawing.Point(434, 26);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(156, 24);
            this.lblRent.TabIndex = 51;
            this.lblRent.Text = "For Rent/Sale?";
            // 
            // cmbRentSale
            // 
            this.cmbRentSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentSale.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRentSale.FormattingEnabled = true;
            this.cmbRentSale.Items.AddRange(new object[] {
            "Sale ",
            "Rent"});
            this.cmbRentSale.Location = new System.Drawing.Point(709, 26);
            this.cmbRentSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRentSale.Name = "cmbRentSale";
            this.cmbRentSale.Size = new System.Drawing.Size(121, 27);
            this.cmbRentSale.TabIndex = 72;
            // 
            // btnShowImage
            // 
            this.btnShowImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowImage.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowImage.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnShowImage.Location = new System.Drawing.Point(1087, 4);
            this.btnShowImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(353, 121);
            this.btnShowImage.TabIndex = 81;
            this.btnShowImage.Text = "Show Images";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRemove.Location = new System.Drawing.Point(726, 4);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(353, 121);
            this.btnRemove.TabIndex = 80;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.Location = new System.Drawing.Point(365, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(353, 121);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnCancel.Location = new System.Drawing.Point(1447, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(358, 125);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.Location = new System.Drawing.Point(3, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(355, 125);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddressAstri
            // 
            this.lblAddressAstri.AutoSize = true;
            this.lblAddressAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddressAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAddressAstri.Location = new System.Drawing.Point(1025, 31);
            this.lblAddressAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressAstri.Name = "lblAddressAstri";
            this.lblAddressAstri.Size = new System.Drawing.Size(15, 18);
            this.lblAddressAstri.TabIndex = 84;
            this.lblAddressAstri.Text = "*";
            this.lblAddressAstri.Visible = false;
            // 
            // lblOwnerAstri
            // 
            this.lblOwnerAstri.AutoSize = true;
            this.lblOwnerAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOwnerAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerAstri.Location = new System.Drawing.Point(226, 244);
            this.lblOwnerAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerAstri.Name = "lblOwnerAstri";
            this.lblOwnerAstri.Size = new System.Drawing.Size(15, 18);
            this.lblOwnerAstri.TabIndex = 80;
            this.lblOwnerAstri.Text = "*";
            this.lblOwnerAstri.Visible = false;
            // 
            // lblPriceAstri
            // 
            this.lblPriceAstri.AutoSize = true;
            this.lblPriceAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPriceAstri.Location = new System.Drawing.Point(315, 143);
            this.lblPriceAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceAstri.Name = "lblPriceAstri";
            this.lblPriceAstri.Size = new System.Drawing.Size(15, 18);
            this.lblPriceAstri.TabIndex = 79;
            this.lblPriceAstri.Text = "*";
            this.lblPriceAstri.Visible = false;
            // 
            // lblSizeAstri
            // 
            this.lblSizeAstri.AutoSize = true;
            this.lblSizeAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSizeAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSizeAstri.Location = new System.Drawing.Point(257, 81);
            this.lblSizeAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeAstri.Name = "lblSizeAstri";
            this.lblSizeAstri.Size = new System.Drawing.Size(15, 18);
            this.lblSizeAstri.TabIndex = 78;
            this.lblSizeAstri.Text = "*";
            this.lblSizeAstri.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1596, 487);
            this.dataGridView1.TabIndex = 77;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShowImage, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 973);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1808, 129);
            this.tableLayoutPanel1.TabIndex = 83;
            // 
            // btnHouseIdSearch
            // 
            this.btnHouseIdSearch.BackColor = System.Drawing.Color.Lime;
            this.btnHouseIdSearch.BackgroundImage = global::RealEstateAgentRegistration.Properties.Resources.mercek;
            this.btnHouseIdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHouseIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHouseIdSearch.Location = new System.Drawing.Point(261, 20);
            this.btnHouseIdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnHouseIdSearch.Name = "btnHouseIdSearch";
            this.btnHouseIdSearch.Size = new System.Drawing.Size(39, 30);
            this.btnHouseIdSearch.TabIndex = 70;
            this.btnHouseIdSearch.UseVisualStyleBackColor = false;
            this.btnHouseIdSearch.Click += new System.EventHandler(this.btnHouseIdSearch_Click);
            // 
            // HouseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1808, 1102);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAddressAstri);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmbNumOfRooms);
            this.Controls.Add(this.txtOwnerId);
            this.Controls.Add(this.cmbRentSale);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblOwnerAstri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPriceAstri);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblSizeAstri);
            this.Controls.Add(this.lblNumOfRooms);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnSelectOwner);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtHouseId);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHouseIdSearch);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(178, 77);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HouseDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "House Details";
            this.Load += new System.EventHandler(this.HouseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectOwner;
        private System.Windows.Forms.Button btnHouseIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHouseId;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbNumOfRooms;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumOfRooms;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.ComboBox cmbRentSale;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOwnerAstri;
        private System.Windows.Forms.Label lblPriceAstri;
        private System.Windows.Forms.Label lblSizeAstri;
        private System.Windows.Forms.Label lblAddressAstri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}