using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateTicTacToe.Observer;
using UltimateTicTacToe.Game;

namespace UltimateTicTacToe.View
{
    public partial class CellView : PictureBox, Subscriber
    {
        public Cell model { get; set; }

        public CellView()
        {
            InitializeComponent();
        }

        void Subscriber.Update()
        {
            Image = new Bitmap(Width, Height);

            Graphics g = Graphics.FromImage(Image);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if( model.cellValue == 1 )
            {
                Pen pen = new Pen(Brushes.Blue);
                pen.Width = 5;
                g.DrawLine(pen, 5, 5, Width - 5, Height - 5);
                g.DrawLine(pen, 5, Height - 5, Width - 5, 5);
            }
            else if( model.cellValue == -1 )
            {
                Pen pen = new Pen(Brushes.Red);
                pen.Width = 5;
                g.DrawEllipse(pen, 5, 5, Width - 10, Height - 10);
            }
            g.Dispose();

            Refresh();
        }

        public void UpdateAvailable()
        {
            BackColor = Color.Yellow;
            Refresh();
        }
    }
}
