using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithConsole
{
    /// <summary>
    /// Клас користувача
    /// </summary>
    public class User : ICloneable
    {
        #region Fields

        private string _firstName;
        private string _surName;
        private int _age;

        #endregion

        #region Properties

        /// <summary>
        /// Властивість для
        /// доступу до зміної,
        /// в якій зберігається ім'я
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                // Чи повторюється значення
                if (_firstName != value)
                {
                    // Записати нове значення
                    _firstName = value;
                }
            }
        }

        /// <summary>
        /// Властивість для
        /// доступу до зміної,
        /// в якій зберігається прізвише
        /// </summary>
        public string SurName
        {
            get { return _surName; }
            set
            {
                // Чи повторюється значення
                if (_surName != value)
                {
                    // Записати нове значення
                    _surName = value;
                }
            }
        }

        /// <summary>
        /// Властивість для
        /// доступу до зміної,
        /// в якій зберігається вік
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                // Чи повторюється значення
                if (_age != value)
                {
                    // Записати нове значення
                    _age = value;
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Використовується для створення 
        /// об'єкту користувача 
        /// з значеннями за замовчуванням
        /// </summary>
        public User() : this("", "", 0)
        {

        }

        /// <summary>
        /// Використовується для створення 
        /// об'єкту користувача 
        /// з вказаними значеннями 
        /// </summary>
        public User(string firstName, string surName, int age)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.Age = age;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Виведення інформації про користувача
        /// </summary>
        /// <returns>
        /// Виводиться в форматі:
        /// Ім'я, Прізвище, Вік
        /// </returns>
        public override string ToString()
        {
            return $"\nІмя:\t{FirstName}\nПрізвище:\t{SurName}\nВік:\t{Age}\n";
        }

        public bool SendMessage(User reciever)
        {
            string message = "TExt";

            IMail mail = new Mail();

            mail.SendTo(reciever);

            return false;
        }

        /// <summary>
        /// Метод призначений для створення
        /// незалежної копії об'єкта
        /// </summary>
        /// <returns>
        /// Копію користувача
        /// </returns>
        public object Clone()
        {
            return new User()
            {
                Age = this.Age,
                FirstName = this.FirstName,
                SurName = this.SurName,
            };
        }

        #endregion
    }
}
