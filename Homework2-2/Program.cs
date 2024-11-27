using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] checkerboard = new string[,]{
                {"","A","B","C","D","E","F","G","H" },
                {"1","-","-","-","-","-","-","-","-" },
                {"2","-","-","-","-","-","-","-","-" },
                {"3","-","-","-","-","-","-","-","-" },
                {"4","-","-","-","-","-","-","-","-" },
                {"5","-","-","-","-","-","-","-","-" },
                {"6","-","-","-","-","-","-","-","-" },
                {"7","-","-","-","-","-","-","-","-" },
                {"8","-","-","-","-","-","-","-","-" }
            };
            int check = 0;
            while (check < 64)
            {
                for(int i = 0; i < 9; i++)
                {
                    for(int j = 0; j < 9; j++)
                    {
                        Console.Write(String.Format("{0,2}", checkerboard[i, j]));
                    }
                    Console.WriteLine();
                }
                if (check % 2 == 0)
                {
                    Console.WriteLine("輪到玩家O 請輸入要下的位置:");
                    string input_str = Console.ReadLine();
                    int column=0, row=0;
                    for(int i = 0; i < 9; i++)
                    {
                        if (checkerboard[0,i] == input_str.Substring(0, 1))
                        {
                            column = i;
                        }
                        if (checkerboard[i, 0] == input_str.Substring(1, 1))
                        {
                            row = i;
                        }
                        if(column != 0 && row != 0)
                        {
                            break;
                        }
                    }
                    if (checkerboard[row, column] == "-")
                    {
                        int up=0,down=0,left=0,right=0;
                        for(int k = 1; k < 9; k++)
                        {
                            //up
                            if (checkerboard[k, column] == "O" && k<row && up==0)
                            {
                                checkerboard[row, column] = "O";
                                up++;
                                for (int i = k; i < row; i++)
                                {
                                    if (checkerboard[i, column] == "X")
                                    {
                                        checkerboard[i, column] = "O";
                                    }
                                }
                            }
                            //down
                            if(checkerboard[9-k,column]=="O" && ((9 - k) > row) && down==0)
                            {
                                checkerboard[row, column] = "O";
                                down++;
                                for(int i = 9 - k; k > row; k--)
                                {
                                    if (checkerboard[i, column] == "X")
                                    {
                                        checkerboard[i, column] = "O";
                                    }
                                }
                            }
                            //left
                            if (checkerboard[row, k] == "O" && k<column && left==0)
                            {
                                checkerboard[row, column] = "O";
                                left++;
                                for (int i = k; i < column; i++)
                                {
                                    if (checkerboard[row, i] == "X")
                                    {
                                        checkerboard[row, i] = "O";
                                    }
                                }
                            }
                            //right
                            if(checkerboard[row,9-k]=="O" && ((9 - k) > column) && right==0)
                            {
                                checkerboard[row, column] = "O";
                                for(int i = 9 - k; i > column; i--)
                                {
                                    if (checkerboard[row, i] == "X")
                                    {
                                        checkerboard[row, i] = "O";
                                    }
                                }
                            }
                            else if(k==8 && checkerboard[row,column]=="-")
                            {
                                checkerboard[row, column] = "O";
                            }
                        }
                        check++;
                    }
                    else
                    {
                        Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("輪到玩家X 請輸入要下的位置:");
                    string input_str = Console.ReadLine();
                    int column = 0, row = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        if (checkerboard[0, i] == input_str.Substring(0, 1))
                        {
                            column = i;
                        }
                        if (checkerboard[i, 0] == input_str.Substring(1, 1))
                        {
                            row = i;
                        }
                        if (column != 0 && row != 0)
                        {
                            break;
                        }
                    }
                    if (checkerboard[row, column] == "-")
                    {
                        int up = 0, down = 0, left = 0, right = 0;
                        for (int k = 1; k < 9; k++)
                        {
                            //up
                            if (checkerboard[k, column] == "X" && k < row && up == 0)
                            {
                                checkerboard[row, column] = "X";
                                up++;
                                for (int i = k; i < row; i++)
                                {
                                    if (checkerboard[i, column] == "O")
                                    {
                                        checkerboard[i, column] = "X";
                                    }
                                }
                            }
                            //down
                            if (checkerboard[9 - k, column] == "X" && ((9 - k) > row) && down == 0)
                            {
                                checkerboard[row, column] = "X";
                                down++;
                                for (int i = 9 - k; k > row; k--)
                                {
                                    if (checkerboard[i, column] == "O")
                                    {
                                        checkerboard[i, column] = "X";
                                    }
                                }
                            }
                            //left
                            if (checkerboard[row, k] == "X" && k < column && left == 0)
                            {
                                checkerboard[row, column] = "X";
                                left++;
                                for (int i = k; i < column; i++)
                                {
                                    if (checkerboard[row, i] == "O")
                                    {
                                        checkerboard[row, i] = "X";
                                    }
                                }
                            }
                            //right
                            if (checkerboard[row, 9 - k] == "X" && ((9 - k) > column) && right==0)
                            {
                                checkerboard[row, column] = "X";
                                for (int i = 9 - k; i > column; i--)
                                {
                                    if (checkerboard[row, i] == "O")
                                    {
                                        checkerboard[row, i] = "X";
                                    }
                                }
                            }
                            else if (k == 8 && checkerboard[row, column] == "-")
                            {
                                checkerboard[row, column] = "X";
                            }
                        }
                        check++;
                    }
                    else
                    {
                        Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
            }
            int winner = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(String.Format("{0,2}", checkerboard[i, j]));
                    if (checkerboard[i, j] == "O")
                    {
                        winner++;
                    }
                }
                Console.WriteLine();
            }
            if (winner > 32)
            {
                Console.WriteLine("遊戲結束 玩家O獲勝!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("遊戲結束 玩家X獲勝!");
                Console.Read();
            }
        }
    }
}
