namespace Task_6_Class;

public class Car
{
    // объявляем поле типа int
    private int fuel;
    private int fuelMax  = 100;
    private int fuelMin  = 0;

    // определяем 2 конструктора для введенныого уровня топлива
    public Car() {fuel = 50;}
    public Car(int f) {fuel = f;}

    
    public int FuelNow()
    {
        return fuel;
    }

    public int FuelUp( int fuelUp)
    {
        if ((fuel + fuelUp) < fuelMax)
        {
            Console.WriteLine($"Вы заправили {fuelUp}л");
            fuel = fuel + fuelUp;
            return fuel;
        }
        else
        {
            Console.WriteLine("Вы не заправились бак будет переполнен");
            return fuel;
        }
    }
    
    public int FuelDown( int fuelDown)
    {
        if ((fuel - fuelDown) > fuelMin)
        {
            Console.WriteLine($"Вы израсходовали {fuelDown}л");
            fuel = fuel - fuelDown;
            return fuel;
        }
        else
        {
            Console.WriteLine("Вы не можете истратить топлива больше чем есть в баке");
            return fuel;
        }
    }
}