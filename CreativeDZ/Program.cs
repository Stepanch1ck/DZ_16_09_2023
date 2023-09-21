using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreativeDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Выведите на экран информацию о каждом типе данных");
            Console.WriteLine("Тип данных | Максимальное значение | Минимальное значение");
            Console.WriteLine($" byte | {byte.MaxValue} | {byte.MinValue}\n" +
                $" sbyte | {sbyte.MaxValue} | {sbyte.MinValue}\n" +
                $" short | {short.MaxValue} | {short.MinValue}\n" +
                $" ushort | {ushort.MaxValue} | {ushort.MinValue}\n" +
                $" int | {int.MaxValue} |  {int.MinValue}\n" +
                $" uint | {uint.MaxValue} | {uint.MinValue}\n" +
                $" long | {long.MaxValue} | {long.MinValue}\n" +
                $" ulong | {ulong.MaxValue} |  {ulong.MinValue}\n" +
                $" float | {float.MaxValue} | {float.MinValue}\n" +
                $" double | {double.MaxValue} | {double.MinValue}\n" +
                $" decimal | {decimal.MaxValue} | {decimal.MinValue}\n" +
                $" char | {char.MaxValue} | {char.MinValue}");
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 2: Напишите программу, в которой принимаются данные пользователя в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\nпеременной, а затем распечатайте всю информацию в правильном формате. ");
            UserInfo User1 = new UserInfo();
            Console.WriteLine("Введите ваше имя");
            User1.Name = Console.ReadLine();
            Console.WriteLine("Введите ваш город:");
            User1.City = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            User1.Age =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш PIN-код:");
            User1.pincode = int.Parse(Console.ReadLine());
            Console.WriteLine($" Имя: {User1.Name}\n Город: {User1.City}\n Возраст: {User1.Age}\n PIN-код: {User1.pincode}");
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 3: Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – настрочные.");
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (Char.IsLower(c))
                {
                    output += Char.ToUpper(c);
                } else
                {
                    output += Char.ToLower(c);
                }
            }
            Console.WriteLine("Получена строка: "+ output);
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 4: Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");
            Console.WriteLine("Введите строку");
            string line= Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string subline = Console.ReadLine();
            int Count = 0;
            for (int i=0; i< line.Length-subline.Length+1; i++)
            {
                if (line.Substring(i, subline.Length) == subline)
                {
                    Count++;
                }
            }
            Console.WriteLine("Число вхождений:" + Count);
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 5: определить, сколько бутылок виски беспошлинной торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически\r\nпокрыла расходы на ваш отпуск.");
            Console.WriteLine("Введите стандартную цену виски:");
            int normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free");
            int salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = int.Parse(Console.ReadLine());
            double numberBottles = (holidayPrice) / (normPrice - salePrice);
            Console.WriteLine("Ответ:" + Math.Floor(numberBottles));
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 6: Воспроизвести разговор Гарри Поттера и дневника Тома Реддла.");
            Console.WriteLine("Консоль - Привет, как к тебе обращаться?");
            string name = Console.ReadLine();
            Console.WriteLine($"Консоль - Привет, {name}");
            Console.WriteLine("Пользователь - Ты знаешь что-то о тайной комнате?");
            Console.WriteLine("Консоль - Да");
            Console.WriteLine("Пользователь - Можешь рассказать о тайной комнате?(^人^)");
            Console.WriteLine("Консоль - Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Консоль - Но могу показать");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╰(*°▽°*)╯Магия╰(*°▽°*)╯");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 7: Вычислить контрольную сумму штрихкода");
            Console.WriteLine("Введите 12 цифр");
            int count = 0;
            int[] digits = new int[12];
            while (count < 12)
            {
                Console.WriteLine("Введите цифру: ");
                int digit = int.Parse(Console.ReadLine());
                if (digit < 0 || digit > 9)
                {
                    Console.WriteLine("Неправильная цифра");
                    continue;
                }
                digits[count]= digit;
                count++;
            }
            int checkdigit1 = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i%2==0)
                {
                    checkdigit1 += digits[i];
                } else
                {
                    checkdigit1 += 3 * digits[i];
                }
            }
            checkdigit1 %= 10;
            Console.WriteLine("Контрольная цифра: {0} ", checkdigit1);
            Console.WriteLine("Используем случайные цифры: ");
            Random random = new Random();
            int[] digitsRand = new int[12];
            for (int i = 0; i <12; i++)
            {
                digitsRand[i] = random.Next(0, 9);
                Console.Write($" {digitsRand[i]}");
            }
            int checkdigit2 = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    checkdigit2 += digitsRand[i];
                }
                else
                {
                    checkdigit2 += 3 * digitsRand[i];
                }
            }
            checkdigit2 %= 10;
            Console.WriteLine("\nКонтрольная цифра: {0}", checkdigit2);
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();
            Console.WriteLine("Задание 8: Создать структуру студента. Посчитать общий объем алкоголя и кто сколько процентов выпил.");
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Surname = "Иванов",
                Name = "Иван",
                ID = 1,
                DateOfBirth = new DateTime(2005, 1, 1),
                AlcoholismCategory = Student.Category.Alcoholic,
                AlcoholVolume = 200
            });
            students.Add(new Student
            {
                Surname = "Алексин",
                Name = "Александр",
                ID = 2,
                DateOfBirth = new DateTime(2006, 5, 6),
                AlcoholismCategory = Student.Category.PartyGoer,
                AlcoholVolume = 67
            });
            students.Add(new Student
            {
                Surname = "Попович",
                Name = "Василий",
                ID = 3,
                DateOfBirth = new DateTime(2005, 3, 30),
                AlcoholismCategory = Student.Category.Drinker,
                AlcoholVolume = 120
            });
            students.Add(new Student
            {
                Surname = "Петров",
                Name = "Петр",
                ID = 4,
                DateOfBirth = new DateTime(2004, 7, 14),
                AlcoholismCategory = Student.Category.NonDrinker,
                AlcoholVolume = 0
            });
            students.Add(new Student
            {
                Surname = "Сидоров",
                Name = "Михаил",
                ID = 5,
                DateOfBirth = new DateTime(2005, 12, 25),
                AlcoholismCategory = Student.Category.Alcoholic,
                AlcoholVolume = 156
            });
            double totalAlcoholVolume = 0;
            foreach (Student student in students)
            {
                totalAlcoholVolume += student.AlcoholVolume;
            }
            Console.WriteLine("Общий объем алкоголя:", + totalAlcoholVolume);
            foreach (Student student in students)
            {
                double percent = (student.AlcoholVolume/totalAlcoholVolume) * 100;
                Console.WriteLine($"{student.Surname} {student.Name} выпил {percent}% алкоголя");
            }
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();

        }
        public struct UserInfo
        {
            public string Name;
            public string City;
            public int Age;
            public int pincode;
        }
        public struct Student
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Category AlcoholismCategory { get; set; }
            public double AlcoholVolume { get; set; }

            public enum Category
            {
                Alcoholic = 'a',
                Drinker = 'b',
                PartyGoer = 'c',
                NonDrinker = 'd'
            }
        }
    }
}
