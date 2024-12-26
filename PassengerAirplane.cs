using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AirplaneAp5
{
    public class PassengerAirplane : Airplane
    {
        public int PassengerCapacity { get; set; }
        public bool HasBusinessClass { get; set; }

        // Конструктор для PassengerAirplane
        public PassengerAirplane(string name, string model, int range, decimal fuelConsumption,
                    DateTime manufactureDate, string foto, int passengerCapacity, bool hasBusinessClass) :
                    base(name, model, range, fuelConsumption, manufactureDate, foto)
        {
            PassengerCapacity = passengerCapacity;
            HasBusinessClass = hasBusinessClass;
        }

        // Переопределение ToString()
        public override string ToString()
        {
            return $"Пассажирский самолет: {Name}, Модель: {Model}, Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км, " +
              $"Дата производства: {ManufactureDate.ToShortDateString()}, Вместимость: {PassengerCapacity}, Бизнес-класс: {HasBusinessClass}";
        }
    }
}
