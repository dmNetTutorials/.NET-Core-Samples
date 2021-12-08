using System;

// Перевірка на відповідність CLS
[assembly: CLSCompliant(true)]
namespace IntroductionToCTS
{
    class Program
    {

        public class BaseClass
        {
            // Ім'я класу
            public string Name { get; set; }
            // Ідентифікатор класу
            public int ID { get; set; }
            // Поле рівня класу
            public static string Version = "1.0";
            // Захищена властивість 
            protected string Owner { get; set; }
            // Конструктор за замовчуванням
            public BaseClass() { }
            // Перевизначити метод 
            // для вивведення даних
            // у вигляді рядка тексту
            public override string ToString() => $"\nІм'я класу:\t{Name}\nІдентифікатор класу:\t{ID}";
        }

        internal class DerivedClass : BaseClass
        {
            // Конструктор за замовчуванням
            public DerivedClass()
            {
                Name = "Дочірній клас";
                ID = 12;
                Owner = "Базовий клас";
            }

            public override string ToString()
            {
                var firstPart = base.ToString();
                firstPart += $"\nВласник класу:\t{Owner}";
                return firstPart;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BaseClass baseClass = new BaseClass() { ID = 999, Name = "Базовий клас" };

            Console.WriteLine($"\nЗначення baseClass:\t{baseClass}");

            DerivedClass derivedClass = new DerivedClass();

            Console.WriteLine($"\nЗначення derivedClass:\t{derivedClass}");

            Console.WriteLine($"\nДоступ до поля рівня класу:\t{BaseClass.Version}");
            Console.WriteLine($"\nДоступ до поля рівня об'єкта класу:\t{derivedClass.Name}");

        }
    }
}
