using System;

// Перевірка на відповідність CLS
[assembly: CLSCompliant(true)]
namespace IntroductionToCTS
{
    class Program
    {

        public interface IBaseClass
        {
            public int Size { get; set; }

            public void CalcSize();
        }

        public class BaseClass : IBaseClass
        {
            #region Fields

            private string _name;

            #endregion

            #region Properties

            // Ім'я класу
            public string Name
            {
                get => _name.ToUpper();
                set
                {
                    if (_name != value)
                    {
                        if (value.Length > 5)
                            _name = value;
                    }
                }
            }

            // Ідентифікатор класу
            public int ID { get; set; }

            #endregion

            // Поле рівня класу
            public static string Version = "1.0";
            // Захищена властивість 
            protected string Owner { get; set; }
            public int Size { get; set; }

            // Конструктор за замовчуванням
            public BaseClass() : this("", 0, 0) { }
            public BaseClass(int ID) : this("", 0, ID) { }
            public BaseClass(string Owner) : this(Owner, 0, 0) { }
            public BaseClass(string Owner, int Size, int ID)
            {
                this.ID = ID;
                this.Owner = Owner;
                this.Size = Size;
            }
            // Перевизначити метод 
            // для вивведення даних
            // у вигляді рядка тексту
            public override string ToString() => $"\nІм'я класу:\t{Name}\nІдентифікатор класу:\t{ID}";

            public void CalcSize()
            {
                throw new NotImplementedException();
            }
        }

        internal class DerivedClass : BaseClass
        {
            // Конструктор за замовчуванням
            public DerivedClass()
            {
                this.Name = "Дочірній клас";
                this.ID = 12;
                this.Owner = "Базовий клас";
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
            Console.InputEncoding = System.Text.Encoding.UTF8;

            BaseClass baseClass = new BaseClass() { ID = 999, Name = "Базовий клас" };

            Console.WriteLine($"\nЗначення baseClass:\t{baseClass}");

            DerivedClass derivedClass = new DerivedClass();

            Console.WriteLine($"\nЗначення derivedClass:\t{derivedClass}");

            Console.WriteLine($"\nДоступ до поля рівня класу:\t{BaseClass.Version}");
            Console.WriteLine($"\nДоступ до поля рівня об'єкта класу:\t{derivedClass.ID}");

        }
    }
}
