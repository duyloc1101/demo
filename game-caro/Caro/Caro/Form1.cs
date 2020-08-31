using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }
            void ChessBoard()
            {
                Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
                for (int i = 0; i < Constain.boardHeight; i++)
                {
                    for (int j = 0; j < Constain.boardWidth; j++)
                    {
                        Button btn = new Button()
                        {
                            Width = Constain.chessWidth,
                            Height = Constain.chessHeight,
                            Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                        };
                        pnlboard.Controls.Add(btn);
                        oldButton = btn;
                    }
                    oldButton.Location = new Point(0, oldButton.Location.Y + Constain.chessHeight);
                    oldButton.Width = 0;
                    oldButton.Height = 0;
                }
            }

        
    }
}
