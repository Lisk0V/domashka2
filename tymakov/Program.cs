using System;
using Enums;
using Struct;

namespace tymakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            
            AccType account = AccType.Текущий;
            Console.WriteLine($"Тип счета: {account}");
            // 2 задание
            
            dataBank account1;
            account1.Number = 111;
            account1.Type = "Сберегательный";
            account1.Balance = 100;
            Console.WriteLine($"Номер: {account1.Number}");
            Console.WriteLine($"Тип: {account1.Type}");
            Console.WriteLine($"Баланс: {account1.Balance}");
            // 3 задание
            
            Worker worker;
            worker.Name = "Александр";
            worker.Vuz = Vuz.КХТИ;
            Console.WriteLine($"Работник: {worker.Name}");
            Console.WriteLine($"Вуз: {worker.Vuz}");

        }
    }
}
