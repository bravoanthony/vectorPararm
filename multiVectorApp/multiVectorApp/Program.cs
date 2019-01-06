using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiVectorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[2, 2];
            
                matriz[0, 0] = 3;
            matriz[0, 1] = 7;
            matriz[1, 0] = 2;
            matriz[1, 1] = 9;
            int[,] matrizB = new int[2, 2];
            matrizB[0, 0] = 2;
            matrizB[0, 1] = 6;
            matrizB[1, 0] = 1;
            matrizB[1, 1] = 6;

            for(int i=0; i<2; i++)
            {
                for (int j= 0; j < 2; j++)
                {
                    
                    //Console.WriteLine(matriz[i, j]);
                    //Console.WriteLine("---------");
                    //Console.WriteLine(matrizB[i, j]);
                }
            }
            int  [,] matrizC = new int  [2, 2];
            int[,] matrizD = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrizC [i,j]= matriz[i,j ]* matrizB[i,j];
                    

                    Console.WriteLine(matrizC[i, j]);

                }
            }       Console.ReadKey();
        }
    }
}
