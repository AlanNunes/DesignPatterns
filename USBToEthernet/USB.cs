using System;
using USBToEthernet.Interfaces;

namespace USBToEthernet
{
    public class USB : IUSB
    {
        public void TransferData(string data)
        {
            Console.WriteLine($"Transfering '{data}' through USB...");
        }
    }
}
