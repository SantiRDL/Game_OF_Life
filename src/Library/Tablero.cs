using System;

namespace PII_Game_Of_Life
{
    public class Tablero
    {   
        private bool[,] gameBoard;
        private int boardWidth;
        private int boardHeight;

        public Tablero(bool[,] board)
        {
            
            this.gameBoard = board;
        }
    
        public void Ciclo()
        {
            bool[,] cloneboard = new bool[this.boardWidth, this.boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && this.gameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(this.gameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (this.gameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false;
                    }
                    else if (this.gameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false;
                    }
                    else if (!this.gameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = this.gameBoard[x,y];
                    }
                }
            }
            this.gameBoard = cloneboard;
            cloneboard = new bool[boardWidth, boardHeight];
        }

        
    }
}