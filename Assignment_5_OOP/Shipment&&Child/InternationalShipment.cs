using Assignment_5_OOP.Delivery;
using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP
{
    internal class InternationalShipment:Shipment, IInsurable, ITrackable
    {
        #region Attributes
        private string? destinationcountry;
        private decimal customsfee;
        #endregion

        #region Constructors
        public InternationalShipment(string? TC, string? Des, double Wg, decimal DelF, DeliveryAddress dest, string? descoun, decimal custfee) : base(TC, Des, Wg, DelF,dest)
        { CustomsFee = custfee; DestinationCountry = descoun!; }

        #endregion

        #region properites
        public string? DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Inviled");
                }
                destinationcountry = value;
            }
        }
        public decimal CustomsFee
        {
            get { return customsfee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Inviled Value");
                }
                customsfee = value;
            }
        }

        //public override decimal EstimatedCost
        //{
        //    get { return (DeliveryFee) + ((decimal)Weight * 5) + CustomsFee; }
        //}
        #endregion

        #region Method


        //public override string PrintShipment()
        //{
        //    return $"InternationalShipment\n\nTrackingCode: {TrackingCode}  \nDes: {Description}  \nWeight: {Weight}kg  \nDeliveryFee: {DeliveryFee} EG \nEstimatedCost: {EstimatedCost} \nDestinationCountry: {DestinationCountry} \nCustomsFee: {CustomsFee}";
        //}

        public virtual string GenerateCustomsReport()
        {
            return $"CustomsReport";
        }




        public string GetTrackingStatus()
        {
            return $"Delivered";
        }

        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost;
        }


        #endregion
    }
}
