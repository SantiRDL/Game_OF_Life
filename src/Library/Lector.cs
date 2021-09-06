using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Lector
    {
        public static bool[,] Leer(string url)
        {
        //string url = ruta;
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
        return Board;
        }
    }
}
