//Zack Gearhart
//3/18
//connect 4 game

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign5Gearhart
{
    public class Game
    {

        public Player CurrentPlayer { get; set; }
        public Panel GamePanel { get; set; }
        public Panel ButtonPanel { get; set; }
        public bool Winner { get; set; }
        public TextBox[,] GameBoard { get; set; }
        public List<Player> GamePlayers { get; set; }
        public TextBox MessageArea { get; set; }
        public Game() { }
        public Game(Panel gamePanel, Panel buttonPannel, TextBox messageArea, string playerOne, string playerTwo)
        {
            GamePanel = gamePanel;
            ButtonPanel = buttonPannel;
            GameBoard = new TextBox[6, 7];
            MessageArea = messageArea;

            Winner = false;
            GamePlayers = new List<Player>(2);
            GamePlayers.Add(new Player(playerOne));
            GamePlayers.Add(new Player(playerTwo));
            GamePlayers[0].Mark = "Blue";
            GamePlayers[1].Mark = "Red";
            CurrentPlayer = GamePlayers[1];

        }

        public void StartGame()
        {
            DrawBoard();
            DrawButtons();
        }

        private void DrawButtons()
        {
            ButtonPanel.Controls.Clear();
            int top = 0;
            int left = 0;
            int gutter = 11;
            int buttonwidth = 70;
            for (int x = 0; x <= GameBoard.GetUpperBound(1); x++)
            {
                Button abutton = new Button();
                abutton.Text = "Drop";
                abutton.Location = new Point(left, top);
                abutton.Width = buttonwidth;
                abutton.Click += Abutton_Click;
                abutton.Tag = x;
                ButtonPanel.Controls.Add(abutton);
                left += gutter + 70;
            }
        }

        private void Abutton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            PlacePeice(Convert.ToInt16(clickedButton.Tag));

        }

        public void DrawBoard()
        {
            GamePanel.Controls.Clear();
            MessageArea.Text = CurrentPlayer.ToString();
            Winner = false;
            int top = 0;
            int left = 0;

            for(int row = 0; row <= GameBoard.GetUpperBound(0); row++)
            {
                left = 0;
                for(int column = 0; column <= GameBoard.GetUpperBound(1); column++)
                {
                    TextBox aTextBox = new TextBox();
                    aTextBox.Multiline = true;
                    aTextBox.ReadOnly = true;
                    aTextBox.Size = new Size(80, 80);
                    aTextBox.BorderStyle = BorderStyle.FixedSingle;
                    aTextBox.Location = new Point(left, top);;
                    aTextBox.TextAlign = HorizontalAlignment.Center;
                    aTextBox.BackColor = Color.FromName("white");
                    GameBoard[row, column] = aTextBox;
                    GamePanel.Controls.Add(aTextBox);
                    left += 80;

                }
                top += 80;
            }
        }

        private void CheckForWin(int row, int column)
        {
            if (CheckRowWin(row) || CheckColumnWin(column)){}
            if (Winner)
            {
                WinnerMessage();
            }
        }


        private bool CheckColumnWin( int column)
        {
                int counter = 0;
                if (!Winner)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (GameBoard[i, column].BackColor.ToString() == Color.FromName(CurrentPlayer.Mark).ToString())
                        {
                            counter++;
                           
                            if (counter >= 4)
                            {
                                Winner = true;
                                break;
                            }
                        }
                        else
                        {
                            counter = 0;
                        }
                    }
                }
            return Winner;
          
        }

        private bool CheckRowWin(int row)
        {
            int counter = 0;
            if (!Winner)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (GameBoard[row, i].BackColor.ToString() == Color.FromName(CurrentPlayer.Mark).ToString())
                    {
                        counter++;
                        if (counter >= 4)
                        {
                            Winner = true;
                            break;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }
            return Winner;
        }

        private void NextPlayer()
        {
            if(CurrentPlayer == GamePlayers[0])
            {
                CurrentPlayer = GamePlayers[1];
                MessageArea.Text = CurrentPlayer.ToString();
            }
            else
            {
                CurrentPlayer = GamePlayers[0];
                MessageArea.Text = CurrentPlayer.ToString();
            }
        }
        public void PlacePeice(int column)
        {
            for(int row=0; row <= GameBoard.GetUpperBound(0); row++)
            {
                if (GameBoard[0, column].BackColor == Color.FromName("white") && !Winner)
                {
                    if (row < 5)
                    {
                        if (GameBoard[row+1, column].BackColor == Color.FromName("white"))
                        {
                            CheckForWin(row, column);
                        }
                        else
                        {
                            SetPiece(row, column);
                            if (!Winner)
                            {
                                NextPlayer();
                            }
                            break;
                        }
                    }
                    else
                    {
                        SetPiece(row, column);
                        if (!Winner)
                        {
                            NextPlayer();
                        }
                    }
                }
            }
        }

        private void WinnerMessage()
        {
            MessageArea.Text = "Game Over " + CurrentPlayer.PlayerName + " has won.";
            CurrentPlayer.NumberWins++;
            GamePlayers[0].NumberPlayed++;
            GamePlayers[1].NumberPlayed++;
        }

        private void SetPiece(int row, int column)
        {
            GameBoard[row, column].BackColor = Color.FromName(CurrentPlayer.Mark);
            CheckForWin(row, column);
        }
    }
}
