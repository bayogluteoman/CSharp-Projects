using System;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fname = regTxtFirst.Text;
            string lname = RegTxtLastName.Text;
            string username = RegTxtUser.Text;
            string password = RegTxtPswrd.Text;

            Realtor realtor = new Realtor(id, fname, lname,username,password);

                    if (checkFields())
                    {
                        try
                        {
                            if (realtor.insertUser(realtor))
                            {
                                MessageBox.Show("New user has been registered");
                            }
                            else
                            {
                                MessageBox.Show("New User Not Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("The username you have filled has already been taken", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Username and Password", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
          LoginForm log = new LoginForm();
          log.Show();
          this.Hide();
        }

        public bool checkFields()

        {
            lblUsernameAstri.Visible = false;
            lblRegPasswordAstri.Visible = false;
            if (RegTxtUser.Text == string.Empty && regTxtFirst.Text == string.Empty && RegTxtPswrd.Text == string.Empty)
            {
                lblUsernameAstri.Visible = true;
                lblRegPasswordAstri.Visible = true;
                return false;
            } else if (RegTxtUser.Text == string.Empty && regTxtFirst.Text == string.Empty)
            {
                lblUsernameAstri.Visible = true;
                return false;
            } else if (regTxtFirst.Text == string.Empty && RegTxtPswrd.Text == string.Empty)
            {
                lblRegPasswordAstri.Visible = true;
                return false;
            } else if (RegTxtUser.Text == string.Empty && RegTxtPswrd.Text == string.Empty)
            {
                lblUsernameAstri.Visible = true;
                lblRegPasswordAstri.Visible = true;
                return false;
            } else if (regTxtFirst.Text == string.Empty)
            {
                return false;
            }
            else if (RegTxtUser.Text == string.Empty)
            {
                lblUsernameAstri.Visible = true;
                return false;
            }
            else if (RegTxtPswrd.Text == string.Empty)
            {
                lblRegPasswordAstri.Visible = true;
                return false;
            }
            else return true;
        }
    }
}
