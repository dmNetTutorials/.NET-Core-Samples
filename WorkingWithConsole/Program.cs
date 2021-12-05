using System;
using System.Text;

namespace WorkingWithConsole
{
    class Program
    {
        #region Enums

        enum MenuActions : byte
        {
            VALIDATE = 1,
            EXIT = 2
        }

        #endregion

        #region Fields

        private static User _user;
        private static User _anotherUser;

        #endregion

        #region Properties

        public static User CurrentUser
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                }
            }
        }

        public static User AnotherUser
        {
            get { return _anotherUser; }
            set
            {
                if (_anotherUser != value)
                    _anotherUser = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Програма запускається в 
        /// даній функції
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Увімкнення підтримки кириличних символів
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Menu(args);
            }
        }

        private static void Menu(string[] args)
        {
            Console.WriteLine("Оберіть дію:\n1)\tВиконати;\n2)\tВихід;");
            MenuActions action;
            if (args.Length != 0)
            {
                // зчитати параметри, які передав користувач під час
                // запуску програми через консоль
                action = (MenuActions)Convert.ToByte(args[0]);
            }
            else
            {
                // Зчитати обраний користувачем номер
                // пункту меню
                action = (MenuActions)Convert.ToByte(Console.ReadLine());
            }
            switch (action)
            {
                case MenuActions.VALIDATE:
                    Execute();
                    break;
                case MenuActions.EXIT:
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// Логіка програми
        /// </summary>
        private static void Execute()
        {
            EnterUserInfo();

            Console.WriteLine(CurrentUser);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(GetComputerInfo());
        }

        private static void EnterUserInfo()
        {
            string firstName, surName;
            int age;

            Console.WriteLine($"\nВведіть ім'я:\n");
            firstName = Console.ReadLine();

            Console.WriteLine($"\nВведіть прізвище:\n");
            surName = Console.ReadLine();

            Console.WriteLine($"\nВведіть вік:\n");
            int.TryParse(Console.ReadLine(), out age);

            CurrentUser = new User(firstName, surName, age);

            // Альтернативна версія створення користувача
            //CurrentUser = new User()
            //{
            //    FirstName = firstName,
            //    SurName = surName,
            //    Age = age,
            //};
        }

        /// <summary>
        /// Отримати відомості про поточний
        /// комп'ютер
        /// </summary>
        /// <returns></returns>
        private static string GetComputerInfo()
        {
            return $"\nОпераційна система:\t{Environment.OSVersion}\n" +
                $"Поточний користувач:\t{Environment.UserName}\n" +
                $"Кількість ядер процесора:\t{Environment.ProcessorCount}\n";
        }

        #endregion

    }
}
