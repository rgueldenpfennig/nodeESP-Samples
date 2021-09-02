using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;

namespace nodeESP.Blink
{
    /// <summary>
    /// Toggles the green main LED on and off in an interval of 1 second.
    /// Sample taken and modified from https://github.com/nanoframework/Samples/tree/main/samples/Blinky
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            var gpioController = new GpioController();

            // open pin 2 which controlls the green LED
            var ledPin = gpioController.OpenPin(
                2,
                PinMode.Output);

            // high value indicates switch off
            ledPin.Write(PinValue.High);

            var timeSpan = TimeSpan.FromSeconds(1);
            while (true)
            {
                // toggle LED on/off
                ledPin.Toggle();
                Thread.Sleep(timeSpan);
            }

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }
    }
}
