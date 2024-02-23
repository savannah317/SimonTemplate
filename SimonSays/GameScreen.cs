using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //create sounds
        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer endSound = new SoundPlayer(Properties.Resources.mistake);

        //create an int guess variable to track what part of the pattern the user is at
        int guess = 0;
        int delayTime = 400;
        int greenPos = 1;
        int redPos = 2;
        int yellowPos = 3;
        int bluePos = 4;
        int marekCounter = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        public void GameScreen_Load(object sender, EventArgs e)
        {
            if (Form1.gameMode == 2 || Form1.gameMode == 3)
            {
                //changes colours to marek
                greenButton.BackColor = Color.Transparent;
                greenButton.Image = Properties.Resources.marekbobot;
                redButton.BackColor = Color.Transparent;
                redButton.Image = Properties.Resources.marekMewing1;
                yellowButton.BackColor = Color.Transparent;
                yellowButton.Image = Properties.Resources.marek4s;
                blueButton.BackColor = Color.Transparent;
                blueButton.Image = Properties.Resources.marekCharacterSelect;
            }
            if (Form1.gameMode == 4)
            {
                //hides every button except red button
                greenButton.Visible = false;
                greenButton.Enabled = false;
                yellowButton.Visible = false;
                yellowButton.Enabled = false;
                blueButton.Visible = false;
                blueButton.Enabled = false;
                //creation of the marek counter
                marekLabel.Visible = true;
                counterLabel.Text = marekCounter.ToString();
                counterLabel.Visible = true;
                //changes size of red button
                redButton.Location = new Point(40, 37);
                redButton.Size = new Size(220, 220);
            }
            //clear the pattern list from form1 and call computer turn
            Form1.patternList.Clear();
            Refresh();
            Thread.Sleep(50);
            ComputerTurn();
        }
        public void Rotation(int position, Button button)
        {
            //depending on the location of the button, move buttons accordingly
            switch (position)
            {
                //button in top left move to top right
                case 1:
                    button.Location = new Point(152, 37);
                    if (button == greenButton)
                    {
                        greenPos = 2;
                    }
                    if (button == redButton)
                    {
                        redPos = 2;
                    }
                    if (button == yellowButton)
                    {
                        yellowPos = 2;
                    }
                    if (button == blueButton)
                    {
                        bluePos = 2;
                    }
                    break;
                    //button in top right move to bottom right
                case 2:
                    button.Location = new Point(152, 149);
                    if (button == greenButton)
                    {
                        greenPos = 4;
                    }
                    if (button == redButton)
                    {
                        redPos = 4;
                    }
                    if (button == yellowButton)
                    {
                        yellowPos = 4;
                    }
                    if (button == blueButton)
                    {
                        bluePos = 4;
                    }
                    break;
                    //button in bottom left moves to top left
                case 3:
                    button.Location = new Point(40, 37);
                    if (button == greenButton)
                    {
                        greenPos = 1;
                    }
                    if (button == redButton)
                    {
                        redPos = 1;
                    }
                    if (button == yellowButton)
                    {
                        yellowPos = 1;
                    }
                    if (button == blueButton)
                    {
                        bluePos = 1;
                    }
                    break;
                    //button in bottom right moves to bottom left
                case 4:
                    button.Location = new Point(40, 149);
                    if (button == greenButton)
                    {
                        greenPos = 3;
                    }
                    if (button == redButton)
                    {
                        redPos = 3;
                    }
                    if (button == yellowButton)
                    {
                        yellowPos = 3;
                    }
                    if (button == blueButton)
                    {
                        bluePos = 3;
                    }
                    break;
            }
        }

        private void ComputerTurn()
        {
            Thread.Sleep(delayTime);

            //only one button in easy mode so make the only value in pattern list 1
            if (Form1.gameMode == 4)
            {
                Form1.patternList.Add(1);
            }
            //get random value between 0 and 4 to determine the colour of the button that lights up
            else
            {
                //rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
                Random randGen = new Random();
                int randValue = randGen.Next(0, 4);
                Form1.patternList.Add(randValue);
            }

            //show each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.patternList.Count; i++)
            {
                if (Form1.gameMode == 0 || Form1.gameMode == 1)
                {
                    if (Form1.patternList[i] == 0) //green
                    {
                        greenSound.Play();
                        greenButton.BackColor = Color.White;
                        Refresh();
                        Thread.Sleep(delayTime);
                        greenButton.BackColor = Color.ForestGreen;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 1) //red
                    {
                        redSound.Play();
                        redButton.BackColor = Color.White;
                        Refresh();
                        Thread.Sleep(delayTime);
                        redButton.BackColor = Color.DarkRed;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 2) //yellow
                    {
                        yellowSound.Play();
                        yellowButton.BackColor = Color.White;
                        Refresh();
                        Thread.Sleep(delayTime);
                        yellowButton.BackColor = Color.Goldenrod;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 3) //blue
                    {
                        blueSound.Play();
                        blueButton.BackColor = Color.White;
                        Refresh();
                        Thread.Sleep(delayTime);
                        blueButton.BackColor = Color.DarkBlue;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                }
                //same idea but with pics of marek
                if (Form1.gameMode == 2 || Form1.gameMode == 3)
                {
                    if (Form1.patternList[i] == 0) //green
                    {
                        greenSound.Play();
                        greenButton.Image = Properties.Resources.marekMewing2;
                        Refresh();
                        Thread.Sleep(delayTime);
                        greenButton.Image = Properties.Resources.marekbobot;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 1) //red
                    {
                        redSound.Play();
                        redButton.Image = Properties.Resources.marekMewing2;
                        Refresh();
                        Thread.Sleep(delayTime);
                        redButton.Image = Properties.Resources.marekMewing1;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 2) //yellow
                    {
                        yellowSound.Play();
                        yellowButton.Image = Properties.Resources.marekMewing2;
                        Refresh();
                        Thread.Sleep(delayTime);
                        yellowButton.Image = Properties.Resources.marek4s;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                    if (Form1.patternList[i] == 3) //blue
                    {
                        blueSound.Play();
                        blueButton.Image = Properties.Resources.marekMewing2;
                        Refresh();
                        Thread.Sleep(delayTime);
                        blueButton.Image = Properties.Resources.marekCharacterSelect;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                }
                //same idea but combined and theres only one button
                if (Form1.gameMode == 4)
                {
                    if (Form1.patternList[i] == 1) //red
                    {
                        redSound.Play();
                        redButton.BackgroundImage = Properties.Resources.marekMewing2;
                        marekCounter++;
                        counterLabel.Text = marekCounter.ToString();
                        Refresh();
                        Thread.Sleep(delayTime);
                        redButton.BackgroundImage = null;
                        redButton.BackColor = Color.DarkRed;
                        Refresh();
                        Thread.Sleep(delayTime);
                    }
                }
            }
            if (Form1.gameMode == 1 || Form1.gameMode == 3)
            {
                Rotation(greenPos, greenButton);
                Rotation(redPos, redButton);
                Rotation(yellowPos, yellowButton);
                Rotation(bluePos, blueButton);
            }
            //set guess value back to 0
            guess = 0;
        }

        //green button presses 
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 0)
            {
                //plays sound
                greenSound.Play();
                //depending on the game mode change colour or picture on green button
                if (Form1.gameMode == 0 || Form1.gameMode == 1)
                {
                    greenButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delayTime);
                    greenButton.BackColor = Color.DarkGreen;
                }
                if (Form1.gameMode == 2 || Form1.gameMode == 3)
                {
                    greenButton.Image = Properties.Resources.marekMewing2;
                    Refresh();
                    Thread.Sleep(delayTime);
                    greenButton.Image = Properties.Resources.marekbobot;
                }
                Refresh();
                //add a guess
                guess++;
                Thread.Sleep(delayTime);
            }
            //any other button pressed ends the round
            else
            {
                GameOver();
            }
            //calls computer turn after guesses equal the length of the pattern list
            if (guess == Form1.patternList.Count) 
            {
                ComputerTurn();
            }
        }

        //blue button presses
        //does the same thing as green
        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 3)
            {
                blueSound.Play();
                if (Form1.gameMode == 0 || Form1.gameMode == 1)
                {
                    blueButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delayTime);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                }
                if (Form1.gameMode == 2 || Form1.gameMode == 3)
                    {
                        blueButton.Image = Properties.Resources.marekMewing2;
                        Refresh();
                        Thread.Sleep(delayTime);
                        blueButton.Image = Properties.Resources.marekCharacterSelect;
                        Refresh();
                    }
                    guess++;
                Thread.Sleep(delayTime);
            }
            else
            {
                GameOver();
            }
            if (guess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        //red button presses
        //does the same thing as green other than added easy section
        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 1)
            {
                redSound.Play();
                //on easy mode red is the only button
                if (Form1.gameMode == 4)
                {
                    //add one to marek counter when the button is pressed and display the number
                    marekCounter++;
                    counterLabel.Text = marekCounter.ToString();
                    redButton.BackgroundImage = Properties.Resources.marekMewing2;
                    Refresh();
                    Thread.Sleep(delayTime);
                    redButton.BackgroundImage = null;
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    //make the give up button appear because you can't lose easy mode unless its broken
                    if (marekCounter >= 10)
                    {
                        endButton.Visible = true;
                        endButton.Enabled = true;
                    }
                }
                //other game modes function same as the green and blue buttons
                if (Form1.gameMode == 0 || Form1.gameMode == 1)
                {
                    redButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delayTime);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }
                if (Form1.gameMode == 2 || Form1.gameMode == 3)
                {
                    redButton.Image = Properties.Resources.marekMewing2;
                    Refresh();
                    Thread.Sleep(delayTime);
                    redButton.Image = Properties.Resources.marekMewing1;
                    Refresh();
                }
                guess++;
                Thread.Sleep(delayTime);
            }
            else
            {
                GameOver();
            }
            if (guess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        //yellow button presses
        //does the same thing as green
        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 2)
            {
                yellowSound.Play();
                if (Form1.gameMode == 0 || Form1.gameMode == 1)
                {
                    yellowButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(delayTime);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }
                if (Form1.gameMode == 2 || Form1.gameMode == 3)
                {
                    yellowButton.Image = Properties.Resources.marekMewing2;
                    Refresh();
                    Thread.Sleep(delayTime);
                    yellowButton.Image = Properties.Resources.marek4s;
                    Refresh();
                }
                guess++;
                Thread.Sleep(delayTime);
            }
            else
            {
                GameOver();
            }
            if (guess == Form1.patternList.Count)
            {
                ComputerTurn();
            }
        }

        public void GameOver()
        {
            //play game over sound
            endSound.Play();

            //close this screen and open the GameOverScreen
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameOverScreen());
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            //close this screen and open the GameOverScreen
            Form form = FindForm();
            Form1.ChangeScreen(this, new GameOverScreen());
        }
    }
}
