using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateTicTacToe.View;
using UltimateTicTacToe.Game;

namespace UltimateTicTacToe
{
    public partial class Form1 : Form
    {
        Game.Game game = null;

        public Form1()
        {
            InitializeComponent();

            game = new Game.Game();
            SetModels();
            SetSubscribers();
        }

        private void CellClicked(object sender, EventArgs e)
        {
            CellView clickedCell = (CellView)sender;
            if (!clickedCell.model.resolved && game.MovePossible(clickedCell.model))
            {
                resetBackColor();
                game.PlayMove(clickedCell.model);

                CheckWin();

                if (game.activePlayer == -1)
                {
                    resetBackColor();
                    Refresh();
                    game.minmax.PlayTurn();

                    CheckWin();
                }
            }
        }

        private void CheckWin()
        {
            if (game.gameBoard.resolved)
            {
                if (game.gameBoard.cellValue == 1)
                    MessageBox.Show("X Won!!!");
                else
                    MessageBox.Show("O Won!!!");

                Close();
            }
            else if (game.currPossibleMoves.Count == 0)
            {
                MessageBox.Show("Draw!!!");
                Close();
            }
        }

        private void SetModels()
        {
            cellView1.model  = game.gameBoard.childCells[0].childCells[0];
            cellView2.model  = game.gameBoard.childCells[0].childCells[1];
            cellView3.model  = game.gameBoard.childCells[0].childCells[2];
            cellView4.model  = game.gameBoard.childCells[1].childCells[0];
            cellView5.model  = game.gameBoard.childCells[1].childCells[1];
            cellView6.model  = game.gameBoard.childCells[1].childCells[2];
            cellView7.model  = game.gameBoard.childCells[2].childCells[0];
            cellView8.model  = game.gameBoard.childCells[2].childCells[1];
            cellView9.model  = game.gameBoard.childCells[2].childCells[2];
            cellView10.model = game.gameBoard.childCells[0].childCells[3];
            cellView11.model = game.gameBoard.childCells[0].childCells[4];
            cellView12.model = game.gameBoard.childCells[0].childCells[5];
            cellView13.model = game.gameBoard.childCells[1].childCells[3];
            cellView14.model = game.gameBoard.childCells[1].childCells[4];
            cellView15.model = game.gameBoard.childCells[1].childCells[5];
            cellView16.model = game.gameBoard.childCells[2].childCells[3];
            cellView17.model = game.gameBoard.childCells[2].childCells[4];
            cellView18.model = game.gameBoard.childCells[2].childCells[5];
            cellView19.model = game.gameBoard.childCells[0].childCells[6];
            cellView20.model = game.gameBoard.childCells[0].childCells[7];
            cellView21.model = game.gameBoard.childCells[0].childCells[8];
            cellView22.model = game.gameBoard.childCells[1].childCells[6];
            cellView23.model = game.gameBoard.childCells[1].childCells[7];
            cellView24.model = game.gameBoard.childCells[1].childCells[8];
            cellView25.model = game.gameBoard.childCells[2].childCells[6];
            cellView26.model = game.gameBoard.childCells[2].childCells[7];
            cellView27.model = game.gameBoard.childCells[2].childCells[8];
            cellView28.model = game.gameBoard.childCells[3].childCells[0];
            cellView29.model = game.gameBoard.childCells[3].childCells[1];
            cellView30.model = game.gameBoard.childCells[3].childCells[2];
            cellView31.model = game.gameBoard.childCells[4].childCells[0];
            cellView32.model = game.gameBoard.childCells[4].childCells[1];
            cellView33.model = game.gameBoard.childCells[4].childCells[2];
            cellView34.model = game.gameBoard.childCells[5].childCells[0];
            cellView35.model = game.gameBoard.childCells[5].childCells[1];
            cellView36.model = game.gameBoard.childCells[5].childCells[2];
            cellView37.model = game.gameBoard.childCells[3].childCells[3];
            cellView38.model = game.gameBoard.childCells[3].childCells[4];
            cellView39.model = game.gameBoard.childCells[3].childCells[5];
            cellView40.model = game.gameBoard.childCells[4].childCells[3];
            cellView41.model = game.gameBoard.childCells[4].childCells[4];
            cellView42.model = game.gameBoard.childCells[4].childCells[5];
            cellView43.model = game.gameBoard.childCells[5].childCells[3];
            cellView44.model = game.gameBoard.childCells[5].childCells[4];
            cellView45.model = game.gameBoard.childCells[5].childCells[5];
            cellView46.model = game.gameBoard.childCells[3].childCells[6];
            cellView47.model = game.gameBoard.childCells[3].childCells[7];
            cellView48.model = game.gameBoard.childCells[3].childCells[8];
            cellView49.model = game.gameBoard.childCells[4].childCells[6];
            cellView50.model = game.gameBoard.childCells[4].childCells[7];
            cellView51.model = game.gameBoard.childCells[4].childCells[8];
            cellView52.model = game.gameBoard.childCells[5].childCells[6];
            cellView53.model = game.gameBoard.childCells[5].childCells[7];
            cellView54.model = game.gameBoard.childCells[5].childCells[8];
            cellView55.model = game.gameBoard.childCells[6].childCells[0];
            cellView56.model = game.gameBoard.childCells[6].childCells[1];
            cellView57.model = game.gameBoard.childCells[6].childCells[2];
            cellView58.model = game.gameBoard.childCells[7].childCells[0];
            cellView59.model = game.gameBoard.childCells[7].childCells[1];
            cellView60.model = game.gameBoard.childCells[7].childCells[2];
            cellView61.model = game.gameBoard.childCells[8].childCells[0];
            cellView62.model = game.gameBoard.childCells[8].childCells[1];
            cellView63.model = game.gameBoard.childCells[8].childCells[2];
            cellView64.model = game.gameBoard.childCells[6].childCells[3];
            cellView65.model = game.gameBoard.childCells[6].childCells[4];
            cellView66.model = game.gameBoard.childCells[6].childCells[5];
            cellView67.model = game.gameBoard.childCells[7].childCells[3];
            cellView68.model = game.gameBoard.childCells[7].childCells[4];
            cellView69.model = game.gameBoard.childCells[7].childCells[5];
            cellView70.model = game.gameBoard.childCells[8].childCells[3];
            cellView71.model = game.gameBoard.childCells[8].childCells[4];
            cellView72.model = game.gameBoard.childCells[8].childCells[5];
            cellView73.model = game.gameBoard.childCells[6].childCells[6];
            cellView74.model = game.gameBoard.childCells[6].childCells[7];
            cellView75.model = game.gameBoard.childCells[6].childCells[8];
            cellView76.model = game.gameBoard.childCells[7].childCells[6];
            cellView77.model = game.gameBoard.childCells[7].childCells[7];
            cellView78.model = game.gameBoard.childCells[7].childCells[8];
            cellView79.model = game.gameBoard.childCells[8].childCells[6];
            cellView80.model = game.gameBoard.childCells[8].childCells[7];
            cellView81.model = game.gameBoard.childCells[8].childCells[8];
        }

