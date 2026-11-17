using System;
namespace LAB09
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Wooden wood1 = new Wooden(
                1,
                "Деревянные доски",
                DateTime.Today,
                365,
                "Сосна",
                true
            );
            Metal metal1 = new Metal(
                2,
                "Металлические трубы",
                DateTime.Today.AddDays(-60),
                30,
                "Сталь",
                25.5
            );
            Plastic plastic1 = new Plastic(
                3,
                "Пластиковые панели",
                DateTime.Today,
                365,
                "ПВХ",
                1.4
            );
            Metal metal2 = new Metal(
                4,
                "Алюминиевые трубы",
                DateTime.Today,
                365,
                "Алюминий",
                15.2
            );
            Plastic plastic2 = new Plastic(
                5,
                "Пластиковые контейнеры",
                DateTime.Today,
                365,
                "Пластик",
                0.9
            );
            Chemical chemical1 = new Chemical(
                6,
                "Растворитель",
                DateTime.Today,
                180,
                "Органическое вещество",
                "II класс"
            );
            Console.WriteLine("Добавление объектов");
            store.AddToStore(wood1);
            store.AddToStore(metal1);
            store.AddToStore(plastic1);
            store.AddToStore(metal2);
            store.AddToStore(plastic2);
            Console.WriteLine("Проверка хранения");
            store.AddToStore(chemical1);
            Console.WriteLine("Состояние склада");
            Console.WriteLine(store.ToString());
            Console.WriteLine("Удаление объекта");
            store.RemoveFromStore(metal2);
            Console.WriteLine("Удаление просроченного объекта");
            store.RemoveFromStore(wood1);
            Console.WriteLine("удаление опасного объекта");
            store.RemoveFromStore(wood1);
            Console.WriteLine("Добавление химического объекта");
            store.AddToStore(chemical1);
            Metal metal3 = new Metal(
                7,
                "Медные детали",
                DateTime.Today,
                365,
                "Медь",
                10.5
            );
            store.AddToStore(metal3);
            Console.WriteLine("Итоговое состояние склада");
            Console.WriteLine(store.ToString());
        }
    }

}

