using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Game
    {
        public List<int>[] stacks=new List<int>[4];

        public bool canplace(int i)
        {
            if (stacks[i].Count == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool cantake(int i)
        {
            if (stacks[i].Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void move(int i,int j)
        {
            stacks[j].Add(stacks[i].Last());
            stacks[i].RemoveAt(stacks[i].Count-1);
        }
        public string output(int i)
        {
            string _str = "";
            for(int j = stacks[i].Count - 1; j >= 0; j--)
            {
                if (j == 0)
                {
                    string a = stacks[i][j].ToString();
                    _str = _str + a;
                }
                else
                {
                    string a = stacks[i][j].ToString();
                    _str = _str + a + "\r\n";
                }
            }
            return _str;
        }
        public bool win()
        {
            int check1 = 0;
            int check2 = 0;
            int check3 = 0;
            for(int i = 0; i < 4; i++)
            {
                int check = 0;
                for(int j = 0; j < stacks[i].Count; j++)
                {
                    if (stacks[i][j] == 1)
                    {
                        check++;
                    }
                }
                if (check == 3)
                {
                    check1 = 1;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int check = 0;
                for (int j = 0; j < stacks[i].Count; j++)
                {
                    if (stacks[i][j] == 2)
                    {
                        check++;
                    }
                }
                if (check == 3)
                {
                    check2 = 1;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int check = 0;
                for (int j = 0; j < stacks[i].Count; j++)
                {
                    if (stacks[i][j] == 3)
                    {
                        check++;
                    }
                }
                if (check == 3)
                {
                    check3 = 1;
                    break;
                }
            }
            if (check1 == 1 && check2 == 1 && check3 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Game(string[] input)
        {
            stacks[0] = new List<int>();
            stacks[1] = new List<int>();
            stacks[2] = new List<int>();
            stacks[3] = new List<int>();
            for (int i=0;i<input[0].Length;i++)
            {
                if(input[0][i]=='1' || input[0][i]=='2' || input[0][i] == '3')
                {
                    stacks[0].Add(int.Parse(input[0][i].ToString()));
                }
            }
            for (int i = 0; i < input[1].Length; i++)
            {
                if (input[1][i] == '1' || input[1][i] == '2' || input[1][i] == '3')
                {
                    stacks[1].Add(int.Parse(input[1][i].ToString()));
                }
            }
            for (int i = 0; i < input[2].Length; i++)
            {
                if (input[2][i] == '1' || input[2][i] == '2' || input[2][i] == '3')
                {
                    stacks[2].Add(int.Parse(input[2][i].ToString()));
                }
            }
            for (int i = 0; i < input[3].Length; i++)
            {
                if (input[3][i] == '1' || input[3][i] == '2' || input[3][i] == '3')
                {
                    stacks[3].Add(int.Parse(input[3][i].ToString()));
                }
            }
        }
    }
}
