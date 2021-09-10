using System;
using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Carga traduce un txt a bool[,] y lo carga en el atributo GameBoard de un objeto Tablero.
    /// Responsabilidades:
    ///     Traducir el txt a bool[,].
    ///     Cargar el bool[,] al tablero.
    ///Colabora con la clase Tablero.
    /// </summary>
    public class Lector
    {
        public static void Leer(string url, Tablero tablero)
        {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] Board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    Board[x,y]=true;
                }
            }
        }
        tablero.GameBoard = Board;
        }
    }
}
