using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            if (labeloutput.Text == "[EMPTY]")
            {
                labeloutput.Text = textBoxinput.Text;
                textBoxinput.Text = "";
            }
            else
            {
                if (textBoxinput.Text == "DELETE")
                {
                    labeloutput.Text = "[EMPTY]";
                    textBoxinput.Text = "";
                }
                if (textBoxinput.Text == "SHOWN")
                {
                    labeloutput.Visible = true;
                    textBoxinput.Text = "";
                }
                if (textBoxinput.Text == "HIDE")
                {
                    labeloutput.Visible = false;
                    textBoxinput.Text = "";
                }
                if (textBoxinput.Text == "BLUE")
                {
                    labeloutput.ForeColor = Color.Blue;
                    textBoxinput.Text = "";
                }
                if (textBoxinput.Text == "RED")
                {
                    labeloutput.ForeColor = Color.Red;
                    textBoxinput.Text = "";
                }
                if (textBoxinput.Text == "GREEN")
                {
                    labeloutput.ForeColor = Color.Green;
                    textBoxinput.Text = "";
                }
            }
        }
    }
}
