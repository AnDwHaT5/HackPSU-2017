using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackPSU_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void accountCreated()
        {
            accountPromptLabel.Text = "  Your account has been created!\nClick login to access to your account.";
        }

        public void loginSuccessful(string username)
        {
            GUIGrades gradesForm = new GUIGrades(username, this);
            gradesForm.Show();
            this.Hide();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(false, this);
            form.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(true, this);
            form.Show();
        }
    }
}
