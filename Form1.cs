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
    public partial class Form1 : Form
    {
        private bool isCapsLockOn;
        private bool isNumLockOn;
        private Timer stateCheckTimer;

        public Form1()
        {
            InitializeComponent();
            isCapsLockOn = Control.IsKeyLocked(Keys.CapsLock);
            isNumLockOn = Control.IsKeyLocked(Keys.NumLock);

            // Set up the Timer
            stateCheckTimer = new Timer();
            stateCheckTimer.Interval = 100; // Check every 500ms (0.5 seconds)
            stateCheckTimer.Tick += StateCheckTimer_Tick;
            stateCheckTimer.Start();
        }

        private void ShowSplashScreen(string message)
        {
            SplashScreen splash = new SplashScreen();
            splash.Hide();
            splash.SetMessage(message); // Pass the message to the splash screen
            splash.Show();
            splash.BringToFront();
            splash.Focus();
            splash.TopMost = true;

            // Close the splash screen after 2 seconds
            Timer closeTimer = new Timer();
            closeTimer.Interval = 500; // 2000ms = 2 seconds
            closeTimer.Tick += (s, e) =>
            {
                splash.Close(); // Close the splash screen
                closeTimer.Stop(); // Stop the timer
            };
            closeTimer.Start();
        }

        private void StateCheckTimer_Tick(object sender, EventArgs e)
        {
            // Check the current state of Caps Lock and Num Lock
            bool currentCapsLockState = Control.IsKeyLocked(Keys.CapsLock);
            bool currentNumLockState = Control.IsKeyLocked(Keys.NumLock);

            // Check if the Caps Lock state has changed
            if (currentCapsLockState != isCapsLockOn)
            {
                isCapsLockOn = currentCapsLockState;
                string capsState = isCapsLockOn ? "ON" : "OFF";
                ShowSplashScreen($"Caps Lock is {capsState}");
            }   
            
            //notifyIcon1.ShowBalloonTip(200, "Caps Lock Changed", $"Caps Lock is {capsState}.", ToolTipIcon.Info);
            

            // Check if the Num Lock state has changed
            if (currentNumLockState != isNumLockOn)
            {
                isNumLockOn = currentNumLockState;
                string numState = isNumLockOn ? "ON" : "OFF";
                ShowSplashScreen($"Num Lock is {numState}");

                //notifyIcon1.ShowBalloonTip(200, "Num Lock Changed", $"Num Lock is {numState}.", ToolTipIcon.Info);
            }
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(500, "Minimized to Tray", "Your app is still running.", ToolTipIcon.Info);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form
            this.Show();

            // Hide the NotifyIcon
            notifyIcon1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Ensures that timers are properly removed when they are no longer in use
        private void DisposeTimers()
        {
            stateCheckTimer?.Dispose();
        }


        //Ensures that timers handlers are properly removed when they are no longer in use
     //   protected override void Dispose(bool disposing)
     //   {
     //       if (disposing)
      //      {
       //         DisposeTimers();
        //        components?.Dispose();
        //        UnsubscribeEvents();
         //       DisposeTimers();
        //        components?.Dispose();
        //    }
      //      base.Dispose(disposing);
      //  }
        private void UnsubscribeEvents()
        {
            stateCheckTimer.Tick -= StateCheckTimer_Tick;
        }

        
    }
}
