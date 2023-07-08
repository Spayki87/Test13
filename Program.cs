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
            const string CommandExit = "4";

            string userName;
            string userPassword;
            string userInput;
            string colorRed = "1";
            string colorBlye = "2";
            string colorGreen = "3";
            bool isExitProgram = true;

            Console.WriteLine("Добро пожаловать в программу.");

            while (isExitProgram)
            {
                Console.WriteLine(CommandYourName + " - введите свое имя.");
                Console.WriteLine(CommandSetPassword + " - введите пароль.");
                Console.WriteLine(CommandChangeConsoleColor + " - выберите текст консоли.");
                Console.WriteLine(CommandExit + " - если хотите выйти из программы.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandYourName:
                        Console.WriteLine("Ввдите свое имя:");
                        userName = Console.ReadLine();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine("Введите пароль:");
                        userPassword = Console.ReadLine();
                        break;

                    case CommandChangeConsoleColor:
                        Console.WriteLine("Выберите цвет консоли:");
                        Console.WriteLine(colorRed + " - красный цвет.");
                        Console.WriteLine(colorBlye + " - синий цвет.");
                        Console.WriteLine(colorGreen + " - зеленый цвет");
                        userInput = Console.ReadLine();

                        if (userInput == colorRed)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (userInput == colorBlye)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (userInput == colorGreen)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        }
                        break;

                    case CommandExit:
                        isExitProgram = false;
                        Console.WriteLine("Вы вышли из программы");
                        break;
                }
            }
        }
    }
}