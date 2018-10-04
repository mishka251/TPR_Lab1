using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPR_Lab1
{
    public class Model
    {
        /// <summary>
        /// Массив стратегий
        /// </summary>
        public Strategy[] strategies;
        /// <summary>
        /// количество шагов модели
        /// </summary>
        public int n;
        /// <summary>
        /// количество состояний
        /// </summary>
        public int N;
        /// <summary>
        /// Матрица для хранения всех q[состояние, стратегия]
        /// </summary>
        public Matrix qs;
        /// <summary>
        /// Матрица для хранения всех вычисленных v[состояние, шаг]
        /// </summary>
        public Matrix v;
        /// <summary>
        /// Матрица d - лучшая стратегия для начального состояния и n эпох[состояние, шаг]
        /// </summary>
        public Matrix d;

        public string[] SituationsNames;
        void fill_qs()
        {
            qs = new Matrix(N, strategies.Length);
            for (int i = 0; i < strategies.Length; i++)
                for (int j = 0; j < N; j++)
                    qs[j, i] = strategies[i].calculateSituation(j);
        }


        void calculate_epoch(int ep)
        {

            for (int i = 0; i < N; i++)
            {
                double max = 0;
                int max_k = -1;
                for (int k = 0; k < strategies.Length; k++)
                {
                    double sum = qs[i, k];
                    for (int j = 0; j < N; j++)
                        sum += strategies[k].p[i, j] * v[j, ep - 1];

                    if (sum > max)
                    {
                        max = sum;
                        max_k = k;
                    }
                }
                v[i, ep] = max;
                d[i, ep] = max_k;
            }
        }




        void fill_v()
        {
            v = new Matrix(N, n + 1);
            d = new Matrix(N, n + 1);
            for (int i = 0; i < N; i++)
                v[i, 0] = 0;

            for (int i = 1; i <= n; i++)
                calculate_epoch(i);
        }


        public void Load(string file)
        {
            TextReader tr = new StreamReader(file);
            n = int.Parse(tr.ReadLine());
            N = int.Parse(tr.ReadLine());

            int count;
            SituationsNames = new string[N];
            string line = tr.ReadLine();
            if (int.TryParse(line, out int tmp)&&tmp.ToString()==line)
            {
                count = tmp;
                for (int i = 0; i < N; i++)
                    SituationsNames[i] = "состояние" + (i + 1);
            }
            else
            {
                for (int i = 0; i < N; i++)
                    SituationsNames[i] = tr.ReadLine();

                count = int.Parse(tr.ReadLine());
            }


            strategies = new Strategy[count];
            for (int i = 0; i < count; i++)
            {
                strategies[i] = new Strategy();
                strategies[i].Load(tr);
            }
            tr.Close();
        }
        public void Save(string file)
        {
            TextWriter tw = new StreamWriter(file);
            tw.WriteLine(n);
            tw.WriteLine(N);

            for (int i = 0; i < N; i++)
                tw.WriteLine(SituationsNames[i]);

            tw.WriteLine(strategies.Length);
            for (int i = 0; i < strategies.Length; i++)
                strategies[i].Save(tw);
            tw.Close();
        }

        public void Calculate()
        {
            fill_qs();
            fill_v();
        }
    }
}
