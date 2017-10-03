using MapUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMapGenerator
{
    public partial class MapView : Form
    {
        private List<PointF> Hexagons;
        private float HexHeight = 10;

        public MapView()
        {
            Hexagons = new List<PointF>();
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void DrawHexGrid(Graphics graphic, Pen pen, float xMin, float xMax, float yMin, float yMax, float height)
        {
            for(int row=0; ;row++)
            {
                PointF[] points = HexGridUtilities.HexToPoints(height, row, 0);

                if (points[4].Y > yMax)
                    break;

                for(int col=0; ; col++)
                {
                    points = HexGridUtilities.HexToPoints(height, row, col);

                    if (points[3].X > xMax)
                        break;

                    if (points[4].Y <= yMax)
                        graphic.DrawPolygon(pen, points);
                }
            }
        }

        private void picHexMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (PointF point in Hexagons)
                e.Graphics.FillPolygon(Brushes.LightBlue, HexGridUtilities.HexToPoints(HexHeight, point.X, point.Y));
            
            DrawHexGrid(e.Graphics, Pens.Black, 0, picHexMap.Width, 0, picHexMap.Height, HexHeight);
        }
    }
}
