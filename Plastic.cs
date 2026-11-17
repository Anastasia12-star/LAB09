using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Plastic : StoredObject, IDanger
    {
        public string PlasticType;
        public double Density;
        public Plastic(int inventoryNumber, string name, DateTime registrationDate, int storageTermDays, string plasticType,  double density)
        : base(inventoryNumber, name, registrationDate, storageTermDays)
        {
            PlasticType = plasticType;
            Density = density;
        }
        public void Warning()
        {
            Console.WriteLine($"ВНИМАНИЕ! Пластиковый объект: {Name} может выделять вредные вещества!");
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nВид пластика: {PlasticType}, \nПлотность: {Density} г/см^3";
        }
    }
}
