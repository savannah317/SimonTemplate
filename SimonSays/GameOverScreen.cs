﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //show the length of the pattern
            lengthLabel.Text = Convert.ToString(Form1.patternList.Count);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close this screen and open the MenuScreen
            Form form = FindForm();
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
