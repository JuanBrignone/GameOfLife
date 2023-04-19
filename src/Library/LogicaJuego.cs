using System;

namespace PII_Game_Of_Life
{
    public class LogicaDeJuego
    {
        private static Tablero tableroClon = new Tablero();
        public static void nuevaGeneracion(Tablero tablero)
        {
        int boardWidth = tablero.getWidth();
        int boardHeight = tablero.getHeight();
        tableroClon.NuevoTablero(tablero);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && tablero.getCell(i,j))
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(tablero.getCell(x,y))
                {
                    aliveNeighbors--;
                }
                if (tablero.getCell(x,y) && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    tableroClon.setCell(x,y,false);
                }
                else if (tablero.getCell(x,y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    tableroClon.setCell(x,y,false);
                }
                else if (!tablero.getCell(x,y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    tableroClon.setCell(x,y,true);
                }
            }
        }
        tablero.NuevoTablero(tableroClon);
        }
    }
}