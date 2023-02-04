using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Class3
    {
        public static void Dolg(string[,] students, int amm)
        {
            List<string> answer = new List<string>();
            while (true)
            {
                for (int i = 0; i < amm; i++)
                {
                    if (students[i,6] == "2" || students[i, 6] == "-1")
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
