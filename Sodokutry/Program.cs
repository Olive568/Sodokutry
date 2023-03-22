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
            for(int x = 0; x < 9; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    rows[x].Add(y);
                    cols[x].Add(y);
                    cells[x].Add(y);
                }
            }
            while(cont)
            {
                
                cont = true;
                for(int x = 0; x < 9; x++)
                {
                    
                    temp1 = cols[x];
                    for (int y = 0; y < 9; y++)
                    {
                        
                        temp2 = rows[y];
                        
                        if (x <= 2 && y <= 2)
                        {
                            g = 0;
                            temp3 = cells[g];
                        }
                        else if (x <= 2 && y <=5)
                        {
                            g = 1;
                            temp3 = cells[g];
                        }
                        else if (x <= 2 && y <= 8)
                        {
                            g = 2;
                            temp3 = cells[g];
                        }
                        else if (x <= 5 && y <=2)
                        {
                            g = 3;
                            temp3 = cells[g];
                        }
                        else if (x <= 5 && y <= 5)
                        {
                            g = 4;
                            temp3 = cells[g];
                        }
                        else if (x <= 5 && y<=8)
                        {
                            g = 5;
                            temp3 = cells[g];
                        }
                        else if (x <= 8 && y <= 2)
                        {
                            g = 6;
                            temp3 = cells[g];
                        }
                        else if (x <= 8 && y <= 5)
                        {
                            g = 7;
                            temp3 = cells[g];
                        }
                        else if (x <= 8 && y <= 8)
                        {

                            g = 8;
                            temp3 = cells[g];
                        }
                        for(int i = 0; i < 100000; i++)
                        {
                            
                                int a = rnd.Next(0, temp1.Count);
                                int a1 = temp1[a];
                                Console.WriteLine(a1 + " cols");
                                int b = rnd.Next(0, temp2.Count);
                                int b1 = temp2[b];
                                Console.WriteLine(b1 + " rows");
                                int c = rnd.Next(0, temp3.Count);
                                int c1 = temp3[c];
                          
                            Console.WriteLine(c1 + " cells");
                            if (a1 == b1 && b1 == c1)
                            {
                                board[x, y] = a1;
                                cols[x].Remove(a1);
                                rows[y].Remove(b1);
                                cells[g].Remove(c1);
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
                        cont = false;
                    }
                        }
            }

        }
    }
}

