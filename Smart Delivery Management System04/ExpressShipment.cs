using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal _extrafee;
        public decimal ExtraFee
        {
            get { return _extrafee; }
            set
            {
                bool IsGreaterOrNot;
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid ExtraFee");
                        IsGreaterOrNot = false;
                    }
                    _extrafee = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
            set { ExtraFee = value; }
        }

        public decimal CalculateInsurance()
        {
            Console.Write("Express Shipment Insurance : ");
            return EstimatedCost * 0.08M;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH002 is Out for Delivery.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Express Shipment\r\n \r\nTracking Code : {TrackingCode}\r\nExtra Fee     : {ExtraFee} EGP\r\nEstimated Cost: {EstimatedCost} EGP\r\n");
        }
    }
}
