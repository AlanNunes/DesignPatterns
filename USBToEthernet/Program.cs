using System;
using USBToEthernet.Interfaces;

namespace USBToEthernet
{
    class Program
    {
        static void Main(string[] args)
        {
            USB USB = new USB();
            Ethernet ethernet = new Ethernet();
            // Ethernet Adapter for USB
            IUSB ethernetAdapter = new EthernetAdapter(ethernet);
            USB.TransferData("hello world!");
            ethernet.TransferData("hello world!");
            Console.WriteLine("Now using Ethernet Adapter");
            ethernetAdapter.TransferData("hello world!");
        }
    }
}
