using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP.Shipment__Child
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode}  |   {shipment.GetType().Name} |  {shipment.Weight}KG |  {shipment.TrackingStatus((ITrackable)shipment)}";
        }

       public static bool IsDelivered(this Shipment shipment)
        {
            if ((shipment.TrackingStatus((ITrackable)shipment) != "Delivered"))
                { return false; }
            return true ;

        }



    }
}
