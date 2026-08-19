using Assignment_5_OOP.Delivery;
using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP
{
    internal class ExpressShipment:Shipment, IInsurable, ITrackable
    {
        #region Attrbiutes
        private decimal extra_fee;
        #endregion

        #region Constructor
        public ExpressShipment(string? TC, string? Des, double Wg, decimal DelF,DeliveryAddress dest, decimal exfe) : base(TC, Des, Wg, DelF,dest)
        { ExtraFeey = exfe; }
        #endregion

        #region Properites
        public decimal ExtraFeey
        {
            get { return extra_fee; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("inviled Value");

                extra_fee = value;
            }
        }
        //public override decimal EstimatedCost
        //{
        //    get { return (DeliveryFee) + ((decimal)Weight * 5) + ExtraFeey; }
        //}

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }

        public string GetTrackingStatus()
        {
            return $"Out for Delivery";
        }
        #endregion

        #region Method


        //public override string PrintShipment()
        //{
        //    return $"EpressShipment\n\nTrackingCode: {TrackingCode}  \nDes: {Description}  \nWeight: {Weight}kg  \nDeliveryFee: {DeliveryFee} EG \nEstimatedCost: {EstimatedCost} \n ExtraFee: {ExtraFeey}";

        //}
        #endregion
    }
}
