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
            List<int>[] rows = new List<int>[9];
            List<int>[] cols = new List<int>[9];
            List<int>[] cells = new List<int>[9];
            int[,] board = new int[9, 9];
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
                    List<int> temp1 = new List<int>();
                    temp1 = cols[x];
                    for (int y = 0; y < 9; y++)
                    {
                        List<int> temp2 = new List<int>();
                        temp2 = rows[y];
                        List<int> temp3 = new List<int>();
                        if (x <= 2 && y <= 2)
                        {
                            temp3 = cells[0];
                        }
                        if (x <= 2 && y <=5)
                        {
                            temp3 = cells[1];
                        }
                        if (x <= 2 && y <= 8)
                        {
                            temp3 = cells[2];
                        }
                        if (x <= 5 && y <=2)
                        {
                            temp3 = cells[3];
                        }
                        if (x <= 5 && y <= 5)
                        {
                            temp3 = cells[4];
                        }
                        if (x <= 5 && y<=8)
                        {
                            temp3 = cells[5];
                        }
                        if (x <= 8 && y <= 2)
                        {
                            temp3 = cells[6];
                        }
                        if (x <= 8 && y <= 5)
                        {
                            temp3 = cells[7];
                        }
                        if (x <= 8 && y <= 8)
                        {
                            temp3 = cells[8];
                        }
                    }
                }
            }

        }
    }
}

