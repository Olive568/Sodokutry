using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sodoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Suck = 0;
            int g = 0;
            List<int> temp3 = new List<int>();
            List<int> temp2 = new List<int>();
            List<int> temp1 = new List<int>();
            List<int>[] rows = new List<int>[9];
            List<int>[] cols = new List<int>[9];
            List<int>[] cells = new List<int>[9];
            List<int>[] rowsex = new List<int>[9];
            List<int>[] colsex = new List<int>[9];
            List<int>[] cellsex = new List<int>[9];
            int[,] board = new int[9, 9];
            Random rnd = new Random();
            bool cont = true;
            int count = 0;
            bool ohno = false;


            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    board[x, y] = 0;
                }
                rows[x] = new List<int>();
                cols[x] = new List<int>();
                cells[x] = new List<int>();
                    rowsex[x] = new List<int>();
                colsex[x] = new List<int>();
                cellsex[x] = new List<int>();
            }
            for(int x = 0; x < 9; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    rows[x].Add(y);
                    cols[x].Add(y);
                    cells[x].Add(y);
                    rowsex[x].Add(y);
                    colsex[x].Add(y);
                    cellsex[x].Add(y);
                }
            }
            while(cont)
            {
                ohno = false;
                cont = true;
                for(int x = 0; x < 9; x++)
                {
                    
                    temp1 = cols[x];
                    for (int y = 0; y < 9; y++)
                    {
                        
                        temp2 = rows[y];
                        g = (x / 3) + (y / 3) * 3;
                        temp3 = cells[g];

                        //if (x <= 2 && y <= 2)
                        //{
                        //    g = 0;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 2 && y <= 5)
                        //{
                        //    g = 1;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 2 && y <= 8)
                        //{
                        //    g = 2;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 5 && y <= 2)
                        //{
                        //    g = 3;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 5 && y <= 5)
                        //{
                        //    g = 4;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 5 && y <= 8)
                        //{
                        //    g = 5;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 8 && y <= 2)
                        //{
                        //    g = 6;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 8 && y <= 5)
                        //{
                        //    g = 7;
                        //    temp3 = cells[g];
                        //}
                        //else if (x <= 8 && y <= 8)
                        //{

                        //    g = 8;
                        //    temp3 = cells[g];
                        //}
                        for (int d = 0; d < 100000; d++)
                        {                           
                            

                                int a = rnd.Next(0, temp1.Count);
                                int a1 = temp1[a];

                                int b = rnd.Next(0, temp2.Count);
                                int b1 = temp2[b];

                                int c = rnd.Next(0, temp3.Count);
                                int c1 = temp3[c];

                            if (x == 8 && y == 8)
                            {
                                if (cells[8].Count != 0)
                                {
                                    ohno = true;
                                    x = 0;
                                    y = 0;
                                    
                                    cols = colsex;
                                    rows = rowsex;
                                    cells = cellsex;
                                    cont = true;
                                    break;
                                }
                            }
                            else if(ohno)
                            {
                                break;
                            }

                            
                            else if (a1 == b1 && b1 == c1)
                            {
                                Console.WriteLine(x + " " + y);
                                board[x, y] = a1;
                                cells[g].Remove(board[x,y]);
                                cols[x].Remove(board[x, y]);
                                rows[y].Remove(board[x, y]);
                                
                                Suck++;
                                for(int h = 0; h < 9; h++)
                                {
                                    for(int k = 0; k < 9; k++)
                                    {
                                        Console.Write(board[h, k] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                                
                                Console.WriteLine("match");
                                
                                break;
                            }
                        }
                    }
             if(Suck == 81)
                    {
                        
                        
                    }
                        }
            }

        }
    }
}

