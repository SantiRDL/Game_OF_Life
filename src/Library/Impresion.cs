using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Responsabilidad: Imprimir en consola la evolución del tablero. 
    /// Colabora con la clase Tablero.
    /// </summary>
    public class Impresion
    {
        /// <summary>
        /// Toma un tablero como parametro e imprime cada ciclo de evolucion del mismo.
        /// </summary>
        /// <param name="tablero"></param>
        public static void MostrarEvolucion(Tablero tablero)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<tablero.GameBoard.GetLength(1);y++)
                {
                    for (int x = 0; x<tablero.GameBoard.GetLength(0); x++)
                    {
                        if(tablero.GameBoard[x,y])
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
                tablero.Ciclo();

                Thread.Sleep(300);
            }
        }
    }
}