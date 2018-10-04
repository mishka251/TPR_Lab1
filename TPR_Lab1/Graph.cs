using System.Drawing;
using System.Drawing.Drawing2D;
using System;

namespace TPR_Lab1
{
    class Graph
    {

        public static Pen[] MyPens = { Pens.Red, Pens.Orange, Pens.DarkGreen, Pens.LightGreen, Pens.Gray };
        public static Font font = new Font(SystemFonts.DefaultFont, FontStyle.Regular);
        const int R = 14;
        //координаты для каждой ситуации каждого шага[ситуация, шаг]
        Point[,] situation_coords;
        void DrawSituation(Graphics g, int point_index, int time)
        {
            var point = situation_coords[point_index, time];
            g.DrawEllipse(Pens.Black, point.X - R, point.Y - R, 2 * R, 2 * R);
            g.DrawString((point_index + 1).ToString(), new Font("Arial", 12), Brushes.Black, point.X - R / 2, point.Y - R / 2);
        }

        void DrawArrow(Graphics g, int strat, int sit1, int time1, int sit2, int time2, double prop, double cost)
        {
            var p1 = situation_coords[sit1, time1];
            var p2 = situation_coords[sit2, time2];
            Point vec = new Point
            {
                X = p2.X - p1.X,
                Y = p2.Y - p1.Y
            };
            double len = Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);


            Pen pen = (Pen)MyPens[strat].Clone();
            pen.EndCap = LineCap.ArrowAnchor;
            pen.Width = 2;

            g.DrawLine(pen, (int)(p1.X + R * vec.X / len), (int)(p1.Y + R * vec.Y / len), (int)(p2.X - R * vec.X / len), (int)(p2.Y - R * vec.Y / len));

        }

        public void Draw(Model model, Graphics g, int width, int height, int sit)
        {
            int n = model.n;
            int N = model.N;

            situation_coords = new Point[N, n+1];

            int step_w = (width - 30) / (n+1);
            int step_h = (height - 50) / N;

            for (int i = 0; i <= n; i++)
            {
                int x = 25 + step_w * i;
                for (int j = 0; j < N; j++)
                {
                    int y = 35 + step_h * j;
                    situation_coords[j, i] = new Point(x, y);
                }
            }

            int strat = (int)model.d[sit, 1];

            for (int index = 0; index < N; index++)//стрелки из выбранной в следующие
                DrawArrow(g, strat, sit, 0, index, 1, model.strategies[strat].p[sit, index], model.strategies[strat].r[sit, index]);


            for (int time = 2; time <= n; time++)//каждое время
                for (int sit1 = 0; sit1 < N; sit1++)//из каждой в следующие
                {
                    strat = (int)model.d[sit, time];
                    for (int sit2 = 0; sit2 < N; sit2++)//из каждой в следующие
                        DrawArrow(g, strat, sit1, time - 1, sit2, time, model.strategies[strat].p[sit1, sit2], model.strategies[strat].r[sit1, sit2]);
                }

            for (int index = 0; index < N; index++)//рисуем ситуации для всех времен
                for (int time = 0; time <= n ; time++)
                    DrawSituation(g, index, time);


            DrawStrategies(g,model,  height);
        }

        void DrawStrategies(Graphics g, Model model, int height)
        {
            int X = 20;
            for (int i = 0; i < model.strategies.Length; i++)
            {
                g.DrawString(model.strategies[i].Name, font, MyPens[i].Brush, X, height - 20);
                X += 40;
            }
        }
    }
}
