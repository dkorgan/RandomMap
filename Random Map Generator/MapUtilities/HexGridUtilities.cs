using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtilities
{
    class HexGridUtilities
    {

        private static float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        public static PointF[] HexToPoints(float height, float row, float col)
        {
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;

            y += row * height;

            if (col % 2 == 1)
                y += height / 2;

            x += col * (width * 0.75f);

            return new PointF[]
            {
                new PointF(x, y),
                new PointF(x + width * 0.25f, y - height / 2),
                new PointF(x + width * 0.75f, y - height / 2),
                new PointF(x + width, y),
                new PointF(x + width * 0.75f, y + height / 2),
                new PointF(x + width * 0.25f, y + height / 2)
            };
        }

        public static void PointToHex(float x, float y, float height, out int row, out int col)
        {
            float width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
                row = (int)(y / height);
            else
                row = (int)((y - height / 2) / height);

            // test area
            float testX = col * width * 0.75f;
            float testY = row * height;
            if (col % 2 == 1)
                testY += height / 2;

            bool isAbove = false;
            bool isBelow = false;
            float dx = x - testX;

            if (dx < width / 4)
            {
                float dy = y - (testY + height / 2);
                if (dx < 0.001)
                {
                    if (dy < 0)
                        isAbove = true;
                    if (dy > 0)
                        isBelow = true;
                }
                else if (dy < 0)
                {
                    if (-dy / dx > Math.Sqrt(3))
                        isAbove = true;
                }
                else
                {
                    if (dy / dx > Math.Sqrt(3))
                        isBelow = true;
                }
            }

            if (isAbove)
            {
                if (col % 2 == 0)
                    row--;
                col--;
            }
            else if (isBelow)
            {
                if (col % 2 == 1)
                    row++;
                col--;
            }
        }
    }
}
