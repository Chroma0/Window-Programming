using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int all_money=0;
            int input=0;
            double output_money=0;
            string[] choice = new string[] { "","","","","","" };
            double[] percentage = new double[] { 0, 0, 0, 0, 0, 0 };
            while (input != 8)
            {
                Console.WriteLine("(1) 輸入收入 (2) 輸入支出 (3) 新增項目 (4) 刪除項目 (5) 計算比例 (6) 查詢支出 (7) 剩餘金額 (8) 退出程式");
                Console.Write("輸入數字選擇功能: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        int input_money;
                        Console.Write("輸入金額: ");
                        string input_string = Console.ReadLine();
                        if (int.TryParse(input_string,out _)==true)
                        {
                            input_money = Int32.Parse(input_string);
                            if (input_money > 0)
                            {
                                all_money += input_money;
                            }
                            else
                            {
                                Console.WriteLine("收入不可為負數");
                            }
                        }
                        else
                        {
                            Console.WriteLine("請輸入數字");
                        }
                        break;
                    case 2:
                        if (choice[0] =="")
                        {
                            Console.WriteLine("請新增支出項目");
                        }
                        else
                        {
                            int i;
                            int input_num;
                            int money;
                            for(i = 0; i < 5; i++)
                            {
                                if (choice[i] != "")
                                {
                                    Console.Write("({0}) {1}", i+1, choice[i]);
                                }
                                else break;
                            }
                            Console.WriteLine();
                            Console.Write("輸入數字選擇支出項目: ");
                            input_num = Int32.Parse(Console.ReadLine());
                            if(input_num < 1 || input_num > i + 1)
                            {
                                Console.WriteLine("此數字不在範圍中");
                            }
                            else
                            {
                                Console.Write("輸入支出金額: ");
                                money = Int32.Parse(Console.ReadLine());
                                if( money > all_money)
                                {
                                    Console.WriteLine("存款不足");
                                }
                                else
                                {
                                    all_money -= money;
                                    output_money += money;
                                    percentage[input_num - 1] += money;
                                }
                            }
                        }
                        break;
                    case 3:
                        if(choice[4] != "")
                        {
                            Console.WriteLine("已無法再新增支出項目");
                        }
                        else
                        {
                            Console.Write("輸入項目名稱: ");
                            string input_str = Console.ReadLine();
                            for(int i = 0; i < 5; i++)
                            {
                                if(choice[i] == input_str)
                                {
                                    Console.WriteLine("支出項目已存在");
                                    break;
                                }
                                else if(choice[i] == "")
                                {
                                    choice[i] = input_str;
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        if (choice[0] == "")
                        {
                            Console.WriteLine("已無法再刪除支出項目");
                        }
                        else {
                            Console.Write("輸入項目名稱: ");
                            string input_str = Console.ReadLine();
                            if ((choice[0] != input_str) && (choice[1] != input_str) && (choice[2] != input_str) && (choice[3] != input_str) && (choice[4] != input_str))
                            {
                                Console.WriteLine("此項目不存在");
                            }
                            else
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    if (choice[i] == input_str)
                                    {
                                        output_money -= percentage[i];
                                        for(int j = i; j < 5; j++)
                                        {
                                            choice[j] = choice[j + 1];
                                            percentage[j] = percentage[j + 1];
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        if (output_money == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (choice[i] != "")
                                {
                                    Console.WriteLine("({0}) {1}: 0%", i + 1, choice[i]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (choice[i] != "")
                                {
                                    Console.WriteLine("({0}) {1}: {2}%", i + 1, choice[i], percentage[i] / output_money * 100);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("目前總支出: {0}", output_money);
                        Console.Write("輸入要查詢的項目: ");
                        string InputChoice = Console.ReadLine();
                        if ((choice[0] != InputChoice) && (choice[1] != InputChoice) && (choice[2] != InputChoice) && (choice[3] != InputChoice) && (choice[4] != InputChoice))
                        {
                            Console.WriteLine("此項目不存在");
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            if(choice[i] == InputChoice)
                            {
                                Console.WriteLine("{0}: {1}", choice[i], percentage[i]);
                                break;
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("剩餘金額為: {0}", all_money);
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
