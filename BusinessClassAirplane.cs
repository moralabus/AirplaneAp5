using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AirplaneAp5
{

    public class BusinessClassAirplane : PassengerAirplane 
    {
        public int BusinessClassCapacity { get; set; } // Вместимость бизнес-класса
        public bool HasPrivateLounge { get; set; } // Наличие отдельного лаунжа
        public string[] Amenities { get; set; } // Доступные удобства

     
        public BusinessClassAirplane(string name, string model, int range, decimal fuelConsumption,
                     DateTime manufactureDate, string foto,
                     int passengerCapacity, bool hasBusinessClass,
                     int businessClassCapacity, bool hasPrivateLounge, string[] amenities) :
                     base(name, model, range, fuelConsumption, manufactureDate, foto, passengerCapacity, hasBusinessClass)
        {
            BusinessClassCapacity = businessClassCapacity;
            HasPrivateLounge = hasPrivateLounge;
            Amenities = amenities;
        }

        // Переопределение ToString()
        public override string ToString()
        {
            return $"Бизнес-класс самолет: {Name}, Модель: {Model}, Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км, " +
                $"Дата производства: {ManufactureDate.ToShortDateString()}, Вместимость: {PassengerCapacity}, " +
                $"Бизнес-класс: {HasBusinessClass}, Вместимость бизнес-класса: {BusinessClassCapacity}, " +
                $"Отдельный лаунж: {HasPrivateLounge}, Удобства: {string.Join(", ", Amenities)}";
        }
    }
}