using AirplaneAp5;
using System.Reflection;
using System.Xml.Linq;
using System;

public class CargoAirplane : Airplane
{
    public int CargoCapacity { get; set; }
    public string CargoType { get; set; }

    // Конструктор для CargoAirplane
    public CargoAirplane(string name, string model, int range, decimal fuelConsumption,
              DateTime manufactureDate, string foto, int cargoCapacity, string cargoType) :
              base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        CargoCapacity = cargoCapacity;
        CargoType = cargoType;
    }

    public override string ToString()
    {
        return $"Грузовой самолет: {Name}, Модель: {Model}, Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км, " +
          $"Дата производства: {ManufactureDate.ToShortDateString()}, Грузоподъемность: {CargoCapacity}, Тип груза: {CargoType}";
    }
}