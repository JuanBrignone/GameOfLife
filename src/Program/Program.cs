using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            while(true){
                ImprimirTablero.printTablero(tablero);
                LogicaDeJuego.nuevaGeneracion(tablero);
                Thread.Sleep(300);
            }
        }
    }
}