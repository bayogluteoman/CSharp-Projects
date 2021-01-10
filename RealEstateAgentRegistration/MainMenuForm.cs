using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            ToolTip tt1 = new ToolTip();
           
            tt1.SetToolTip(btnAddHouse, "Houses");
            tt1.SetToolTip(btnAddOwner, "Owners");
            tt1.SetToolTip(btnBack, "Return to Homepage");
            tt1.SetToolTip(btnExit, "Exit");

        }

        private void btnAddHouse_Click_1(object sender, EventArgs e)
        {
            HouseDetailsForm objChild = new HouseDetailsForm();
            objChild.ShowDialog();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            HouseOwnerForm houseowner = new HouseOwnerForm();
            houseowner.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Log Out?";
            string title = "LOG OUT";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm form1sec = new LoginForm();
                form1sec.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Exit?";
            string title = "EXIT";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Goldenrod;
            lblTime.BackColor = Color.Black;
            
            timer1.Enabled = true;

            timer2.Enabled = true;

            lblWelcome.Text = ("DEAR USER WELCOME TO THE REGISTRATION SYSTEM!                                     ");

            if (DateTime.Now.Hour>6 && DateTime.Now.Hour <= 12)
            {
                lblGreetings.Text = "Good Morning!";
            }
            else if(DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 18)
            {
                lblGreetings.Text = "Good Afternoon!";
            }
            else if (DateTime.Now.Hour > 18 && DateTime.Now.Hour <= 23)
            {
                lblGreetings.Text = "Good Evenings!";
            }
            else
                lblGreetings.Text = "Good Night!";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = lblWelcome.Text.Substring(1) + lblWelcome.Text.Substring(0, 1);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            
        }

       
    }
}