        private void SetSubscribers()
        {
            game.gameBoard.childCells[0].childCells[0].AddSubscriber(cellView1);
            game.gameBoard.childCells[0].childCells[1].AddSubscriber(cellView2);
            game.gameBoard.childCells[0].childCells[2].AddSubscriber(cellView3);
            game.gameBoard.childCells[1].childCells[0].AddSubscriber(cellView4);
            game.gameBoard.childCells[1].childCells[1].AddSubscriber(cellView5);
            game.gameBoard.childCells[1].childCells[2].AddSubscriber(cellView6);
            game.gameBoard.childCells[2].childCells[0].AddSubscriber(cellView7);
            game.gameBoard.childCells[2].childCells[1].AddSubscriber(cellView8);
            game.gameBoard.childCells[2].childCells[2].AddSubscriber(cellView9);
            game.gameBoard.childCells[0].childCells[3].AddSubscriber(cellView10);
            game.gameBoard.childCells[0].childCells[4].AddSubscriber(cellView11);
            game.gameBoard.childCells[0].childCells[5].AddSubscriber(cellView12);
            game.gameBoard.childCells[1].childCells[3].AddSubscriber(cellView13);
            game.gameBoard.childCells[1].childCells[4].AddSubscriber(cellView14);
            game.gameBoard.childCells[1].childCells[5].AddSubscriber(cellView15);
            game.gameBoard.childCells[2].childCells[3].AddSubscriber(cellView16);
            game.gameBoard.childCells[2].childCells[4].AddSubscriber(cellView17);
            game.gameBoard.childCells[2].childCells[5].AddSubscriber(cellView18);
            game.gameBoard.childCells[0].childCells[6].AddSubscriber(cellView19);
            game.gameBoard.childCells[0].childCells[7].AddSubscriber(cellView20);
            game.gameBoard.childCells[0].childCells[8].AddSubscriber(cellView21);
            game.gameBoard.childCells[1].childCells[6].AddSubscriber(cellView22);
            game.gameBoard.childCells[1].childCells[7].AddSubscriber(cellView23);
            game.gameBoard.childCells[1].childCells[8].AddSubscriber(cellView24);
            game.gameBoard.childCells[2].childCells[6].AddSubscriber(cellView25);
            game.gameBoard.childCells[2].childCells[7].AddSubscriber(cellView26);
            game.gameBoard.childCells[2].childCells[8].AddSubscriber(cellView27);
            game.gameBoard.childCells[3].childCells[0].AddSubscriber(cellView28);
            game.gameBoard.childCells[3].childCells[1].AddSubscriber(cellView29);
            game.gameBoard.childCells[3].childCells[2].AddSubscriber(cellView30);
            game.gameBoard.childCells[4].childCells[0].AddSubscriber(cellView31);
            game.gameBoard.childCells[4].childCells[1].AddSubscriber(cellView32);
            game.gameBoard.childCells[4].childCells[2].AddSubscriber(cellView33);
            game.gameBoard.childCells[5].childCells[0].AddSubscriber(cellView34);
            game.gameBoard.childCells[5].childCells[1].AddSubscriber(cellView35);
            game.gameBoard.childCells[5].childCells[2].AddSubscriber(cellView36);
            game.gameBoard.childCells[3].childCells[3].AddSubscriber(cellView37);
            game.gameBoard.childCells[3].childCells[4].AddSubscriber(cellView38);
            game.gameBoard.childCells[3].childCells[5].AddSubscriber(cellView39);
            game.gameBoard.childCells[4].childCells[3].AddSubscriber(cellView40);
            game.gameBoard.childCells[4].childCells[4].AddSubscriber(cellView41);
            game.gameBoard.childCells[4].childCells[5].AddSubscriber(cellView42);
            game.gameBoard.childCells[5].childCells[3].AddSubscriber(cellView43);
            game.gameBoard.childCells[5].childCells[4].AddSubscriber(cellView44);
            game.gameBoard.childCells[5].childCells[5].AddSubscriber(cellView45);
            game.gameBoard.childCells[3].childCells[6].AddSubscriber(cellView46);
            game.gameBoard.childCells[3].childCells[7].AddSubscriber(cellView47);
            game.gameBoard.childCells[3].childCells[8].AddSubscriber(cellView48);
            game.gameBoard.childCells[4].childCells[6].AddSubscriber(cellView49);
            game.gameBoard.childCells[4].childCells[7].AddSubscriber(cellView50);
            game.gameBoard.childCells[4].childCells[8].AddSubscriber(cellView51);
            game.gameBoard.childCells[5].childCells[6].AddSubscriber(cellView52);
            game.gameBoard.childCells[5].childCells[7].AddSubscriber(cellView53);
            game.gameBoard.childCells[5].childCells[8].AddSubscriber(cellView54);
            game.gameBoard.childCells[6].childCells[0].AddSubscriber(cellView55);
            game.gameBoard.childCells[6].childCells[1].AddSubscriber(cellView56);
            game.gameBoard.childCells[6].childCells[2].AddSubscriber(cellView57);
            game.gameBoard.childCells[7].childCells[0].AddSubscriber(cellView58);
            game.gameBoard.childCells[7].childCells[1].AddSubscriber(cellView59);
            game.gameBoard.childCells[7].childCells[2].AddSubscriber(cellView60);
            game.gameBoard.childCells[8].childCells[0].AddSubscriber(cellView61);
            game.gameBoard.childCells[8].childCells[1].AddSubscriber(cellView62);
            game.gameBoard.childCells[8].childCells[2].AddSubscriber(cellView63);
            game.gameBoard.childCells[6].childCells[3].AddSubscriber(cellView64);
            game.gameBoard.childCells[6].childCells[4].AddSubscriber(cellView65);
            game.gameBoard.childCells[6].childCells[5].AddSubscriber(cellView66);
            game.gameBoard.childCells[7].childCells[3].AddSubscriber(cellView67);
            game.gameBoard.childCells[7].childCells[4].AddSubscriber(cellView68);
            game.gameBoard.childCells[7].childCells[5].AddSubscriber(cellView69);
            game.gameBoard.childCells[8].childCells[3].AddSubscriber(cellView70);
            game.gameBoard.childCells[8].childCells[4].AddSubscriber(cellView71);
            game.gameBoard.childCells[8].childCells[5].AddSubscriber(cellView72);
            game.gameBoard.childCells[6].childCells[6].AddSubscriber(cellView73);
            game.gameBoard.childCells[6].childCells[7].AddSubscriber(cellView74);
            game.gameBoard.childCells[6].childCells[8].AddSubscriber(cellView75);
            game.gameBoard.childCells[7].childCells[6].AddSubscriber(cellView76);
            game.gameBoard.childCells[7].childCells[7].AddSubscriber(cellView77);
            game.gameBoard.childCells[7].childCells[8].AddSubscriber(cellView78);
            game.gameBoard.childCells[8].childCells[6].AddSubscriber(cellView79);
            game.gameBoard.childCells[8].childCells[7].AddSubscriber(cellView80);
            game.gameBoard.childCells[8].childCells[8].AddSubscriber(cellView81);
        }

