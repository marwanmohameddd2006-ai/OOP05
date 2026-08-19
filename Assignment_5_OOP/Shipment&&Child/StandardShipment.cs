using Assignment_5_OOP.Delivery;
using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP
{
    internal class StandardShipment:Shipment, IInsurable, ITrackable
    {
        public StandardShipment(string? TC, string? Des, double Wg, DeliveryAddress dest, decimal DelF) : base(TC, Des, Wg, DelF,dest)
        { }

        

        public string GetTrackingStatus()
        {
            return $"" +
                $"In Transit";
        }

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        //public override decimal EstimatedCost => (DeliveryFee + ((decimal)Weight * 5));
    }
}
