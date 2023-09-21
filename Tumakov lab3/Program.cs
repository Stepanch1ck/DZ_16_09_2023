using System;

namespace Tumakov_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков Лабораторная работа 3 Упражнение 3.1: Создать перечислимый тип данных отображающий виды банковского\r\nсчета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей\r\nзначение и вывести это значение на печать.");
            AccountType acctype = AccountType.Current;
            acctype = AccountType.Saving;
            Console.WriteLine("Тип счёта:" + acctype);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Тумаков Лабораторная работа 3 Упражнение 3.2: Создать структуру данных, которая хранит информацию о банковском\r\nсчете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру\r\nзначениями и напечатать результат.");
            BankAccount account = new BankAccount("12345678", AccountType.Current, 9999999999);
            Console.WriteLine("Номер счёта: {0} \nТип счёта: {1} \nБаланс счёта: {2}", account.Num, account.Type, account.Balance);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Тумаков Лабораторная работа 3 Домашнее задание 3.1: Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\nструктуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и распечатать.");
            Worker worker = new Worker();
            worker.Name = "Иванов Иван Иванович";
            worker.University = University.KGU;
            Console.WriteLine("Имя паботника: {0}\n ВУЗ работника {1}", worker.Name, worker.University);
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();




        }
        enum University
        {
            KGU,
            KAI,
            KHT
        }
        struct Worker
        {
            public string Name { get; set; }
            public University University { get; set; }
        }
        enum AccountType
        {
            Current,
            Saving
        }
        struct BankAccount
        {
            public string Num { get; set; }
            public AccountType Type { get; set; }
            public decimal Balance { get; set; }
            public BankAccount(string num, AccountType type, decimal balance)
            {
                Num = num;
                Type = type;
                Balance = balance;
            }

        }
    }
}

