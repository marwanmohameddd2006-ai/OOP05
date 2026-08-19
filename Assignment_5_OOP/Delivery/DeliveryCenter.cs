using Assignment_5_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_OOP.Delivery
{
    internal class DeliveryCenter
    {
        #region Attrbiutes
        private Shipment[] shipments;
        private int count;
        private string? centername;
        #endregion

        #region Properites indexer
        public int Size { get; }

        public Shipment this[int index]
        {
            get
            {
                if (index < shipments.Length && index >= 0)
                {
                    return shipments[index];
                }
                return default!;

            }

            set
            {
                if (index < shipments.Length && index >= 0)
                {
                    shipments[index] = value;

                }

            }
        }



        public Shipment this[string trackcod]
        {
            get
            {
                if (!string.IsNullOrEmpty(trackcod))
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (shipments[i].TrackingCode == trackcod)
                            return shipments[i];
                    }
                }
                return default!;
            }
        }


        #endregion

        #region Properites
        public string CenterName
        {
            get
            {
                return centername!;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Inviled Vale");

                centername = value;
            }
        }
        #endregion

        #region Constructors
        public DeliveryCenter(int size)
        {
            Size = size;
            shipments = new Shipment[Size];
        }
        #endregion

        #region Method
        public bool AddShipment(Shipment Newshipment)
        {
            if (count >= Size)
                return false;

            shipments[count] = Newshipment;
            count++;

            return true;
        }

        public bool RemoveShipment(Shipment Newshipment)
        {
            for (int i = 0; i < Size; i++)
            {
                if (shipments[i] == Newshipment)
                {
                    shipments[i] = null!;
                    count--;
                    return true;
                }

            }
            return false;
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("Tracking Status \n");
            foreach (ITrackable t in shipments)
            {
                Console.WriteLine($"{t.GetTrackingStatus()}");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("Insurance\n");
            foreach (IInsurable t in shipments)
            {
                Console.WriteLine($"{t.CalculateInsurance()}");
            }
        }

        #endregion
    }
}
