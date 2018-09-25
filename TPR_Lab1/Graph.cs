using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TPR_Lab1
{
    class Graph
    {
        const int R = 4;
        //координаты для каждой ситуации каждого шага[ситуация, шаг]
        Point[,] situation_coords;
        void DrawSituation(Graphics g, int point_index, int time)
        {
            var point = situation_coords[point_index, time];
            g.DrawEllipse(Pens.Black, point.X - R, point.Y - R, 2 * R, 2 * R);
            g.DrawString((point_index + 1).ToString(), new Font("Arial", 12), Brushes.Black, point.X, point.Y);
        }

        void DrawArrow(Graphics g, int sit1, int time1, int sit2, int time2, double prop, double weight)
        {
            var p1 = situation_coords[sit1, time1];
            var p2 = situation_coords[sit2, time2];
            Font font = new Font(SystemFonts.DefaultFont, FontStyle.Regular);
            g.DrawLine(Pens.Black, p1, p2);
            g.DrawString(prop.ToString(), font, Brushes.Black, (p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2 + 10);
            g.DrawString(weight.ToString(), font, Brushes.Black, (p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2 - 10);
        }

        public void Draw(Model model, Graphics g, int width, int height, int sit, int strat)
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


            for (int index = 0; index < N; index++)//стрелки из выбранной в следующие
                DrawArrow(g, sit, 0, index, 1, model.strategies[strat].p[sit, index], model.strategies[strat].r[sit, index]);
            for (int time = 1; time < n - 1; time++)

                for (int index1 = 0; index1 < N; index1++)//из каждой в следующие
                    for (int index2 = 0; index2 < N; index2++)//из каждой в следующие
                        DrawArrow(g, index1, time, index2, time + 1, model.strategies[strat].p[index1, index2], model.strategies[strat].r[index1, index2]);

            for (int index = 0; index < N; index++)//рисуем ситуации для всех времен
                for (int time = 0; time < n; time++)
                    DrawSituation(g, index, time);
        }
    }
}
