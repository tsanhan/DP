namespace DP.Proxy
{
    class MechanicCarProxy : IRescue
    {
        private IRescue _car;
        public MechanicCarProxy(IRescue car)
        {
            this._car = car;
        }
        
        public void EndRepair()
        {
            this._car.EndRepair();
        }

        public float GetGasReport()
        {
            return this._car.GetGasReport();
        }

        public GPS GetLocation()
        {
            return this._car.GetLocation();
        }

        public void StartRepair()
        {
            this._car.StartRepair();
        }
    }
}