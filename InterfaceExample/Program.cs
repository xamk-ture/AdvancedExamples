namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            //var truck = new Truck();
           // var motorcycle = new Motorcycle();

            MoveVehicle(car);
            //MoveVehicle(truck);
            //MoveVehicle(motorcycle);
        }

        private static void MoveVehicle(IMovable vehicle)
        {
            vehicle.MoveForward();
        }
    }
}