using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "C:/Users/ecasa/OneDrive - Universidad Católica del Uruguay/P2/Ejercicios/Game of Life/Game_OF_Life/assets/board.txt";
            Tablero tablero1 = new Tablero();
            Lector.Leer(url, tablero1);
            Impresion.MostrarEvolucion(tablero1);

        }
    }
}
