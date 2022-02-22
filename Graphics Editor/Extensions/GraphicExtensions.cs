using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Editor
{
    public static class GraphicExtensions
    {
        public static void DrawStar(this Graphics graphics, Pen pen, int x, int y, int radius, int n)
        {             
            double R =radius/2, r = radius;
            double alpha = 0;

            PointF[] points = new PointF[2 * n + 1];
            double da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x + l * Math.Cos(alpha)), (float)(y + l * Math.Sin(alpha)));
                alpha += da;
            }

            graphics.DrawLines(pen, points);
        }
        public static void FillStar(this Graphics graphics, Brush brush, int x, int y, int radius, int n)
        {
            double R = radius / 2, r = radius;
            double alpha = 0;

            PointF[] points = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x + l * Math.Cos(a)), (float)(y + l * Math.Sin(a)));
                a += da;
            }

            graphics.FillPolygon(brush, points);
        }
    }
}
