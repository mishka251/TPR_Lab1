using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TPR_Lab1
{
    class Graph
    {

        public static Pen[] MyPens = { Pens.Black, Pens.Red, Pens.Blue, Pens.Green, Pens.Orange };
    
        const int R = 4;
        //координаты для каждой ситуации каждого шага[ситуация, шаг]
        Point[,] situation_coords;
        void DrawSituation(Graphics g, int point_index, int time)
        {
            var point = situation_coords[point_index, time];
            g.DrawEllipse(Pens.Black, point.X - R, point.Y - R, 2 * R, 2 * R);
            g.DrawString((point_index + 1).ToString(), new Font("Arial", 12), Brushes.Black, point.X, point.Y);
        }

        void DrawArrow(Graphics g, int strat, int sit1, int time1, int sit2, int time2, double prop, double cost)
        {
            var p1 = situation_coords[sit1, time1];
            var p2 = situation_coords[sit2, time2];

            Font font = new Font(SystemFonts.DefaultFont, FontStyle.Regular);
            Pen pen = (Pen)MyPens[strat].Clone();
            pen.EndCap = LineCap.ArrowAnchor;
            
            g.DrawLine(MyPens[strat], p1, p2);
            double k = p1.X == p2.X|| p2.Y == p1.Y ? 0 : ((double)(p2.Y - p1.Y)) / (p2.X - p1.X);

            Point p = new Point
            {
                X = (int)((p1.X+p2.X)/2 + k * (p2.X - p1.X) / 5),
                Y = (p1.Y + p2.Y) / 2 + 10
            };

            Point c = new Point
            {
                X = (int)((p1.X + p2.X) / 2 + k * (p2.X - p1.X) / 5),
                Y = (p1.Y + p2.Y) / 2 - 10
            };

            g.DrawString(prop.ToString(), font, MyPens[strat].Brush, p.X, p.Y);
            g.DrawString(cost.ToString(), font, MyPens[strat].Brush, c.X, c.Y);
        }

        public void Draw(Model model, Graphics g, int width, int height, int sit/*, int strat*/)
        {
            int n = model.n;
            int N = model.N;

            situation_coords = new Point[N, n];

            int step_w = (width - 30) / n;
            int step_h = (height - 30) / N;

            for (int i = 0; i < n; i++)
            {
                int x = 15 + step_w * i;
                for (int j = 0; j < N; j++)
                {
                    int y = 15 + step_h * j;
                    situation_coords[j, i] = new Point(x, y);
                }
            }

            int strat = (int)model.d[0, sit];

            for (int index = 0; index < N; index++)//стрелки из выбранной в следующие
                DrawArrow(g, strat, sit, 0, index, 1, model.strategies[strat].p[sit, index], model.strategies[strat].r[sit, index]);


            for (int time = 1; time < n - 1; time++)//каждое время
                for (int sit1 = 0; sit1 < N; sit1++)//из каждой в следующие
                {
                    strat = (int)model.d[time, sit];
                    for (int sit2 = 0; sit2 < N; sit2++)//из каждой в следующие
                        DrawArrow(g, strat,  sit1, time, sit2, time + 1, model.strategies[strat].p[sit1, sit2], model.strategies[strat].r[sit1, sit2]);
                }

            for (int index = 0; index < N; index++)//рисуем ситуации для всех времен
                for (int time = 0; time < n; time++)
                    DrawSituation(g, index, time);
        }
    }
}
