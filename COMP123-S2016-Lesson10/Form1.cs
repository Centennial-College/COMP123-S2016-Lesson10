using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson10
{
    public partial class Form1 : Form
    {
        // Alias for Second Form
        public Form2 SecondForm = Program.SecondForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm.NameLabel.Text = NameTextBox.Text;
            SecondForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel);
            if (result==DialogResult.Cancel)
            {
                // cancels form close event
                e.Cancel = true;
            }
        }
    }
}