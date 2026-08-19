using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP.Delivery
{
    internal class DeliveryAddress
    {
        #region Attrbiuts
        private string? street;
        private string? city;
        private int buildingnumber;
        #endregion

        #region Constructors
        public DeliveryAddress(string? City)
        {

            city = City;
            //street = Street;
            //buildingnumber = BuildingNumber;
        }
        #endregion

        #region Get&Set Method
        public string? GetFullAddress()
        {
            return $"City is: {city}" /*\nin Street: {street}\nBuildingNumber: {buildingnumber}*/ ;
        }
        #endregion

        #region Properties
        public string? City
        {
            get{return city;}
            set { city = value; }
        }
        //public string? Street
        //{
        //    //get { return street; }
        //    set { street = value; }
        //}
        //public int BuildingNumber
        //{
        //    //get{return buildingnumber;}
        //    set { buildingnumber = value; }
        //}
        #endregion
    }
}