        private void resetBackColor()
        {
            cellView1.BackColor = Color.White;
            cellView2.BackColor = Color.White;
            cellView3.BackColor = Color.White;
            cellView4.BackColor = Color.White;
            cellView5.BackColor = Color.White;
            cellView6.BackColor = Color.White;
            cellView7.BackColor = Color.White;
            cellView8.BackColor = Color.White;
            cellView9.BackColor = Color.White;
            cellView10.BackColor = Color.White;
            cellView11.BackColor = Color.White;
            cellView12.BackColor = Color.White;
            cellView13.BackColor = Color.White;
            cellView14.BackColor = Color.White;
            cellView15.BackColor = Color.White;
            cellView16.BackColor = Color.White;
            cellView17.BackColor = Color.White;
            cellView18.BackColor = Color.White;
            cellView19.BackColor = Color.White;
            cellView20.BackColor = Color.White;
            cellView21.BackColor = Color.White;
            cellView22.BackColor = Color.White;
            cellView23.BackColor = Color.White;
            cellView24.BackColor = Color.White;
            cellView25.BackColor = Color.White;
            cellView26.BackColor = Color.White;
            cellView27.BackColor = Color.White;
            cellView28.BackColor = Color.White;
            cellView29.BackColor = Color.White;
            cellView30.BackColor = Color.White;
            cellView31.BackColor = Color.White;
            cellView32.BackColor = Color.White;
            cellView33.BackColor = Color.White;
            cellView34.BackColor = Color.White;
            cellView35.BackColor = Color.White;
            cellView36.BackColor = Color.White;
            cellView37.BackColor = Color.White;
            cellView38.BackColor = Color.White;
            cellView39.BackColor = Color.White;
            cellView40.BackColor = Color.White;
            cellView41.BackColor = Color.White;
            cellView42.BackColor = Color.White;
            cellView43.BackColor = Color.White;
            cellView44.BackColor = Color.White;
            cellView45.BackColor = Color.White;
            cellView46.BackColor = Color.White;
            cellView47.BackColor = Color.White;
            cellView48.BackColor = Color.White;
            cellView49.BackColor = Color.White;
            cellView50.BackColor = Color.White;
            cellView51.BackColor = Color.White;
            cellView52.BackColor = Color.White;
            cellView53.BackColor = Color.White;
            cellView54.BackColor = Color.White;
            cellView55.BackColor = Color.White;
            cellView56.BackColor = Color.White;
            cellView57.BackColor = Color.White;
            cellView58.BackColor = Color.White;
            cellView59.BackColor = Color.White;
            cellView60.BackColor = Color.White;
            cellView61.BackColor = Color.White;
            cellView62.BackColor = Color.White;
            cellView63.BackColor = Color.White;
            cellView64.BackColor = Color.White;
            cellView65.BackColor = Color.White;
            cellView66.BackColor = Color.White;
            cellView67.BackColor = Color.White;
            cellView68.BackColor = Color.White;
            cellView69.BackColor = Color.White;
            cellView70.BackColor = Color.White;
            cellView71.BackColor = Color.White;
            cellView72.BackColor = Color.White;
            cellView73.BackColor = Color.White;
            cellView74.BackColor = Color.White;
            cellView75.BackColor = Color.White;
            cellView76.BackColor = Color.White;
            cellView77.BackColor = Color.White;
            cellView78.BackColor = Color.White;
            cellView79.BackColor = Color.White;
            cellView80.BackColor = Color.White;
            cellView81.BackColor = Color.White;
        }
    }
}
