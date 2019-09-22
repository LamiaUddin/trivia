using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerScienceTrivia
{

    public partial class frmGamePage : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        int countdown=0;     
        int score; 
        Random rnd  = new Random();
        int numberOne;
        int numberTwo;
        int numberThree;
        public frmGamePage()
        {
            InitializeComponent();
        }

        private void btnUnitThreeLevelThree_Click(object sender, EventArgs e)
        {
            numberOne = rnd.Next(5, 10);
            lblNumberOne.Text = numberOne.ToString();
            numberTwo = rnd.Next(1, 10);
            lblNumberTwo.Text = numberTwo.ToString();
            numberThree = rnd.Next(1, 10);
            lblNumberThree.Text = numberThree.ToString();
            panelTopicsAndQuestions.Hide();
            panelU3L3Q1.Show();
            panelU3L3Q1.Location = new Point(7, 61);//sets the location where the panel should pop up
            panelU3L3Q1.Size = panelTopicsAndQuestions.Size;//sets size of the panel so it fits into the space the topics are at
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20"; 
          
        }

        private void btnUnitOneLevelOne_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU1L1Q1.Show();
            panelU1L1Q1.Location = new Point(7, 61);
            panelU1L1Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20"; 
        }

        private void btnU1L1Q2Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU1L1Q1Correct.Checked) && chkU1L1Q1Incorrect.Checked == false && chkU1L1Q1Incorrect2.Checked == false && chkU1L1Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 100;
            }
            else if ((chkU1L1Q1Incorrect.Checked)||(chkU1L1Q1Incorrect2.Checked)||(chkU1L1Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 100;
            }
            else
            {
                 MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU1L1Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitOneLevelOne.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
                
        }

        private void btnUnitOneLevelTwo_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU1L2Q1.Show();
            panelU1L2Q1.Location = new Point(7, 61);
            panelU1L2Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
       

        }

        private void btnU1L2Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU1L2Q1Correct.Checked) && chkU1L2Q1Incorrect.Checked == false && chkU1L2Q1Incorrect2.Checked == false && chkU1L2Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 200;
            }
            else if ((chkU1L2Q1Incorrect.Checked) || (chkU1L2Q1Incorrect2.Checked) || (chkU1L2Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 200;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU1L2Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitOneLevelTwo.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown = countdown + 1;
            lblTimer.Text = "Time Left:" + (20 - countdown).ToString();
            if (countdown == 20)
            {
                timer1.Stop();
                MessageBox.Show("Times Up");
                panelU2L4Q1.Hide();
                panelU4L4Q1.Hide();
                panelU3L4Q1.Hide();
                panelU2L3Q1.Hide();
                panelU1L1Q1.Hide();
                panelU1L2Q1.Hide();
                panelU1L3Q1.Hide();
                panelU3L3Q1.Hide();
                panelU1L4Q1.Hide();
                panelU2L2Q1.Hide();
                panelU3L1Q1.Hide();
                panelU3L2Q1.Hide();
                panelU4L1Q1.Hide();
                panelU4L2Q1.Hide();
                panelU4L3Q1.Hide();
                panelU2L1Q1.Hide();
                panelTopicsAndQuestions.Show();
                lblTimer.Text = "Time Left:";
            }

        }

        private void frmGamePage_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "../../Resources/Jeopardy-theme-song.wav";//plays the background music
            player.PlayLooping();//loops the background music
            panelTopicsAndQuestions.Visible = true;
            panelU4L4Q1.Visible = false;//makes question panels invisible at the start of the game
            panelU2L4Q1.Visible = false;
            panelU3L4Q1.Visible = false;
            panelU2L3Q1.Visible = false;
            panelU1L1Q1.Visible = false;
            panelU1L2Q1.Visible = false;
            panelU1L3Q1.Visible = false;
            panelU3L3Q1.Visible = false;
            panelU2L1Q1.Visible = false;
            panelU2L2Q1.Visible = false;
            panelU3L1Q1.Visible = false;
            panelU3L2Q1.Visible = false;
            panelU4L1Q1.Visible = false;
            panelU4L2Q1.Visible = false;
            panelU4L3Q1.Visible = false;
            panelU1L4Q1.Visible = false;
        }

       
        private void btnUnitOneLevelThree_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU1L2Q1.Hide();
            panelU1L1Q1.Hide();
            panelU1L3Q1.Show();
            panelU1L3Q1.Location = new Point(7, 61);
            panelU1L3Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU1L3Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU1L3Q1Correct.Checked) && chkU1L3Q1Incorrect.Checked == false && chkU1L3Q1Incorrect2.Checked == false && chkU1L3Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 300;
            }
            else if ((chkU1L3Q1Incorrect.Checked) || (chkU1L3Q1Incorrect2.Checked) || (chkU1L3Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 300;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU1L3Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitOneLevelThree.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitFourLevelOne_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU4L1Q1.Show();
            panelU4L1Q1.Location = new Point(7, 61);
            panelU4L1Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
            
        }

        private void btnU3L3Q1Check_Click(object sender, EventArgs e)
        {
            int rightAnswer = (numberOne) % (numberTwo) * (numberThree);//finds the actual answer to the question
            int givenAnswer = int.Parse(txtAnswer.Text);
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if (givenAnswer == rightAnswer)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 300;
            }
            else
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 300;
            }
            txtAnswer.Text = "";
            lblScore.Text = "Score: " + score.ToString();
            panelU3L3Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitThreeLevelThree.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
            txtAnswer.Text = "";
        }

        private void btnU2L1Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU2L1Q1Correct.Checked) && chkU2L1Q1Incorrect.Checked == false && chkU2L1Q1Incorrect2.Checked == false && chkU2L1Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 100;
            }
            else if ((chkU2L1Q1Incorrect.Checked) || (chkU2L1Q1Incorrect2.Checked) || (chkU2L1Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 100;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU2L1Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitTwoLevelOne.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitTwoLevelOne_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU2L1Q1.Show();
            panelU2L1Q1.Location = new Point(7, 61);
            panelU2L1Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnUnitTwoLevelTwo_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU2L2Q1.Show();
            panelU2L2Q1.Location = new Point(7, 61);
            panelU2L2Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU2L2Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU2L2Q1Correct.Checked) && chkU2L2Q1Incorrect.Checked == false && chkU2L2Q1Incorrect2.Checked == false && chkU2L2Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 200;
            }
            else if ((chkU2L2Q1Incorrect.Checked) || (chkU2L2Q1Incorrect2.Checked) || (chkU2L2Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 200;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU2L2Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitTwoLevelTwo.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitThreeLevelOne_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU3L1Q1.Show();
            panelU3L1Q1.Location = new Point(7, 61);
            panelU3L1Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU3L1Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU3L1Q1Correct.Checked) && chkU3L1Q1Incorrect.Checked == false && chkU2L1Q1Incorrect2.Checked == false && chkU3L1Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 100;
            }
            else if ((chkU3L1Q1Incorrect.Checked) || (chkU3L1Q1Incorrect2.Checked) || (chkU3L1Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 100;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU3L1Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitThreeLevelOne.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitThreeLevelTwo_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU3L2Q1.Show();
            panelU3L2Q1.Location = new Point(7, 61);
            panelU3L2Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU3L2Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((txtErrorOne.Text == "runtime" || txtErrorOne.Text == "logic" || txtErrorOne.Text == "syntax") && (txtErrorTwo.Text == "runtime" || txtErrorTwo.Text == "logic" || txtErrorTwo.Text == "syntax") && (txtErrorThree.Text == "runtime" || txtErrorThree.Text == "logic" || txtErrorThree.Text == "syntax") )
            {
                MessageBox.Show("Correct Answer!");
                score = score + 200;
            }
            else 
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 200;
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU3L2Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitThreeLevelTwo.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
            txtErrorOne.Text = "";
            txtErrorThree.Text = "";
            txtErrorTwo.Text = ""; 
        }

        private void btnU4L1Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU4L1Q1Correct.Checked) && chkU4L1Q1Incorrect.Checked == false && chkU4L1Q1Incorrect2.Checked == false && chkU4L1Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 100;
            }
            else if ((chkU4L1Q1Incorrect.Checked) || (chkU4L1Q1Incorrect2.Checked) || (chkU4L1Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 100;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU4L1Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitFourLevelOne.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitFourLevelTwo_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU4L2Q1.Show();
            panelU4L2Q1.Location = new Point(7, 61);
            panelU4L2Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU4L2Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU4L2Q1Correct.Checked) && chkU4L2Q1Incorrect.Checked == false && chkU4L2Q1Incorrect2.Checked == false && chkU4L2Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 200;
            }
            else if ((chkU4L2Q1Incorrect.Checked) || (chkU4L2Q1Incorrect2.Checked) || (chkU4L2Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 200;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU4L2Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitFourLevelTwo.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitFourLevelThree_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU4L3Q1.Show();
            panelU4L3Q1.Location = new Point(7, 61);
            panelU4L3Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU4L3Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU4L3Q1Correct.Checked) && chkU4L3Q1Incorrect.Checked == false && chkU4L3Q1Incorrect2.Checked == false && chkU4L3Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 300;
            }
            else if ((chkU4L3Q1Incorrect.Checked) || (chkU4L3Q1Incorrect2.Checked) || (chkU4L3Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 300;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU4L3Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitFourLevelThree.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }


        private void btnUnitThreeLevelThree_Click_1(object sender, EventArgs e)
        {
            numberOne = rnd.Next(5, 10);
            lblNumberOne.Text = numberOne.ToString();
            numberTwo = rnd.Next(1, 10);
            lblNumberTwo.Text = numberTwo.ToString();
            numberThree = rnd.Next(1, 10);
            lblNumberThree.Text = numberThree.ToString();
            panelTopicsAndQuestions.Hide();
            panelU3L3Q1.Show();
            panelU3L3Q1.Location = new Point(7, 61);
            panelU3L3Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20"; 
        }

        private void panelU3L1Q1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUnitThreeLevelFour_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU3L4Q1.Show();
            panelU3L4Q1.Location = new Point(7, 61);
            panelU3L4Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnUnitOneLevelFour_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU1L4Q1.Show();
            panelU1L4Q1.Location = new Point(7, 61);
            panelU1L4Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU1L4Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU1L4Q1Correct.Checked) && chkU1L4Q1Incorrect.Checked == false && chkU1L4Q1Incorrect2.Checked == false && chkU1L4Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 400;
            }
            else if ((chkU1L4Q1Incorrect.Checked) || (chkU1L4Q1Incorrect2.Checked) || (chkU1L4Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 400;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU1L4Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitOneLevelFour.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnUnitTwoLevelThree_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU2L3Q1.Show();
            panelU2L3Q1.Location = new Point(7, 61);
            panelU2L3Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU2L3Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU2L3Q1Correct.Checked) && chkU2L3Q1Incorrect.Checked == false && chkU2L3Q1Incorrect2.Checked == false && chkU2L3Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 300;
            }
            else if ((chkU2L3Q1Incorrect.Checked) || (chkU2L3Q1Incorrect2.Checked) || (chkU2L3Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 300;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU2L3Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitTwoLevelThree.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHowToPage frm = new frmHowToPage();
            this.Hide();
            frm.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnU3L4Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU3L4Q1Correct.Checked) && chkU3L4Q1Incorrect.Checked == false && chkU3L4Q1Incorrect2.Checked == false && chkU3L4Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 400;
            }
            else if ((chkU3L4Q1Incorrect.Checked) || (chkU3L4Q1Incorrect2.Checked) || (chkU3L4Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 400;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU3L4Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitThreeLevelFour.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void grpTopics_Enter(object sender, EventArgs e)
        {

        }

        private void btnUnitFourLevelFour_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU4L4Q1.Show();
            panelU4L4Q1.Location = new Point(7, 61);
            panelU4L4Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";
        }

        private void btnU4L4Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU4L4Q1Correct.Checked) && chkU4L4Q1Incorrect.Checked == false && chkU4L4Q1Incorrect2.Checked == false && chkU4L4Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 400;
            }
            else if ((chkU4L4Q1Incorrect.Checked) || (chkU4L4Q1Incorrect2.Checked) || (chkU4L4Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 400;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU4L4Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitFourLevelFour.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

        private void chkU2L4Q1Incorrect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUnitTwoLevelFour_Click(object sender, EventArgs e)
        {
            panelTopicsAndQuestions.Hide();
            panelU2L4Q1.Show();
            panelU2L4Q1.Location = new Point(7, 61);
            panelU2L4Q1.Size = panelTopicsAndQuestions.Size;
            timer1.Start();
            countdown = 0;
            lblTimer.Text = "Time left: 20";

        }

        private void btnU2L4Q1Check_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimer.Text = "Time left:";
            if ((chkU2L4Q1Correct.Checked) && chkU2L4Q1Incorrect.Checked == false && chkU2L4Q1Incorrect2.Checked == false && chkU2L4Q1Incorrect3.Checked == false)
            {
                MessageBox.Show("Correct Answer!");
                score = score + 400;
            }
            else if ((chkU2L4Q1Incorrect.Checked) || (chkU2L4Q1Incorrect2.Checked) || (chkU2L4Q1Incorrect3.Checked))
            {
                MessageBox.Show("Incorrect Answer");
                score = score - 400;
            }
            else
            {
                MessageBox.Show("Invalid Answer");
            }
            lblScore.Text = "Score: " + score.ToString();
            panelU2L4Q1.Hide();
            panelTopicsAndQuestions.Show();
            btnUnitTwoLevelFour.BackColor = System.Drawing.Color.Gray;//set colour of level gray to indicate that it can't be played anymore
        }

    }
}
