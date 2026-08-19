using Assignment_5_OOP.Delivery;
using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP
{
    internal  class Shipment
    {
        #region Attrbiutes
        private string? trackingcode;
        private string? description;
        private double weight;
        private decimal deliveryfee;
        private DeliveryAddress destination;

        private static int counter;
        #endregion

        #region Properties

        public static int TotalShipmentsCreated
        { 
            get { return counter; }
            set {  counter = value; }
        }
        
           
        public string? TrackingCode
        {
            get
            {
                return trackingcode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingcode = value;
            }
        }

        public string? Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;


            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryfee; }

            private set
            {
                if (value > 0)
                    deliveryfee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public  decimal EstimatedCost { get; }

        #endregion

        #region Constructor
        public Shipment(string? TC)
        {
            TrackingCode = TC;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Zag");
        }
        public Shipment(string? TC, string? Des, double Wg, decimal DelF,DeliveryAddress dest)
        {
            TrackingCode = TC;
            Description = Des;
            Weight = Wg;
            DeliveryFee = DelF;
            Destination = dest;

            counter++;
        }

        static Shipment()
        {
            counter = 0;
            Console.WriteLine("static initialization has happened");
        }

        #endregion

        #region Method

       
       


        public void UpdateDeliveryFee(decimal fee)
        {
            DeliveryFee = fee;
        }
        public void Settracking(string track)
        {
            TrackingCode = track;
        }

        public void weight_update(double WG)
        {
            Weight += WG;
        }
        public void weight_update(double extraPcking, bool i)
        {
            if (i)
                Weight += (extraPcking);


        }


        #endregion
        public override string ToString()
        {
            return $"TrackingCode: {TrackingCode}  \nDes: {Description}  \nWeight: {Weight}kg  \nDeliveryFee: {DeliveryFee} EG \nEstimatedCost: {EstimatedCost}";
        }

        #region Assigment_5_OOP
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = Destination is null ? new DeliveryAddress("") : new DeliveryAddress(Destination.City);

            return copy;
        }

        public string? GetFullAddress()
        {
            return Destination.GetFullAddress();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }


        static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        public string TrackingStatus(ITrackable trackstatus)
        {
            return trackstatus.GetTrackingStatus();
        }




        #endregion
    }
}
