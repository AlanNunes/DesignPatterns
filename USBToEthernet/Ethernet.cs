using System;
using USBToEthernet.Interfaces;

namespace USBToEthernet
{
    public class Ethernet : IEthernet
    {
        public void TransferData(string data)
        {
            Console.WriteLine($"Transfering '{data}' through Ethernet...");
        }
    }
}
