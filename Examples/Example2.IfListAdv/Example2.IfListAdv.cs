using System;
using System.Collections.Generic;
using SharpPcap;

namespace SharpPcap.Test.Example5
{
    /// <summary>
    /// Obtaining the device list
    /// </summary>
    public class PcapFilter
    {
        /// <summary>
        /// Obtaining the device list
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            string ver = SharpPcap.Version.GetVersionString();
            /* Print SharpPcap version */
            Console.WriteLine("SharpPcap {0}, Example4.IfListAdv.cs", ver);

            /* Retrieve the device list */
            List<PcapDevice> devices = SharpPcap.Pcap.GetAllDevices();

            if(devices.Count<1)
            {
                Console.WriteLine("No device found on this machine");
                return;
            }
            
            Console.WriteLine();
            Console.WriteLine("The following devices are available on this machine:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            int i = 0;

            /* Scan the list printing every entry */
            foreach(PcapDevice dev in devices)
            {
                /* Description */
                Console.WriteLine(dev.ToString());
                Console.WriteLine();
                i++;
            }
            Console.Write("Hit 'Enter' to exit...");
            Console.ReadLine();
        }
    }
}
