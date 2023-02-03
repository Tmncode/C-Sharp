using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HighScore
{
    public partial class frmHighScore : Form
    {
        // Default constructor created
        public frmHighScore()
        {
            InitializeComponent();
        }
        //Create counter to start the game at zero, set it to 0
        int counter = 0;
        //Create String[] array guess A B C
        String[] guess = { "A", "B", "C" };
        //Create number of rounds, set it to 0
        int numOfRounds = 0;
        StreamReader fileStreams = new StreamReader(@"D:\C#\CSharp.Chapter.14\score.txt");
        //Create total score
        int totalScore;
        int y;
        Random rand = new Random();
        private void frmHighScoreLoad(object sender, EventArgs e)
        {
            totalScore = Convert.ToInt32(fileStreams.ReadLine());
            lblHighScore.Text = totalScore.ToString();
            lblScore.Text = counter.ToString();
            y = rand.Next(2);
        }
        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            if(numOfRounds != 10)
            {
                String valueAnswer = tbLetter.Text;
                if ((valueAnswer.ToUpper()).CompareTo(guess[y]) == 0)
                {
                    counter++;
                    lblScore.Text = counter.ToString();
                    MessageBox.Show("Correct");
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }
                numOfRounds++;
            }
            else
            {
                if(totalScore <= counter)
                {
                    MessageBox.Show("Guessing numOfRounds ends.\n Your totalScore is: " + counter + "\n" +
                        "Congratulation! You have made a high totalScore");
                    fileStreams.Close();
                    StreamWriter readWrite = new StreamWriter(@"D:\C#\CSharp.Chapter.14\score.txt");
                    readWrite.WriteLine(counter);
                    readWrite.Close();
                    lblHighScore.Text = counter.ToString();

                    totalScore = counter;
                }
                else
                    MessageBox.Show("Guess numOfRounds ends.\n Your totalScore is: " + counter + "\n" +
                        "Sorry! You have not made a high totalScore");
                numOfRounds = 0; counter = 0;
            }
            y = rand.Next(2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLetter.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fileStreams.Close();

            if(totalScore <= counter)
            {
                StreamWriter readWrite = new StreamWriter(@"D:\C#\CSharp.Chapter.14\score.txt");
                readWrite.WriteLine(counter);
                readWrite.Close();
            }
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (totalScore <= counter)
            {
                MessageBox.Show("Starting new game.\n" +
                    "Your current totalScore is: " + counter + "\n" +
                    "Congratulation! You have made a high totalScore");
                fileStreams.Close();
                totalScore = counter;

                StreamWriter readWrite = new StreamWriter(@"D:\C#\CSharp.Chapter.14\score.txt");
                readWrite.WriteLine(counter);
                readWrite.Close();
                lblHighScore.Text = counter.ToString();
            }
            else
                MessageBox.Show("Starting new game .\n " +
                    "Your current totalScore is: " + counter + "\n" +
                    "Sorry! You have not made a high totalScore");
            numOfRounds = 0; counter = 0;
            y = rand.Next(2);
        }
    }
}
