using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    internal abstract class Shipment
    {
        private string _trackingcode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryfee;
        private DeliveryAddress _destination;

        public decimal _estimatedcost;

        public string TrackingCode
        {
            get { return _trackingcode; }
            set
            {
                bool IsNullOrNot;
                do
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Invalid TrackingCode");
                        IsNullOrNot = false;
                    }
                    _trackingcode = value;
                    IsNullOrNot = true;

                } while (!IsNullOrNot);
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                bool IsNullOrNot;
                do
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Invalid Description");
                        IsNullOrNot = false;
                    }
                    _description = value;
                    IsNullOrNot = true;

                } while (!IsNullOrNot);
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                bool IsGreaterOrNot;
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid Weight");
                        IsGreaterOrNot = false;
                    }
                    _weight = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryfee; }
            private set
            {
                bool IsGreaterOrNot;
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid DeliveryFee");
                        IsGreaterOrNot = false;
                    }
                    _deliveryfee = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }

        // Abstract Property
        public abstract decimal EstimatedCost { get; set; }

        // Abstract Method
        public abstract void PrintShipment();
    }
}
