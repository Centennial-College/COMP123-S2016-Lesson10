using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson10
{
    public partial class SplashScreenForm : Form
    {
        // Alias
        public Form1 FirstForm = Program.FirstForm;

        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            FirstForm.Show();
            this.Hide();   
        }
    }
}
