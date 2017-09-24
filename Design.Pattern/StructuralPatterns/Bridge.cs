using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.CreationalPatterns
{
   public interface IModem
    {
        void Dial();
        void Hangup();
        void Send();
        void Receive();
    }

    public interface IModemImplementation
    {
        void Dial();
        void Hangup();
        void Send();
        void Receive();
    }

    public interface IDedicatedodem
    {
        void Send();
        void Receive();
    }

    public abstract class ModemConnectionController : IModem, IDedicatedodem
    {
        protected IModemImplementation _modemImplementation;

        public ModemConnectionController(IModemImplementation modemImplementation)
        {
            _modemImplementation = modemImplementation;
        }

        protected void DialImpl()
        {
            _modemImplementation.Dial();
        }

        protected void HangupImpl()
        {
            _modemImplementation.Hangup();
        }

        protected void ReceiveImpl()
        {
            _modemImplementation.Receive();
        }

        protected void SendImpl()
        {
            _modemImplementation.Send();
        }


        public abstract void Dial();

        public abstract void Hangup();

        public abstract void Receive();

        public abstract void Send();
    }

    public class DedModemController : ModemConnectionController
    {
        public DedModemController(IModemImplementation modemImplementation) : base(modemImplementation)
        {
        }
        public override void Dial()
        {
            Console.WriteLine("ded modem dial");
        }

        public override void Hangup()
        {
            Console.WriteLine("ded modem hangup");
        }

        public override void Receive()
        {
            base.ReceiveImpl();
        }

        public override void Send()
        {
            base.SendImpl();
        }
    }

    public class DialModemController : ModemConnectionController
    {
        public DialModemController(IModemImplementation modemImplementation) : base(modemImplementation)
        {
        }
        public override void Dial()
        {
            base.DialImpl();
        }

        public override void Hangup()
        {
            base.HangupImpl();
        }

        public override void Receive()
        {
            base.ReceiveImpl();
        }

        public override void Send()
        {
            base.SendImpl();
        }
    }



    public class HayesModem : IModemImplementation
    {
        public void Dial()
        {
            Console.WriteLine("hayes modem dial");
        }

        public void Hangup()
        {
            Console.WriteLine("Hayes modem hangup");
        }

        public void Receive()
        {
            Console.WriteLine("Hayes modem receive");
        }

        public void Send()
        {
            Console.WriteLine("Hayes modem send");
        }
    }

    public class USRoboticsModem : IModemImplementation
    {
        public void Dial()
        {
            Console.WriteLine("US Robotics modem dial");
        }

        public void Hangup()
        {
            Console.WriteLine("US Robotics modem hangup");
        }

        public void Receive()
        {
            Console.WriteLine("US Robotics modem receive");
        }

        public void Send()
        {
            Console.WriteLine("US Robotics modem send");
        }
    }


}
