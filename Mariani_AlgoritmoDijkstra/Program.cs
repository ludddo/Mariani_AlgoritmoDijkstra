using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_AlgoritmoDijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matrice = new float[4, 4] { { 0, 4, 3, float.MaxValue},
                                             { 4, 0, 1, 2},
                                             { 3, 1, 0, 1},
                                             { float.MaxValue, 2, 1, 0} };


            Dijsktra ciao = new Dijsktra();

            ciao.Algoritmo(matrice);
            /*Algoritmo t = new Algoritmo();
            t.dijkstra(matrice, 0);*/
        }
    }
}
