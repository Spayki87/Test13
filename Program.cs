using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_меню
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandYourName = "1";
            const string CommandSetPassword = "2";
            const string CommandChangeConsoleColor = "3";
            const string CommandIsEscExitProgram = "4";

            string userName;
            string userInput;
            bool isExitProgram = true;

            Console.WriteLine("Добро пожаловать в программу.");

            while (isExitProgram)
            {
                Console.WriteLine(CommandYourName + " - введите свое имя.");
                Console.WriteLine(CommandSetPassword + " - введите пароль.");
                Console.WriteLine(CommandChangeConsoleColor + " - выберите текст консоли.");
                Console.WriteLine(CommandIsEscExitProgram + " - если хотите выйти из программы.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandYourName:
                        Console.WriteLine("Ввдите свое имя:");
                        userName = Console.ReadLine();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine("Введите пароль:");
                        Console.ReadLine();
                        break;

                    case CommandChangeConsoleColor:
                        Console.WriteLine("Выберите цвет консоли:");
                        Console.WriteLine("1 - красный цвет.");
                        Console.WriteLine("2 - синий цвет.");
                        Console.WriteLine("3 - зеленый цвет");
                        userInput = Console.ReadLine();
                        if (userInput == "1")
                            Console.BackgroundColor = ConsoleColor.Red;
                        if (userInput == "2")
                            Console.BackgroundColor = ConsoleColor.Blue;
                        if (userInput == "3")
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        break;

                    case CommandIsEscExitProgram:
                        isExitProgram = false;
                        Console.WriteLine("Вы вышли из программы");
                        break;
                }
            }
        }
    }
}