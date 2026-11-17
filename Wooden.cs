using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Wooden : StoredObject, IDanger
    {
        public string WoodType;
        public bool IsFlammable;
        public Wooden(int inventoryNumber, string name, DateTime registrationDate, int storageTermDays, string woodType, bool isFlammable) 
        : base (inventoryNumber, name, registrationDate, storageTermDays)
        {
            WoodType = woodType;
            IsFlammable = isFlammable;
        }
        public void Warning()
        {
            if (IsFlammable)
            {
                Console.WriteLine($"ВНИМАНИЕ! Деревянный объект {Name} является пожароопасным");
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, \nВид ревесины: {WoodType}, \nЛегковоспламеняемость: {(IsFlammable ? "Да" : "Нет")}";
        }
    }
}
