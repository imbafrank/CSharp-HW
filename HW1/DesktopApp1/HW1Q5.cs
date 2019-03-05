using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (reg.Match(num1.Text).Success && reg.Match(num2.Text).Success)
            {
                int n1 = int.Parse(num1.Text);
                int n2 = int.Parse(num2.Text);

                resultlabel.Text = "" + (n1 * n2);
            }
            else
            {
                MessageBox.Show("Error, please verify your input");
            }

        }



    }
}
