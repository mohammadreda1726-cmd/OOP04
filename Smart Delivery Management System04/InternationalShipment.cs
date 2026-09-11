using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string _destinationcountry;
        private decimal _customsfee;

        public string DestinationCountry
        {
            get { return _destinationcountry; }
            set
            {
                bool IsNullOrNot;
                do
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Invalid DestinationCountry");
                        IsNullOrNot = false;
                    }
                    _destinationcountry = value;
                    IsNullOrNot = true;

                } while (!IsNullOrNot);
            }
        }

        public decimal CustomsFee
        {
            get { return _customsfee; }
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
                    _customsfee = value;
                    IsGreaterOrNot = true;

                } while (!IsGreaterOrNot);
            }
        }
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5) + CustomsFee;
            set => CustomsFee = value;
        }

        public decimal CalculateInsurance()
        {
            Console.Write($"International Shipment Insurance : ");
            return EstimatedCost * 0.12M;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH003 has been Delivered.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"International Shipment\r\n \r\nTracking Code: {TrackingCode}\r\nDestination Country: {DestinationCountry}\r\nEstimated Cost : {EstimatedCost} EGP\r\n");
        }
    }
}
