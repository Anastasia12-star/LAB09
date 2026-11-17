using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Chemical : StoredObject, IDanger
    {
        public string ChemicalType;
        public string HazardClass;
        public Chemical(int inventoryNumber, string name, DateTime registrationDate, int storageTermDays, string chemicalType, string hazardClass)
        : base(inventoryNumber, name, registrationDate, storageTermDays)
        {
            ChemicalType = chemicalType;
            HazardClass = hazardClass;
        }
        public void Warning()
        {
            Console.WriteLine($"ВНИМАНИЕ! Химический объект: {Name} представляют опасность при хранении!");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, \nТип химического вещества: {ChemicalType}, \nКласс опасности: {HazardClass}";
        }
    }
}
