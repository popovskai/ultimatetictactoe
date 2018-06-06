using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateTicTacToe {

    public partial class GameForm : Form {

        public GameForm() {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e) { }

        #region Menu

        private void PlayButton_Click(object sender, EventArgs e) {
            InitGame();

            MenuContainer.Visible = false;
            GameContainer.Visible = true;
        }

        private void InstructionsButton_Click(object sender, EventArgs e) {
            MenuContainer.Visible = false;
            InstructionsPanel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BackButton_Clicked(object sender, EventArgs e) {
            InstructionsPanel.Visible = false;
            MenuContainer.Visible = true;
        }

        #endregion

        #region Game

        public enum Player { X, O, NONE};
        private Player CurrentTurn;
        private Random random = new Random();

        private SmallTable[,] tables;

        private void InitGame() {
            if(random.Next()%2 == 0) {
                SetPlayerTurn(Player.X);
            } else {
                SetPlayerTurn(Player.O);
            }

            tables = new SmallTable[3, 3];
            tables[0, 0] = new SmallTable(this, 0, 0, t00);
            tables[0, 1] = new SmallTable(this, 0, 1, t01);
            tables[0, 2] = new SmallTable(this, 0, 2, t02);

            tables[1, 0] = new SmallTable(this, 1, 0, t10);
            tables[1, 1] = new SmallTable(this, 1, 1, t11);
            tables[1, 2] = new SmallTable(this, 1, 2, t12);

            tables[2, 0] = new SmallTable(this, 2, 0, t20);
            tables[2, 1] = new SmallTable(this, 2, 1, t21);
            tables[2, 2] = new SmallTable(this, 2, 2, t22);

            FocusAll();
        }

        private void FocusAll() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    tables[i, j].SetFocused(true);
                }
            }
        }

        private void SetPlayerTurn(Player player) {
            this.CurrentTurn = player;

            if (player == Player.X) {
                CurrentTurnImage.Image = UltimateTicTacToe.Properties.Resources.x;
                CurrentTurnLabel.Text = "RED PLAYER";
            } else {
                CurrentTurnImage.Image = UltimateTicTacToe.Properties.Resources.o;
                CurrentTurnLabel.Text = "BLUE PLAYER";
            }
        }

        public Player GetCurrentPlayerTurn() {
            return this.CurrentTurn;
        }

        public void SwitchTurn() {
            if(this.CurrentTurn == Player.X) {
                SetPlayerTurn(Player.O);
            } else {
                SetPlayerTurn(Player.X);
            }
        }

        public void SetFocusedTable(int row, int column) {
            if (tables[row, column].IsWon() || tables[row, column].GetCapacity() == 0) {
                FocusAll();
            } else {
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        tables[i, j].SetFocused(false);
                    }
                }

                tables[row, column].SetFocused(true);
            }
        }

        public void CheckWin(int row, int column, GameForm.Player player) {
            if(HasWon(row, column, player)) {
                if(player == Player.X) {
                    MessageBox.Show("The RED player won!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {
                    MessageBox.Show("The BLUE player won!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                for(int i = 0; i < 3; i++) {
                    for(int j = 0; j < 3; j++) {
                        tables[i, j].GetTableImage().Controls.Clear();
                    }
                }

                GameContainer.Visible = false;
                MenuContainer.Visible = true;
            } else {
                bool allWon = true;
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        if(!tables[i, j].IsWon() && tables[i, j].GetCapacity() > 0) {
                            allWon = false;
                            break;
                        }
                    }
                }
                if(allWon) {
                    MessageBox.Show("No one won - DRAFT!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    for (int i = 0; i < 3; i++) {
                        for (int j = 0; j < 3; j++) {
                            tables[i, j].GetTableImage().Controls.Clear();
                        }
                    }

                    GameContainer.Visible = false;
                    MenuContainer.Visible = true;
                }
            }
        }

        public bool HasWon(int i, int j, GameForm.Player player) {
            // check horizontal
            if (tables[i, 0].GetWonBy() == player && tables[i, 1].GetWonBy() == player && tables[i, 2].GetWonBy() == player) {
                return true;
            }

            // check vertical
            if (tables[0, j].GetWonBy() == player && tables[1, j].GetWonBy() == player && tables[2, j].GetWonBy() == player) {
                return true;
            }

            // check main diaognal
            if (tables[0, 0].GetWonBy() == player && tables[1, 1].GetWonBy() == player && tables[2, 2].GetWonBy() == player) {
                return true;
            }

            // check secondary diagonal
            if (tables[0, 2].GetWonBy() == player && tables[1, 1].GetWonBy() == player && tables[2, 0].GetWonBy() == player) {
                return true;
            }

            return false;
        }

        #endregion
    }
}
