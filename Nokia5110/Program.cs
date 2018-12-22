using SecretLabs.NETMF.Hardware.Netduino;

namespace Nokia5110
{
    public class Program
    {
        public static Nokia.LCDScreens.Nokia_5110 Lcd = new Nokia.LCDScreens.Nokia_5110(true, Pins.GPIO_PIN_D4, PWMChannels.PWM_PIN_D10, Pins.GPIO_PIN_D5, Pins.GPIO_PIN_D3);

        public static void Main()
        {
            Lcd.Clear();
            Lcd.WriteText("willybilly.nl", false);
            Lcd.WriteText("               ", false);
            Lcd.WriteText("github.com/   ", false);
            Lcd.WriteText("willybilly90", false);
        }

    }
}
