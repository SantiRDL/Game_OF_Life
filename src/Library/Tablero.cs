using System;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase que contiene el tablero
    /// Tiene las responsabilidades de:
    ///     Conocer el tablero.
    ///     Encargarse de la evolucion de los cambios del mismo respetando las reglas de Comway.
    /// </summary>
    public class Tablero
    {   
        public bool[,] GameBoard;

    
        /// <summary>
        /// Metodo que se encarga de los cambios en el tablero.
        /// </summary>
        public void Ciclo()
        {
            int boardHeight = this.GameBoard.GetLength(1);
            int boardWidth = this.GameBoard.GetLength(0);
            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && this.GameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(this.GameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (this.GameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false;
                    }
                    else if (this.GameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false;
                    }
                    else if (!this.GameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = this.GameBoard[x,y];
                    }
                }
            }
            this.GameBoard = cloneboard;
            cloneboard = new bool[boardWidth, boardHeight];
        }

        
    }
}