using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Class4
    {
        public static void Otl(string[,] students, int amm)
        {
            List<string> answer = new List<string>();
            while (true)
            {
                for (int i = 0; i < amm; i++)
                {
                    int count = 1;
                    if (students[i, 6] == "5")
                    {
                        count -= 1;
                        for (int j = i; j < amm; j++)
                        {
                            if (students[j, 0] == students[i, 0])
                            {
                                if (students[j, 6] != "5")
                                {
                                    count += 1;
                                }
                            }
                        }
                    }
                    if (count == 0)
                    {
                        int counter = 0;
                        for (int j = 0; j < answer.Count(); j++)
                        {
                            if (students[i, 0] == answer[j])
                            {
                                counter++;
                            }
                        }
                        if (counter == 0)
                        {
                            Console.WriteLine(answer.Count() + 1 + ". " + students[i, 0]);
                            answer.Add(students[i, 0]);
                        }
                    }
                }
                string gr = Console.ReadLine();
                Console.Clear();
                break;
            }
        }
    }
}
