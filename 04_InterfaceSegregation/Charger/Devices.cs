namespace _04_InterfaceSegregation.Charger
{
    public class Devices
    {
        public class Iphone : IChargeAdaptor
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

        public class Mp3Player : IChargeAdaptor
        {
            public void Charge()
            {
                Console.WriteLine("Charging MP3 Player...");
            }
            public void TransferData()
            {
                Console.WriteLine("Transferring data from MP3 Player...");
            }
            public void WirelessCharge()
            {
                //Bir sınıfın implement etmek zorunda olduğu ama desteklemediği metotlarda NotImplementedException fırlatması, tasarımın yanlış olduğuna işarettir.
                throw new NotImplementedException("This device does not support wireless charging.");
            }
        }
    }
}
