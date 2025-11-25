namespace OOPWorkshop
{
    internal abstract class Vehicle
    {
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}
