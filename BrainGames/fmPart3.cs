using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGames
{
    public partial class fmPart3 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public fmPart3()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnwerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Beeindigd!" + Environment.NewLine +
                    "Je hebt " + score + " vragen beantwoord." + Environment.NewLine +
                    "Jouw totale score: " + percentage + "%" + Environment.NewLine +
                    "Druk OK om opnieuw te spelen"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.plaets;

                    lblQuestion.Text = "In 2004 landde de NASA-rover Spirit met succes op welke planeet?";

                    btnFirst.Text = "Mars";
                    btnSecond.Text = "Maan";
                    btnThird.Text = "Venus";
                    btnFourth.Text = "Jupiter";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.wallhaven_0w655p;
     
                    lblQuestion.Text = "Druk 71/1000 uit als een decimaal.";

                    btnFirst.Text = ".71";
                    btnSecond.Text = ".0071";
                    btnThird.Text = ".071";
                    btnFourth.Text = "7.1";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.wallhaven_4yx36x;

                    lblQuestion.Text = "Wat is het diepste meer ter wereld?";

                    btnFirst.Text = "Lough Neagh";
                    btnSecond.Text = "Lake Baikal";
                    btnThird.Text = "Lake Superior";
                    btnFourth.Text = "Lake Victoria";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.wallhaven_6ql7v6;

                    lblQuestion.Text = "Hoe noemden de Romeinen Schotland?";

                    btnFirst.Text = "Caledonia";
                    btnSecond.Text = "Placentia   ";
                    btnThird.Text = "Bononia";
                    btnFourth.Text = "Palma";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.wallhaven_0w655p;

                    lblQuestion.Text = "456 * 32 =?";

                    btnFirst.Text = "14592";
                    btnSecond.Text = "15432";
                    btnThird.Text = "13457";
                    btnFourth.Text = "15432";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.wallhaven_nrd6vq;

                    lblQuestion.Text = "Wat is de hoogste berg van Europa?";

                    btnFirst.Text = "Coma Pedrosa";
                    btnSecond.Text = "Mount Bazardüzü";
                    btnThird.Text = "Mount Korab";
                    btnFourth.Text = "Dinara";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.wallhaven_47ywjy;

                    lblQuestion.Text = "Welk populair fastfoodketen werd geopend in 1955?";

                    btnFirst.Text = "Papa John’s Pizza";
                    btnSecond.Text = "McDonald's";
                    btnThird.Text = "Burger King";
                    btnFourth.Text = "Dunkin’ Donuts";

                    correctAnswer = 2;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.wallhaven_gjgz27;

                    lblQuestion.Text = "Welke rivier stroomt door Parijs?";

                    btnFirst.Text = "Rijn";
                    btnSecond.Text = "Loire";
                    btnThird.Text = "Lauter";
                    btnFourth.Text = "Seine River";

                    correctAnswer = 4;
                    break;
            }
        }
        }
    }
