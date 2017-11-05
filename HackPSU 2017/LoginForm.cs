using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HackPSU_2017
{
    public partial class LoginForm : Form
    {
        bool registerLogin;
        Form1 mainForm;
        public LoginForm(bool registering, Form1 form)
        {
            registerLogin = registering;
            mainForm = form;
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (registerLogin)
                buttonLoginRegister.Text = "Register";
            else
                buttonLoginRegister.Text = "Login";
        }

        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text == "" || passwordInput.Text == "")
            {
                errorMessageLabel.Text = "Please be sure to enter a " + (usernameInput.Text == "" ? "username!" : "password!");
                errorMessageLabel.Visible = true;
                return;
            }
            if (!Directory.Exists("Accounts"))
                Directory.CreateDirectory("Accounts");


            if (registerLogin)
            {
                if (Directory.Exists(usernameInput.Text))
                {
                    errorMessageLabel.Text = "This user already exists!\nChoose a different one.";
                    errorMessageLabel.Visible = true;
                    return;
                }
                Directory.CreateDirectory("Accounts/" + usernameInput.Text + "/");
                File.Create("password.txt");
                StreamWriter w = new StreamWriter("Accounts/" + usernameInput.Text + "/" + "/password.txt");
                w.WriteLine(passwordInput.Text);
                w.Close();
                mainForm.accountCreated();
                this.Close();
            }
            else
            {
                if (!Directory.Exists("Accounts/" + usernameInput.Text))
                {
                    errorMessageLabel.Text = "The username " + usernameInput.Text + " does not exist!\nClaim it by registering it.";
                    errorMessageLabel.Visible = true;
                    return;
                }
                if(File.Exists("Accounts/"+ usernameInput.Text+"/password.txt"))
                {
                    StreamReader reader = new StreamReader("Accounts/" + usernameInput.Text + "/password.txt");
                    string pass = reader.ReadLine();
                    reader.Close();
                    if(passwordInput.Text.Equals(pass))
                    {
                        mainForm.loginSuccessful(usernameInput.Text);
                        this.Close();
                    }
                    else
                    {
                        errorMessageLabel.Text = "You have entered an incorrect password!";
                        errorMessageLabel.Visible = true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Accounts/Developer"))
            {
                Directory.CreateDirectory("Accounts/Developer");
            }
            if(!File.Exists("Accounts/Developer/password.txt"))
            {
                File.Create("Accounts/Developer/password.txt");
                StreamWriter w = new StreamWriter("Accounts/Developer/password.txt");
                w.WriteLine("dev");
                w.Close();
            }
            mainForm.loginSuccessful("Developer");
            this.Close();
        }
    }
}
