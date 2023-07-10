using System;

public abstract class Vehicle
{
    public abstract void Start();


}

public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }
}

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }
}

public class VehicleManager
{
    public void StartVehicle(Vehicle vehicle)
    {
        vehicle.Start();
    }
}

//open close da uyuyor  StartVehicle değişitirlemiyor ama 
//override edilerek geliştebiliniyor

//loskov da uyuyor( start her iki farklı araç için de kullanbiliyor)  



