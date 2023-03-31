// See https://aka.ms/new-console-template for more information

using Task_6_Class;

Car car = new  Car();

Console.WriteLine(car.FuelNow());
car.FuelUp(10);
car.FuelDown(15);
car.FuelUp(100);
car.FuelDown(150);
Console.WriteLine(car.FuelNow());


Car car1 = new Car(40);
Console.WriteLine(car1.FuelNow());
car1.FuelNow();
car1.FuelUp(10);
car1.FuelDown(15);
car1.FuelUp(100);
car1.FuelDown(150);
Console.WriteLine(car1.FuelNow());
