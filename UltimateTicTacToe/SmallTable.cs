using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateTicTacToe {
    class SmallTable {

        private bool Focused;
        private GameForm.Player WonBy = GameForm.Player.NONE;

        private GameForm.Player[,] table;

        private GameForm GameForm;
        private PictureBox TableImage;

        private int TableRow, TableColumn;

        private int capacity = 9;

        public SmallTable(GameForm GameForm, int TableRow, int TableColumn, PictureBox TableImage) {
            this.GameForm = GameForm;
            this.TableRow = TableRow;
            this.TableColumn = TableColumn;
            this.TableImage = TableImage;

            table = new GameForm.Player[3, 3];
            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    table[i, j] = GameForm.Player.NONE;
                }
            }

            TableImage.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e) {
            if(!Focused) {

                return;
            }

            if(IsWon()) {

                return;
            }

            MouseEventArgs me = (MouseEventArgs)e;
            Point mouseCoordinates = me.Location;

            int row = GetRow(mouseCoordinates);
            int column = GetColumn(mouseCoordinates);
            if (table[row, column] == GameForm.Player.NONE) {
                table[row, column] = GameForm.GetCurrentPlayerTurn();

                PictureBox icon = new PictureBox();
                icon.Size = new Size(TableImage.Size.Width / 3 - 8, TableImage.Size.Width / 3 - 8);
                icon.Location = new Point(column * (TableImage.Size.Width/3) + 4, row * (TableImage.Size.Height / 3) + 4);
                icon.SizeMode = PictureBoxSizeMode.StretchImage;
                if (GameForm.GetCurrentPlayerTurn() == GameForm.Player.X)
                    icon.Image = UltimateTicTacToe.Properties.Resources.x;
                else
                    icon.Image = UltimateTicTacToe.Properties.Resources.o;
                this.TableImage.Controls.Add(icon);

                if(HasWon(row, column, GameForm.GetCurrentPlayerTurn())) {
                    this.WonBy = GameForm.GetCurrentPlayerTurn();

                    PictureBox bigIcon = new PictureBox();
                    bigIcon.Size = new Size((int) (TableImage.Size.Width / 1.2f), (int)(TableImage.Size.Width / 1.2f));
                    int position = (int)(TableImage.Size.Width / 2 - bigIcon.Size.Width / 2);
                    bigIcon.Location = new Point(position, position);
                    bigIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (GameForm.GetCurrentPlayerTurn() == GameForm.Player.X)
                        bigIcon.Image = UltimateTicTacToe.Properties.Resources.x;
                    else
                        bigIcon.Image = UltimateTicTacToe.Properties.Resources.o;
                    this.TableImage.Controls.Add(bigIcon);
                    bigIcon.BringToFront();
                }

                capacity--;

                GameForm.CheckWin(TableRow, TableColumn, GameForm.GetCurrentPlayerTurn());

                GameForm.SetFocusedTable(row, column);
                GameForm.SwitchTurn();
            }

        }

        public bool IsFocused() {
            return this.Focused;
        }

        public void SetFocused(bool Focused) {
            this.Focused = Focused;

            if(this.Focused) {
                this.TableImage.BackColor = System.Drawing.Color.FromArgb(50, 230, 255, 0);
            } else {
                this.TableImage.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        public bool IsWon() {
            return this.WonBy != GameForm.Player.NONE;
        }

        public GameForm.Player GetWonBy() {
            return this.WonBy;
        }

        private int GetRow(Point point) {
            if (point.Y < TableImage.Size.Height / 3)
                return 0;
            else if (point.Y >= TableImage.Size.Height / 3 && point.Y < 2 * (TableImage.Size.Height / 3))
                return 1;
            else
                return 2;
        }

        private int GetColumn(Point point) {
            if (point.X < TableImage.Size.Width / 3)
                return 0;
            else if (point.X >= TableImage.Size.Width / 3 && point.X < 2 * (TableImage.Size.Width / 3))
                return 1;
            else
                return 2;
        }

        public PictureBox GetTableImage() {
            return TableImage;
        }

        public int GetCapacity() {
            return capacity;
        }

        public bool HasWon(int i, int j, GameForm.Player player) {
            // check horizontal
            if (table[i, 0] == player && table[i, 1] == player && table[i, 2] == player) {
                return true;
            }

            // check vertical
            if (table[0, j] == player && table[1, j] == player && table[2, j] == player) {
                return true;
            }

            // check main diaognal
            if (table[0, 0] == player && table[1, 1] == player && table[2, 2] == player) {
                return true;
            }

            // check secondary diagonal
            if (table[0, 2] == player && table[1, 1] == player && table[2, 0] == player) {
                return true;
            }

            return false;
        }

    }
}
