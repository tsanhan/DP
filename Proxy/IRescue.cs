namespace DP.Proxy
{
    interface IRescue
    {
        void StartRepair();
        void EndRepair();
        float GetGasReport();
        GPS GetLocation();

    }
}