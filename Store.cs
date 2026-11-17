using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Store
    {
        private List<StoredObject> objects = new List<StoredObject>();
        private bool HasWooden()
        {
            foreach (StoredObject obj in objects)
            {
                if (obj is Wooden)
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasChemical()
        {
            foreach (StoredObject obj in objects)
            {
                if (obj is Chemical)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddToStore(StoredObject s)
        {
            if (s == null)
            {
                Console.WriteLine("Ошибка! Объект не задан");
                return;
            }
            if (s is Wooden && HasChemical())
            {
                Console.WriteLine("Нельзя добавить деревянный объект, так как на складе уже есть химические объекты");
                return;
            }
            if (s is Chemical && HasWooden())
            {
                Console.WriteLine("Нельзя добавлять химический объект, так как на складе уже есть деревянный объекты");
                return;
            }
            if (s is IDanger dangerousObject)
            {
                dangerousObject.Warning();
            }
            objects.Add(s);
            Console.WriteLine($"Объект {s.Name} добавлен на склад!");
        }
        public void RemoveFromStore(StoredObject s)
        {
            if (s == null || !objects.Contains(s))
            {
                Console.WriteLine("Объект не найден");
                return;
            }
            bool isExpired = DateTime.Today > s.RegistrationDate.AddDays(s.StorageTermDays);
            if (s is IDanger || isExpired)
            {
                objects.Remove(s);
                Console.WriteLine($"Объект {s.Name} удален со склада");
            }
            else
            {
                Console.WriteLine($"Объект {s.Name} нельзя удалить: он не является опасным или срок его хранения не истек");
            }
        }
        public override string ToString()
        {
            if (objects.Count == 0)
            {
                return "Склад пуст.";
            }
            string result = "СПИСОК ОБЪЕКТОВ НА СКЛАДЕ\n";
            result += $"Количество объектов: {objects.Count}\n";
            result += "-----------------------------------\n";
            foreach (StoredObject obj in objects)
            {
                result += obj.ToString();
                result += "\n---------------------------------\n";
            }
            return result;
        }
    }
}
