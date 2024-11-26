using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartSpeaker : SmartDevice
    {
        // Private fields
        private int volume;
        private bool isPlaying;

        // Public properties
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }

        // Constructor
        public SmartSpeaker(int speakerDeviceID, string speakerDeviceName, int speakerVolume) : base(speakerDeviceID, speakerDeviceName)
        {
            this.Volume = speakerVolume;

        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine("This is a Smart Speaker");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Play status (Yes or no): {(isPlaying ? "YES" : "NO")}");
        }



    }
}
