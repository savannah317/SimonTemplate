using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        //button starts normal mode
        private void newButton_Click(object sender, EventArgs e)
        {
            //sets gamemode to normal
            Form1.gameMode = 0;
            //launch gameScreen
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameScreen());
        }

        //button exits the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button starts hard mode
        private void hardMode_Click(object sender, EventArgs e)
        {
            //sets gamemode to hard and launches gamescreen
            Form1.gameMode = 1;
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameScreen());
        }

        //button starts marek mode
        private void marekButton_Click(object sender, EventArgs e)
        {
            //sets gamemode to marek mode and launches gamescreen
            Form1.gameMode = 2;
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameScreen());
        }

        //buttton starts rotating marek mode
        private void turnMarekButton_Click(object sender, EventArgs e)
        {
            //sets gamemode to rotating marek mode and launches gamescreen
            Form1.gameMode = 3;
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameScreen());
        }

        //button starts easy mode
        private void easyModeButton_Click(object sender, EventArgs e)
        {
            //sets gamemode to easy mode and launches gamescreen
            Form1.gameMode = 4;
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
