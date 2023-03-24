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
       
            }
            
            while(cont)
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 1; y < 10; y++)
                    {
                        rows[x].Add(y);
                        cols[x].Add(y);
                        cells[x].Add(y);

                    }
                }

                for (int x = 0; x < 9; x++)
                {
                    
                    temp1 = cols[x];
                    for (int y = 0; y < 9; y++)
                    {
                        
                        temp2 = rows[y];
                        g = (x / 3) + (y / 3) * 3;
                        temp3 = cells[g];

                        for (int d = 0; d < 100000; d++)
                        {                           
                            

                                int a = rnd.Next(0, temp1.Count);
                                int a1 = temp1[a];

                                int b = rnd.Next(0, temp2.Count);
                                int b1 = temp2[b];

                                int c = rnd.Next(0, temp3.Count);
                                int c1 = temp3[c];

                            
                            if (a1 == b1 && b1 == c1)
                            {
                                Console.WriteLine(x + " " + y);
                                board[x, y] = a1;
                                cells[g].Remove(a1);
                                cols[x].Remove(a1);
                                rows[y].Remove(a1);
                                
                                
                                

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
                }

                // check if board is complete
                count = 0;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (board[x, y] > 0)
                        {
                            count++;
                        }
                    }
                }
                if (count == 81)
                {
                    cont = false;
                }
            }
        }
    }
}
