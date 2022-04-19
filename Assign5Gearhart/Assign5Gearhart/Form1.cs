//Zack Gearhart
//3/18
//connect 4 game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign5Gearhart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Game theGame = null;

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                theGame = new Game(pnlGameBoard, pnlButtonBoard, txtMessagebox, txtPlayerOneName.Text, txtPlayerTwoName.Text);
                theGame.StartGame();
                btnStartGame.Enabled = false;
                txtPlayerOneName.ReadOnly = true;
                txtPlayerTwoName.ReadOnly = true;
                btnRestart.Enabled = true;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsString(txtPlayerOneName.Text, "Player One");
            errorMessage += IsString(txtPlayerTwoName.Text, "Player Two");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private static string IsString(string value, string name)
        {
            string msg = "";
            if (String.IsNullOrEmpty(value))
            {
                msg += name + " must be a valid String value. \n";
            }
            return msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnStartGame.Enabled == false)
            {
                MessageBox.Show(theGame.GamePlayers[0].PlayerName + " \tWins: " + theGame.GamePlayers[0].NumberWins + " out of " + theGame.GamePlayers[0].NumberPlayed + "\n" + theGame.GamePlayers[1].PlayerName + " \tWins: " + theGame.GamePlayers[1].NumberWins + " out of " + theGame.GamePlayers[1].NumberPlayed, "Results");
            }
                this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            theGame.DrawBoard();
        }
    }
}
