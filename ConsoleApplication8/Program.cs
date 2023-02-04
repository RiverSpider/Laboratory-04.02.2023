using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            Console.WriteLine("Введите количество ячеек: ");
            int pop = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[,] list = new string[pop,7];
            string[] student = new string[7];
            int amm = 0;
            Class2 gr = new Class2();
            Class3 dg = new Class3();
            Class4 ot = new Class4();
            Class5 gd = new Class5();
            while (true)
            {
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Студенты которые учатся в заданной группе");
                Console.WriteLine("3. Должники");
                Console.WriteLine("4. Отличники");
                Console.WriteLine("5. Моложе 20 лет");
                Console.WriteLine("6. Выйти");
                Console.WriteLine(a);
                string command = Console.ReadLine();
                if(command == "1"){
                    Console.Clear();
                    Console.WriteLine("ФИО");
                    list[amm,0] = Console.ReadLine();
                    Console.WriteLine("День рождения");
                    list[amm, 1] = Console.ReadLine();
                    Console.WriteLine("Месяц Рождения");
                    list[amm, 2] = Console.ReadLine();
                    Console.WriteLine("Год рождения");
                    list[amm, 3] = Console.ReadLine();
                    Console.WriteLine("Группа");
                    list[amm, 4] = Console.ReadLine();
                    Console.WriteLine("Предмет");
                    list[amm, 5] = Console.ReadLine();
                    Console.WriteLine("Оценка");
                    list[amm, 6] = Console.ReadLine();
                    amm = amm + 1;
                    Console.Clear();
                }
                else
                {
                    if (command == "2")
                    {
                        if (amm == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Нет студентов");
                            continue;
                        }
                        Console.Clear();
                        Class2.Group(list, amm);
                    }
                    else
                    {
                        if (command == "3")
                        {
                            if (amm == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Нет студентов");
                                continue;
                            }
                            Console.Clear();
                            Class3.Dolg(list, amm);
                        }
                        else
                        {
                            if (command == "4")
                            {
                                if (amm == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Нет студентов");
                                    continue;
                                }
                                Console.Clear();
                                Class4.Otl(list, amm);
                            }
                            else
                            {
                                if (command == "5")
                                {
                                    if (amm == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Нет студентов");
                                        continue;
                                    }
                                    Console.Clear();
                                    Class5.God(list, amm);
                                }
                                else
                                {
                                    if (command == "6")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Нет такой команды");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
