using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace Program//gregado de namespace
{ 

    class Program
    {
            public void matrices()//se agrego un metodo para su reconocimiento
            {
                int[,] matriz = new int[3, 2];
                matriz[0, 0] = 1;
                matriz[0, 1] = 2;
                matriz[1, 0] = 3;
                matriz[1, 1] = 4;
                matriz[2, 0] = 5;
                matriz[2, 1] = 6;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Elemento en la posicion [{0},{1}]:{2}", i, j, matriz[i, j]);
                    }
                }
                Console.ReadLine();
            }
    static void Main(string[] args)// se menciona tanto el main como el program
        {
            Program pr = new Program();
            pr.matrices();//se inicia el metodo dirigido
        }
    }
}

