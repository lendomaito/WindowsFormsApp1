using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            bool currentCapsLockState2 = Control.IsKeyLocked(Keys.CapsLock);
            



            }




        public void SetMessage(string message)
        {
            labelMessage.Text = message;  // Assume there's a Label named labelMessage on the form
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //var imageToShow = Properties.Resources.ResourceManager.GetObject(g4.png);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    
    
    }

}
    