using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TPR_Lab1
{
 public   class Strategy
    {
        /// <summary>
        /// матрица вероятностей переходов
        /// </summary>
       public Matrix p;
        /// <summary>
        /// матрица доходностей
        /// </summary>
        public Matrix r;
        /// <summary>
        /// количество состояний
        /// </summary>
        int N;

        /// <summary>
        /// Название стратегии
        /// </summary>
        public string Name;

        public Strategy(Matrix props, Matrix sums, int N)
        {
            this.p = props ?? throw new ArgumentNullException(nameof(props));
            this.r = sums ?? throw new ArgumentNullException(nameof(sums));
            this.N = N;
        }

        public Strategy(int N, string name="")
        {
            this.N = N;
            Name = name;
            p = new Matrix(N, N);
            r = new Matrix(N, N);
        }

       public double calculateSituation(int situation)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
                sum += p[situation, i] * r[situation, i];
            return sum;
        }

        public void Save(TextWriter tw)
        {
            tw.WriteLine(N);
            tw.WriteLine(Name);
            r.Save(tw);
            p.Save(tw);
        }

        public void Load(TextReader tr)
        {
            N = int.Parse(tr.ReadLine());
            Name = tr.ReadLine();
            r = new Matrix();
            r.Load(tr);
            p = new Matrix();
            p.Load(tr);
        }

        public Strategy()
        {
        }
    }
}
