namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car mazda3 = new Car(150, 15);
            RaceMotorcycle honda = new RaceMotorcycle(300, 30);
            honda.Drive(100);
            System.Console.WriteLine(honda);
        }
    }
}
