using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] curriculum = new string[,] { {"","Sun","Mon","Tue","Wed","Thu","Fri","Sat" }
                                                  ,{"1","","","","","","","" }
                                                  ,{"2","","","","","","","" }
                                                  ,{"3","","","","","","","" }
                                                  ,{"4","","","","","","","" }
                                                  ,{"5","","","","","","","" }
                                                  ,{"6","","","","","","","" }
                                                  ,{"7","","","","","","","" }
                                                  ,{"8","","","","","","","" }
            };
            while (true) {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能: ");
                int input_num = int.Parse(Console.ReadLine());
                switch (input_num)
                {
                    case 1:
                        Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                        string input_str1 = Console.ReadLine();
                        int check1 = 0;
                        for(int i = 1; i < 9; i++)
                        {
                            for(int j = 1; j < 8; j++)
                            {
                                if (input_str1.Substring(0, 5) == curriculum[i, j])
                                {
                                    check1++;
                                }
                            }
                        }
                        if (check1 > 0)
                        {
                            Console.WriteLine("課程重複!");
                        }
                        else if (check1 == 0)
                        {
                            int day = Convert.ToInt32(input_str1.Substring(6, 1));
                            switch (day)
                            {
                                case 1:
                                    day = 2;
                                    break;
                                case 2:
                                    day = 3;
                                    break;
                                case 3:
                                    day = 4;
                                    break;
                                case 4:
                                    day = 5;
                                    break;
                                case 5:
                                    day = 6;
                                    break;
                                case 6:
                                    day = 7;
                                    break;
                                case 7:
                                    day = 1;
                                    break;
                            }
                            int start= Convert.ToInt32(input_str1.Substring(8, 1));
                            int end = Convert.ToInt32(input_str1.Substring(10, 1));
                            for(int i = start; i <= end; i++)
                            {
                                if(curriculum[i,day] != "")
                                {
                                    Console.WriteLine("課程衝堂!");
                                    check1++;
                                    break;
                                }
                            }
                            if (check1 == 0)
                            {
                                for(int i = start; i <= end; i++)
                                {
                                    curriculum[i, day] = input_str1.Substring(0, 5);
                                }
                                Console.WriteLine("成功加入課程!");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("請輸入要刪除的課程代號: ");
                        string input_str2 = Console.ReadLine();
                        int check2 = 0;
                        for(int i = 1; i < 9; i++)
                        {
                            for(int j = 1; j < 8; j++)
                            {
                                if (curriculum[i, j] == input_str2)
                                {
                                    curriculum[i, j] = "";
                                    check2++;
                                }
                            }
                        }
                        if (check2 == 0)
                        {
                            Console.WriteLine("課程 {0} 不在課表中", input_str2);
                        }
                        else{
                            Console.WriteLine("成功刪除課程: {0}",input_str2);
                        }
                        break;
                    case 3:
                        for(int i = 0; i < 9; i++)
                        {
                            for(int j = 0; j < 8; j++)
                            {
                                string s = string.Format("{0,-6}", curriculum[i,j]);
                                Console.Write(s);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        int credit = 0;
                        for(int i = 1; i < 9; i++)
                        {
                            for(int j = 1; j < 8; j++)
                            {
                                if(curriculum[i,j] != "")
                                {
                                    credit++;
                                }
                            }
                        }
                        Console.WriteLine("{0}", credit);
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                if(input_num == 5)
                {
                    break;
                }
            }
        }
    }
}
