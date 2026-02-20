namespace _04_InterfaceSegregation.Charger.Refactored
{
    public interface IChargeable
    {
        void Charge();
    }

    public interface IDataTransferable
    {
        void TransferData();
    }

    public interface IWirelessChargeable
    {
        void WirelessCharge();
    }
}
