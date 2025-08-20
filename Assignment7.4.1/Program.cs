namespace Assignment7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem airportParking = new ParkingSystem();
            airportParking.parkingSystem(2, 0, 1);
            airportParking.addCar(1);
            airportParking.addCar(2);
            airportParking.addCar(3);
            airportParking.addCar(1); 
            airportParking.addCar(1);
        }
    }
    public class ParkingSystem
    {
        public int BigCar;
        public int MediumCar;
        public int SmallCar;

        public ParkingSystem()
        {
            BigCar = 0;
            MediumCar = 0;
            SmallCar = 0;
        }

        public void parkingSystem(int big, int medium, int small)
        {
            BigCar = big;
            MediumCar = medium;
            SmallCar = small;
        }
        public bool addCar(int car)
        {
            switch(car)
            {
                case 1:
                    if (BigCar > 0)
                    {
                        BigCar--;
                        Console.WriteLine("Big car parked.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No space for big car.");
                    }
                    break;
                case 2:
                    if (MediumCar > 0)
                    {
                        MediumCar--;
                        Console.WriteLine("Medium car parked.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No space for medium car.");
                    }
                    break;
                case 3:
                    if (SmallCar > 0)
                    {
                        SmallCar--;
                        Console.WriteLine("Small car parked.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No space for small car.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid car type.");
                    break;
            }
            return false;
        }
    }
}
