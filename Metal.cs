using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Metal : StoredObject
    {
        public string MetalType;
        public double Weight;
        public Metal(int inventoryNumber, string name, DateTime registrationDate, int storageTermDays, string metalType,  double weight)
        : base (inventoryNumber, name, registrationDate, storageTermDays)
        { 
            MetalType = metalType;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, \nВид металла: {MetalType}, \nВес: {Weight} кг";
        }
    }
}
