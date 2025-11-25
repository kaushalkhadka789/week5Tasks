namespace OOPWorkshop
{
    public abstract class AbstractVehicle
    {
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}
