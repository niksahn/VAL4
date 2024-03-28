using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL4
{
    class GausMethod
    {
        public int N;
        public double[][] Matrix { get; set; }
        public double[] RightPart { get; set; }
        public double[] Answer { get; set; }

        public List<List<List<double>>> Iterations = new List<List<List<double>>>();

        public GausMethod(double[][] matrix, double[] vals)
        {
            int n = matrix.Length;
            RightPart = vals;
            Answer = new double[n];
            Matrix = matrix;
            N = n;
        }

        private void SortRows(int SortIndex)
        {
            double MaxElement = Matrix[SortIndex][SortIndex];
            int MaxElementIndex = SortIndex;
            for (int i = SortIndex + 1; i < N; i++)
            {
                if (Matrix[i][SortIndex] > MaxElement)
                {
                    MaxElement = Matrix[i][SortIndex];
                    MaxElementIndex = i;
                }
            }

            //теперь найден максимальный элемент ставим его на верхнее место
            if (MaxElementIndex > SortIndex)//если это не первый элемент
            {
                double Temp;

                Temp = RightPart[MaxElementIndex];
                RightPart[MaxElementIndex] = RightPart[SortIndex];
                RightPart[SortIndex] = Temp;

                for (int i = 0; i < N; i++)
                {
                    Temp = Matrix[MaxElementIndex][i];
                    Matrix[MaxElementIndex][i] = Matrix[SortIndex][i];
                    Matrix[SortIndex][i] = Temp;
                }
            }
        }

        public int SolveMatrix()
        {
            for (int i = 0; i < N - 1; i++)
            {
                SortRows(i);
                for (int j = i + 1; j < N; j++)
                {             
                    if (Matrix[i][i] != 0) //если главный элемент не 0, то производим вычисления
                    {
                        double MultElement = Matrix[j][i] / Matrix[i][i];
                        for (int k = i; k < N; k++)
                            Matrix[j][k] -= Matrix[i][k] * MultElement;
                        RightPart[j] -= RightPart[i] * MultElement;
                    }
                    addToIteraction();
                    //для нулевого главного элемента просто пропускаем данный шаг
                }
            }
            Answer[N-1] = Matrix[N-1][N- 1]/RightPart[N-1];
            //ищем решение
            for (int i = (N - 2); i >= 0; i--)
            {
                Answer[i] = RightPart[i];

                for (int j = (int)(N - 1); j > i; j--)
                    Answer[i] -= Matrix[i][j] * Answer[j];

                if (Matrix[i][i] == 0)
                    if (RightPart[i] == 0)
                        return 2; //множество решений
                    else
                        return 1; //нет решения

                Answer[i] /= Matrix[i][i];
            }
            return 0;
        }
        
        private void addToIteraction()
        {
            List<List<double>> Iter = new List<List<double>>();
            for(int i = 0;i< N; i++)
            {
                List<double> Row = new List<double>();
                for(int j= 0; j< N; j++)
                {
                    Row.Add(Matrix[i][j]);
                }
                Row.Add(RightPart[i]);
                Iter.Add(Row);
            }
            Iterations.Add(Iter);
        }
    }
}
