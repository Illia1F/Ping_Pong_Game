using Ping_Pong_Logic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Ping_Pong
{
    /// <summary>
    /// This class is responsible for the proper operation of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            lvl = GlobalVariables.Levels.First(level => level.LevelId == (int)nLevels.Value);
            ballVelocityX = lvl.BallVelocityX;
            ballVelocityY = lvl.BallVelocityY;
            ballVelocity = ballVelocityY + ballVelocityX;

            ball = new Ball(18, 18,
                new Point(Ground.Width / 2 - 9, Ground.Height / 2 - 9),
                random.Next(2) == 1 ? ballVelocityX : -ballVelocityX,
                random.Next(2) == 1 ? ballVelocityY : -ballVelocityY,
                Brushes.Gray);

            myRacket = new Racket(23, 80,
                new Point(7, Ground.Height / 2),
                Brushes.Black);

            enemyRacket = new Racket(23, 80,
                new Point(Ground.Width - 7, Ground.Height / 2),
                Brushes.Black);

            ballMovementTimer.Interval = 10;
            ballMovementTimer.Tick += BallMovementTimer_Tick;

            racketMovementTimer.Interval = 10;
            racketMovementTimer.Tick += RacketMovementTimer_Tick;

            startNewRaoundTimer.Interval = 200;
            startNewRaoundTimer.Tick += StartNewRaoundTimer_Tick;

            Ground.Image = new Bitmap(Ground.Width, Ground.Height);
            graphics = Graphics.FromImage(Ground.Image);
            Draw();
        }

        private Timer ballMovementTimer = new Timer();
        private Timer racketMovementTimer = new Timer();
        private Timer startNewRaoundTimer = new Timer();

        #region Timers
        private void RacketMovementTimer_Tick(object sender, EventArgs e)
        {
            if(Math.Abs(ball.Position.X - enemyRacket.Position.X) <= Ground.Width / 2)
                enemyRacket.Move(ball.Position.Y - enemyRacket.Height / 2, lvl.EnemyVelocityY);

            int destY = PointToClient(Cursor.Position).Y;
            if (destY >= myRacket.Height / 3 && destY <= Ground.Height - myRacket.Height / 3)
                myRacket.Move(destY - myRacket.Height / 2);

            Draw();
        }

        private void BallMovementTimer_Tick(object sender, EventArgs e)
        {
            ball.Move();
            BallCollisionExists();
        }

        private int startNewRoundIterator = 0;
        private void StartNewRaoundTimer_Tick(object sender, EventArgs e)
        {
            lNewRound.Text = (startNewRoundIterator + 1).ToString();

            switch (startNewRoundIterator)
            {
                case 0:
                    startNewRoundIterator++;
                    lNewRound.Visible = true;
                    break;
                case 1:
                    startNewRoundIterator++;
                    break;
                case 2:
                    startNewRoundIterator++;
                    break;
                default:
                    startNewRoundIterator = 0;
                    startNewRaoundTimer.Stop();
                    lNewRound.Visible = false;
                    ballMovementTimer.Start();
                    break;
            }
        }
        #endregion

        private Graphics graphics;

        private Level lvl;
        private int ballVelocityX;
        private int ballVelocityY;
        private int ballVelocity;
        private Ball ball;
        private Racket myRacket;
        private Racket enemyRacket;

        private Random random = new Random();

        private int myScore = 0;
        private int enemyScore = 0;

        private void Draw()
        {
            graphics.Clear(Color.Green);
            graphics.DrawLine(Pens.White,
                Ground.Width / 2, 0, Ground.Width / 2,
                Ground.Height);

            ball.Draw(graphics);
            myRacket.Draw(graphics);
            enemyRacket.Draw(graphics);
            Ground.Refresh();
        }

        private void BallCollisionExists()
        {
            // collision with a top wall and a bottom wall
            if (ball.Top <= 0)
                ball.VelocityY = ballVelocityY;

            if (ball.Bottom >= Ground.Height)
                ball.VelocityY = -ballVelocityY;

            // collision with my racket
            if (ball.Left <= myRacket.Right &&
                ball.Bottom - ball.Width / 2 >= myRacket.Top &&
                ball.Top + ball.Width / 2 <= myRacket.Bottom)
            {
                ballVelocityY = Math.Abs(ball.VelocityY = RandVelocityY(ball.VelocityY < 0));
                ball.VelocityX = ballVelocityX = ballVelocity - ballVelocityY;
            }

            // collision with an enemy racket
            if (ball.Right >= enemyRacket.Left &&
                ball.Bottom - ball.Width / 2 >= enemyRacket.Top &&
                ball.Top + ball.Width / 2 <= enemyRacket.Bottom)
            {
                ballVelocityY = Math.Abs(ball.VelocityY = RandVelocityY(ball.VelocityY < 0));
                ball.VelocityX = -(ballVelocityX = ballVelocity - ballVelocityY);
            }

            // miss the ball and start a new round
            if (ball.Left <= 0)
            {
                lEnemyScore.Text = "Score: " + (++enemyScore).ToString();
                ReStart();
            }

            if (ball.Right >= Ground.Width)
            {
                lMyScore.Text = "Score: " + (++myScore).ToString();
                ReStart();
            }
        }

        private void ReStart()
        {
            lEnemyScore.Text = "Score: " + enemyScore.ToString();
            lMyScore.Text = "Score: " + myScore.ToString();

            ballVelocityY = Math.Abs(ball.VelocityY = RandVelocityY(ball.VelocityY < 0));
            ballVelocityX = lvl.BallVelocityX;
            ballVelocity = ballVelocityY + ballVelocityX;

            ballMovementTimer.Stop();

            ball.Position = new Point(Ground.Width / 2 - ball.Width / 2,
                Ground.Height / 2 - ball.Height / 2);
            ball.VelocityX = ball.VelocityX > 0 ? -ballVelocityX : ballVelocityX;

            startNewRaoundTimer.Start();
            racketMovementTimer.Start();
        }

        private int RandVelocityY(bool negative)
        {
            int y = random.Next(3, lvl.BallVelocityY + 1);
            return negative ? -y : y;
        }

        #region Buttons
        private void btnBall_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                ball.BackColor = new SolidBrush(color.Color);
                ball.Draw(graphics);
                Ground.Refresh();
            }
            Ground.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e) 
            => this.Close();

        private void btnStart_Click(object sender, EventArgs e)
        {
            myScore = 0;
            enemyScore = 0;
            ReStart();
            Ground.Focus();
        }
        #endregion

        #region Events
        private void nLevels_ValueChanged(object sender, EventArgs e)
        {
            lvl = GlobalVariables.Levels.First(level => level.LevelId == (int)nLevels.Value);
        }

        private bool pause = false;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // to unpause
            if (e.KeyCode == Keys.Space && pause)
            {
                ballMovementTimer.Start();
                pause = false;
                return;
            }

            // to pause
            if (e.KeyCode == Keys.Space && !pause)
            {
                ballMovementTimer.Stop();
                pause = true;
            }
        }
        #endregion
    }
}
