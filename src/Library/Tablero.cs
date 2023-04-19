using System;

namespace PII_Game_Of_Life
{

    public class Tablero
    {

        public Tablero()
        {
            this.tablero = ConseguirTablero.CargarTablero();
        }
        private bool[,] tablero {get; set;}
        public void NuevoTablero(Tablero nuevoTablero)
        {
            this.tablero = nuevoTablero.tablero;
        }

        public int getHeight()
        {
            return this.tablero.GetLength(1);
        }

        public int getWidth()
        {
            return this.tablero.GetLength(0);
        }

        public bool getCell(int x, int y) 
        {
            return tablero[x,y];
        }

        public void setCell(int x,int y,bool alive)
        {
            tablero[x,y] = alive;
        }

    }




}