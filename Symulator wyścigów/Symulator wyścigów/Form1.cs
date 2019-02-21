using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray;
        Guy[] GuyArray;

        public Form1()
        {
            InitializeComponent();


            GreyhoundArray = new Greyhound[4]
            {
            new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = RacetrackPictureBox.Width - pictureBox1.Width
            },

            new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = RacetrackPictureBox.Width - pictureBox2.Width
            },

            new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = RacetrackPictureBox.Width - pictureBox3.Width
            },

            new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = RacetrackPictureBox.Width - pictureBox4.Width
            }
            };


            GuyArray = new Guy[3]
            {
            new Guy()
                {
                    Name = "Janek",
                    Cash = 50,
                    MyRadioButton = JanekRadioButton,
                    MyTextBox = JanekBetTextBox
                },

            new Guy()
                {
                    Name = "Bartek",
                    Cash = 75,
                    MyRadioButton = BartekRadioButton,
                    MyTextBox = BartekBetTextBox
                },
        
             new Guy()
                 {
                    Name = "Arek",
                    Cash = 45,
                    MyRadioButton = ArekRadioButton,
                    MyTextBox = textBox3
                 }
            };

            UpdateRadioButton();
            nameLabel.Text = "Janek";
        }

        private void UpdateRadioButton()
        {
            foreach (var Guy in GuyArray)
            {
                Guy.updateRadioButton();
            }
        }

        public void stawiaButton_Click(object sender, EventArgs e)
        {

            foreach (var Guy in GuyArray)
            {
                if (Guy.MyRadioButton.Checked)
                {
                    Guy.PlaceBet((int)ileStawiaNumeric.Value, (int)(ktoryChartNumeric.Value - 1));
                    break;
                }
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Chart numer " + (i + 1).ToString() + " wygrywa!");
                    giveOrTakeMoney(i);
                    resetDogs();
                    groupBox1.Enabled = true;
                    break;
                }
            }
        }

        private void giveOrTakeMoney(int Winner)
        {
            foreach (var Guy in GuyArray)
            {
                if (Guy.isBetting)
                {
                    Guy.Collect(Winner);
                }
            }
        }

        private void resetDogs()
        {
            foreach (var Dog in GreyhoundArray)
            {
                Dog.TakeStartingPosition();
            }

            clearLabel();
        }

        private void clearLabel()
        {
            JanekBetTextBox.Text = "";
            BartekBetTextBox.Text = "";
            textBox3.Text = "";
        }

        private void JanekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Janek";
        }

        private void BartekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bartek";
        }

        private void ArekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Arek";
        }
    }
}