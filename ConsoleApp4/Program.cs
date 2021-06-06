using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            var milk = new Item(01, "Молоко", 25.50, ItemType.food);
            var apples = new Item(02, "Яблоки", 50, ItemType.food);
            var client1 = new Client(01, "Иванов ИИ", "Воронеж", 123456, 0, 0, ClientType.important);
            var client2 = new Client(02, "Петров ПП", "Москва", 4567889, 0, 0, ClientType.unimportant);

            Console.Write("Введите Id клиента - ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество товаров:");
            Console.Write("Молоко - ");
            var countOfMilk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Яблоки - ");
            var countOfApples = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите тип оплаты: 1. Нал, 2. Безнал, 3. Кредит - ");
            var payType = Convert.ToInt32(Console.ReadLine());

            var item1 = new RequestItem(milk, countOfMilk);
            var item2 = new RequestItem(apples, countOfApples);

            if (id == 01)
            {
                var request1 = new Request(1, client1, DateTime.Today);
                switch (payType)
                {
                    case 1:
                        request1.type = PayType.cash;
                        break;
                    case 2:
                        request1.type = PayType.nonCash;
                        break;
                    case 3:
                        request1.type = PayType.credit;
                        break;
                }

                request1.items.Add(item1);
                request1.items.Add(item2);
                client1.countOfRequests++;
                client1.sum += request1.GetSum();
            }
        }
    }
}