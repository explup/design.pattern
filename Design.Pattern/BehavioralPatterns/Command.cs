using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.CreationalPatterns
{
    public interface ICommand
    {
        void Do();
    }

    public class ReplayOnCommand : ICommand
    {
        public void Do()
        {
            Console.WriteLine("run replay on command");
        }
    }

    public class MetorOnCommand : ICommand
    {
        public void Do()
        {
            Console.WriteLine("run metor method command");
        }
    }

    public class ClutchOnCommand : ICommand
    {
        public void Do()
        {
            Console.WriteLine("run cluth on command");
        }
    }

    public interface ITransaction
    {
        bool Validate();
        void Execute();
    }

    public interface IPayClassifaction
    {
        void CalculatePay();
    }

    public class HourlyClassification : IPayClassifaction
    {
        public void CalculatePay()
        {
            Console.WriteLine("hourly classification");
        }
    }
    public class SalariedClassification : IPayClassifaction
    {
        public void CalculatePay()
        {
            Console.WriteLine("salaried classification");
        }
    }

    public class AddEmployeeTransaction : ITransaction
    {
        private IPayClassifaction _payClassifaction;
        public AddEmployeeTransaction(IPayClassifaction payClassifaction)
        {
            _payClassifaction = payClassifaction;
        }

        public void Execute()
        {
            Console.WriteLine("exeucte add exmployess transaction");
        }

        public bool Validate()
        {
            Console.WriteLine("validate");
            return true;
        }
    }
}
