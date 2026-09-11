using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System04
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {

        public override decimal EstimatedCost
        {
            get { return _estimatedcost; }
            set { _estimatedcost = value; }
        }

        public decimal CalculateInsurance()
        {
            Console.Write("Standard Shipment Insurance : ");
            return EstimatedCost * 0.05M;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH001 is Ready.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Standard Shipment\r\n \r\nTracking Code : {TrackingCode}\r\nDescription   : {Description}\r\nEstimated Cost: {EstimatedCost} EGP\r\n");
        }
    }
}
