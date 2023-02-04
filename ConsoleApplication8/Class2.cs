using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Class2
    {
        public static void Group(string[,] students, int amm)
        {
            Console.WriteLine("Введите номер группы: ");
            string gr = Console.ReadLine();
            List<string> answer = new List<string>();
            while (true) {
                for (int i = 0; i < amm; i++)
                {
                    if (students[i,4] == gr)
                    {
                        int counter = 0;
                        for (int j = 0; j<answer.Count();j++)
                        {
                            if (students[i,0] == answer[j])
                            {
                                counter++;
                            }
                        }
                        if(counter == 0)
                        {
                            Console.WriteLine(answer.Count() + 1 + ". " + students[i, 0]);
                            answer.Add(students[i,0]);
                        }
                    }
                }
                gr = Console.ReadLine();
                Console.Clear();
                break;
            }
        }
    }
}
