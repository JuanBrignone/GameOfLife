using System;
using System.Text;
using System.Threading;

namespace  PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static void printTablero(Tablero tablerow)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<tablerow.getHeight();y++)
            {
                for (int x = 0; x<tablerow.getWidth(); x++)
                {
                    if(tablerow.getCell(x,y))
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);


        }
        
        

    }
    

}