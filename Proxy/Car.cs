namespace DP.Proxy
{
    class Car : ICar, IRescue
    {
        private GPS gps;
        private float gasLevel;
        
        public void CloseDoor()
        {
            System.Console.WriteLine("Car: Close door");
        }

        public void Drive()
        {
            System.Console.WriteLine("Car: Drive");
        }

        public void EndRepair()
        {
            System.Console.WriteLine("Car: End repair");
        }

        public float GetGasReport()
        {
            return gasLevel;
        }

        public GPS GetLocation()
        {
            return gps;
        }

        public void Lights()
        {
            System.Console.WriteLine("Car: Lights");
        }

        public void OpenDoor()
        {
            System.Console.WriteLine("Car: Open door");
        }

        public void Reverse()
        {
            System.Console.WriteLine("Car: Reverse");
        }

        public void StartRepair()
        {
            System.Console.WriteLine("Car: Start repair");
        }

        public void Stop()
        {
            System.Console.WriteLine("Car: Stop");
        }
    }
}