using USBToEthernet.Interfaces;

namespace USBToEthernet
{
    public class EthernetAdapter : IUSB
    {
        private readonly IEthernet ethernet;

        public EthernetAdapter(IEthernet ethernet)
        {
            this.ethernet = ethernet;
        }

        public void TransferData(string data)
        {
            this.ethernet.TransferData(data);
        }
    }
}
