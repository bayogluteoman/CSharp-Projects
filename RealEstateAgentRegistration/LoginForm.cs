using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            lblUsernameAstri.BackColor = Color.Transparent;
            lblPasswordAstri.BackColor = Color.Transparent;

        }
        public string getText { get { return txt_username.Text; }
                                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Realtor logIn = new Realtor(txt_username.Text, txt_psswrd.Text);
            Database databasefunc = new Database();

            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM realtor where realtor_username='" + logIn.Realtor_Username + "' AND realtor_psswrd='" + logIn.Realtor_Password + "'");


                DataTable usertable = databasefunc.getData(command);

                if (usertable.Rows.Count > 0)
                {
                    MainMenuForm main = new MainMenuForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password ", "Information");
                }
            }
            
        }
       
        public Boolean checkFields()
        {
            Realtor logIn = new Realtor(txt_username.Text, txt_psswrd.Text);

            lblUsernameAstri.Visible = false;
            lblPasswordAstri.Visible = false;

            if ((logIn.Realtor_Username).Trim().Equals("") && (logIn.Realtor_Password).Trim().Equals(""))
            {
                lblUsernameAstri.Visible = true;
                lblPasswordAstri.Visible = true;
                return false;
            }
            else if ((logIn.Realtor_Username).Trim().Equals(""))
            {
                lblUsernameAstri.Visible = true;
                return false;
            }
            else if ((logIn.Realtor_Password).Trim().Equals(""))
            {
                lblPasswordAstri.Visible = true;
                return false;
            }

            else
            {
                return true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            timerr.Enabled = true;
        }


        private void timer1(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }
        
    }
}
