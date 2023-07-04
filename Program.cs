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
            const string CommandWriteName = "5";

            string userInput;
            string yourName;
            int tryCount = 3;
            string password;
            string userInputPassword;
            int remainingAttempts;
            bool isExitProgram = true;

            Console.WriteLine("Добро пожаловать в программу.");

            while (isExitProgram == true)
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
                        yourName = Console.ReadLine();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine("Введите пароль:");
                        password = Console.ReadLine();

                        for (int i = 0; i < tryCount; i++)
                        {
                            Console.WriteLine("Введите пароль:");
                            userInputPassword = Console.ReadLine();

                            remainingAttempts = tryCount - i - 1;

                            if (password == userInputPassword)
                            {
                                Console.WriteLine("Пароль верный.");
                                Console.WriteLine(CommandWriteName + " - введите как вас будут называть в программе:");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Пароль не верный, у вас осталось " + (remainingAttempts) + " попыток.");
                            }
                        }
                        break;

                    case CommandChangeConsoleColor:
                        Console.WriteLine("Выберите красный цвет консоли:");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        break;

                    case (CommandIsEscExitProgram):
                        isExitProgram = false;
                        break;
                }

                Console.WriteLine("Вы вышли из программы");
            }
        }
    }
}
