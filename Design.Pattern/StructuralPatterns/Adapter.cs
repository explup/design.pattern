using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.CreationalPatterns
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }
    public class Ligh : ISwitchable
    {
        public void TurnOff()
        {
            Console.WriteLine("turn off light");
        }

        public void TurnOn()
        {
            Console.WriteLine("turn on light");
        }
    }

    public class Fan : ISwitchable
    {
        public void TurnOff()
        {
            Console.WriteLine("turn off fan");
        }

        public void TurnOn()
        {
            Console.WriteLine("turn on fan");
        }
    }

    public class Switch
    {
        private readonly ISwitchable _switchableDevice;
        public Switch(ISwitchable switchableDevice)
        {
            _switchableDevice = switchableDevice;
        }

        public void ApplySwitchsignal(bool turnOn)
        {
            if (turnOn)
            {
                _switchableDevice.TurnOn();
            }
            else
            {
                _switchableDevice.TurnOff();
            }
        }
    }

    public class HuaweiLightInheritAdapter : HuaweiLight, ISwitchable 
    {
        public void TurnOff()
        {
            base.LightTurnOff();
        }

        public void TurnOn()
        {
            base.LightTurnOn();
        }
    }

    public class HuaweiLightDelegateAdapter : ISwitchable
    {
        private readonly HuaweiLight _huaweiLight;
        public HuaweiLightDelegateAdapter()
        {
            _huaweiLight = new HuaweiLight();
        }
        public void TurnOff()
        {
            _huaweiLight.LightTurnOff();
        }

        public void TurnOn()
        {
            _huaweiLight.LightTurnOn();
        }
    }


    /// <summary>
    /// 3rd ai light that can not has ISwitchable interface
    /// </summary>
    public class HuaweiLight
    {
        public void LightTurnOff()
        {
            Console.WriteLine("turn off light of huawei");
        }

        public void LightTurnOn()
        {
            Console.WriteLine("turn on light of huawei");
        }
    }


}
