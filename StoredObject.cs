using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class StoredObject
    {
        public int InventoryNumber;
        public string Name;
        public DateTime RegistrationDate;
        public int StorageTermDays;
        public StoredObject(int inventoryNumber, string name, DateTime registrationDate, int storageTermDays)
        {
            InventoryNumber = inventoryNumber;
            Name = name;
            RegistrationDate = registrationDate;
            StorageTermDays = storageTermDays;
        }
        public override string ToString()
        {
            return $"Инвентарный номер: {InventoryNumber}, \nНазвание: {Name}, \nДата постановки на учет: {RegistrationDate.ToShortDateString()}, " +
                $"\nСрок хранения: {StorageTermDays}";
        }
    }
}
