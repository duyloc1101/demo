using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChessBoard();
            this.PlayerName = txtPlayerName;
            this.PlayerMark = pctbMark;
            this.player = new List<Player>()
            {
                new Player("PlayerName1", Image.FromFile(Application.StartupPath + @"\caroO.png")),
                new Player("PlayerName2", Image.FromFile(Application.StartupPath + @"\caroX.png"))
            };
            CurrentPlayer = 0;
            ChangePlayer();
           
            
        }
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;


        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get; private set; }

        void ChessBoard()
            {
                Matrix = new List<List<Button>>();
                Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
                for (int i = 0; i < Constain.boardHeight; i++)
                {
                    Matrix.Add(new List<Button>());
                    for (int j = 0; j < Constain.boardWidth; j++)
                    {
                        Button btn = new Button()
                        {
                            Width = Constain.chessWidth,
                            Height = Constain.chessHeight,
                            Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Tag = i.ToString()
                        };
                    btn.Click += Btn_Click;
                        pnlboard.Controls.Add(btn);
                        Matrix[i].Add(btn);
                        oldButton = btn;
                    }
                    oldButton.Location = new Point(0, oldButton.Location.Y + Constain.chessHeight);
                    oldButton.Width = 0;
                    oldButton.Height = 0;
                }
            }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            btn.BackgroundImage = Player[currentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();
            if (isEndGame(btn))
            {
                EndGame();
            }
            
        }
        private void EndGame()
        {
            MessageBox.Show("End Game!!");
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal,vertical);
            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >=0 ; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countLeft++;
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Constain.boardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countRight++;
                else
                    break;
            }

            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Constain.boardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countBottom++;
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Constain.boardWidth - point.X; i++)
            {
                if (point.Y + i >= Constain.boardHeight || point.X + i >= Constain.boardWidth )
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countBottom++;
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Constain.boardWidth || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Constain.boardWidth - point.X; i++)
            {
                if (point.Y + i >= Constain.boardHeight || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countBottom++;
                else
                    break;
            }

            return countTop + countBottom == 5;
        } 

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }

        private void tmCD_Tick(object sender, EventArgs e)
        {
            pgrCountDown.PerformStep();
            if (pgrCountDown.Value >= pgrCountDown.Maximum)
            {
               // Gameover();
            }

        }
        void newGame()
        { }
        void Undo()
        {

        }
        

        private void btNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Đóng form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

       
    }
}
