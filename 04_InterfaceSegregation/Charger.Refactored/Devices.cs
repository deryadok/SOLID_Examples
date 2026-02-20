namespace _04_InterfaceSegregation.Charger.Refactored
{
    public class Devices
    {
        public class Iphone : IChargeable, IDataTransferable, IWirelessChargeable
        {
            public void Charge()
            {
                Console.WriteLine("Charging iPhone...");
            }
            public void TransferData()
            {
                Console.WriteLine("Transferring data from iPhone...");
            }
            public void WirelessCharge()
            {
                Console.WriteLine("Wireless charging iPhone...");
            }
        }
        public class Mp3Player : IChargeable, IDataTransferable
        {
            public void Charge()
            {
                Console.WriteLine("Charging MP3 Player...");
            }
            public void TransferData()
            {
                Console.WriteLine("Transferring data from MP3 Player...");
            }
        }
    }
}
