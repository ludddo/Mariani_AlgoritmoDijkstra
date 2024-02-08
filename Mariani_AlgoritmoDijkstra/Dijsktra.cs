using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_AlgoritmoDijkstra
{
    internal class Dijsktra
    {
        /*
        { 0, 1, 3, int.MaxValue },
        { 1, 0, 1, 2},
        { 3, 1, 0, 1},
        { int.MaxValue, 2, 1, 0} };
        */

        public void Algoritmo(float[,] a)
        {
            int lungMat = int.Parse(Math.Sqrt(a.Length).ToString());

            float[] dist = new float[lungMat];


            for (int i = 0; i < lungMat; i++)
            {
                for (int j = 0; i < lungMat; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dist[i] = 0;
                        break;
                    }
                    if (j+1 > lungMat-1)
                    {
                        break;
                    }

                    if (a[i,j] < a[i, j + 1])
                    {
                        if (a[i,j] != 0)
                        {
                            dist[i] = a[i, j];
                        }
                    }
                    else if (a[i, j] > a[i, j + 1])
                    {
                        if (a[i,j+1] != 0)
                        {
                            dist[i] = a[i, j + 1];
                        }
                    }
                }
            }
            
            for (int i = 1; i < lungMat; i++)
            {
                dist[i] = dist[i] + dist[i-1];
            }

            int franco = 65;

            for (int i = 0; i < lungMat; i++)
            {
                Console.WriteLine(Convert.ToChar(franco) + " " + dist[i]);
                franco++;
            }
        }
    }
}
