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
    public partial class GUIGrades : Form
    {
        Form1 mainForm;
        string username = "";
        public GUIGrades(string username, Form1 mainForm)
        {
            this.username = username;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void GUIGrades_Load(object sender, EventArgs e)
        {

        }
    }
}
