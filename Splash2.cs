using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Splash2 : Form
    {
        public Splash2()
        {
            InitializeComponent();
        }

        private void Splash2_Load(object sender, EventArgs e)
        {
            
        }

        public void SetMessage(string message)
        {
            labelMessage2.Text = message;  // Assume there's a Label named labelMessage on the form
        }
    }
}
