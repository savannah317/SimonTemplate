using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //create a list to store the pattern
        public static List<int> patternList = new List<int>();

        public static int gameMode = 0;

        public Form1()
        {
            InitializeComponent();
            MenuScreen menuScreen = new MenuScreen();
            this.Controls.Add(menuScreen);
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
        //Launch MenuScreen
        Form f; 

        if (sender is Form)
        {
            f = (Form)sender;
        }
        else
        {
            UserControl current = (UserControl)sender;
            f = current.FindForm();
            f.Controls.Remove(current);
        }
        next.Location = new Point((f.ClientSize.Width - next.Width) / 2, (f.ClientSize.Height - next.Height) / 2);
        f.Controls.Add(next);
        }
        
    }
}
