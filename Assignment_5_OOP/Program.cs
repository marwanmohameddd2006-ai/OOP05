using Assignment_5_OOP.Delivery;
using Assignment_5_OOP.Shipment__Child;

namespace Assignment_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1  Object Copying

            //QA:
            //Q:What happens when you assign one object variable to another object variable?

            /*Ans: When we assign one object reference to another,
             * both references point to the same object in memory. 
             * No new object or copy of the data is created.
             */

            //==========================================================

            //QB:
            //Q:b) Does assigning one object to another create a new object? Explain

            /*Ans:
             * No not create a new object , both point to same object in memory
             */

            //==========================================================

            //QC:
            //Q: What is the difference between copying an object and copying its reference?

            /*Ans:
             *  In copying an object two object in stack have diffrent address but in heap point to same object
             *  In copying its reference two variable in stack have same address(copy address) so two variable ref
                to same data in heap
             */
            #endregion

            #region Q2  Shallow Copy vs Deep Copy

            //QA
            //Q: What is a Shallow Copy? 

            /*Ans:
             * Creat a new object and copies all value_typ fileds 
             * For refernce_typ fileds only refernce (linkes) are copied - bothe objects point to
               the same nasted objects
             */

            //==========================================================

            //QB:
            //Q: What is a Deep Copy? 

            /*Ans:
             * Creat a new object and recursively copies all nasted objects
             * The original and the copy are completely independent
             */

            //==========================================================

            //QC:
            //Q: What happens to reference-type members when a Shallow Copy is created? 

            /*Ans:
             * copy address so both point to same data in heap
             */

            //==========================================================

            //QD
            //Q:What happens to reference-type members when a Deep Copy is created? 

            /*Ans:
             * Creat new object with thier own copies of all nasted objects
             */

            //==========================================================

            //QE
            //Q: Give one situation where Deep Copy would be safer than Shallow Copy

            /*Ans:
             * Deep Copy is safer when we need two completely independent objects
             * For example ==> when copying  object that contains an Address object
             * Deep Copy changes the copied Address do not affect the original object
             */
            #endregion

            #region Q3  Static Members

            //QA
            //Q: What is a static field, and how is it different from an instance field?

            /*Ans:
             * 1- static field belong to the class not to any instance
             
             * 2- different is:
                      static shared by all object 
                      accessed using class name without creating an object
             */

            //==========================================================

            //QB:
            //Q:What is a static method? Can a static method directly access instance members?

            /*Ans:
             * 1- static member belong to the class not to any instance
             
             * 2- Cannot access instance members just can access static field
             */

            //==============================================================

            //QC:
            //Q: What is a static constructor, and when is it executed?


            /*Ans:
             * 1- static constructor Used to intilaize static members in class
                                     Called automatically by CLR , canot called manually
                                     Cannot take any paramters
                                     They are always private and cannot be explitly called 
             
             * 2- Executed ==> Called one time only [before first use of class]
             */

            //===================================================================

            //QD:
            //Q: What is a static class? Can you create an object from a static class? 



            /*Ans:
             * 1- A class that cannot be instantiated and can contain only static members.
             
             * 2- Cannot create an object from a static class 
             */

            #endregion

            #region Q4  Extension Methods 

            //QA
            //Q: What is an Extension Method? 

            /*Ans:
             * Extension Method: 
             * A method that allows you to add a new method to an existing type without modifying or inheriting from it.
             */

            //============================================================================================

            //QB:
            //Q: What keyword must be used in the first parameter of an extension method? 

            /*Ans:
             *  keyword ==> this.
             */

            //============================================================================================

            //QC
            //Q: Where must an extension method be declared?

            /*Ans:
             * Declared in static calss and must be static method
             */

            //============================================================================================

            //QD
            //Q:  Can an extension method access private members of the class it extends? 

            /*Ans:
             *  cannot access the private members of the class it extends
             *  because it is defined outside that class and does not have access to its private members.
             */


            #endregion
            #endregion

            #region Part 02 — Practical
            //DeliveryUtilities.PrintSeparator();
            //DeliveryUtilities.PrintSystemTitle();
            //DeliveryUtilities.PrintSeparator();

            //DeliveryAddress d1 = new DeliveryAddress("Cairo");
            //StandardShipment ss = new StandardShipment("SH001", "Laptop", 3, d1, 80);
            //ExpressShipment es = new ExpressShipment("SH002", "Mobile Phone", 2, 60, d1, 30); DeliveryUtilities.PrintSeparator();
            //InternationalShipment Is = new InternationalShipment("SH003", "Television", 8, 120, d1, "Germany", 100); Console.WriteLine("Creating Shipments... \n");
            //DeliveryUtilities.PrintSeparator();

            //Console.WriteLine($"{ss.GetType().Name} Created");
            //Console.WriteLine($"{es.GetType().Name} Created");
            //Console.WriteLine($"{Is.GetType().Name} Created\n");
            //Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}\n");
            ////=============================================================================================
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Object Copying\n");
            //DeliveryUtilities.PrintSeparator();

            //Shipment original1 = new Shipment("SH001", "Laptop", 3, 80, d1);
            //Shipment assigned = original1;
            //Console.WriteLine($"Original Shipment  : {original1.TrackingCode}");
            //Console.WriteLine($"assigned Shipment  : {assigned.TrackingCode}\n");

            //Console.WriteLine($"Same Object : {object.ReferenceEquals(original1, assigned)}\n");
            ////======================================================================================================
            //DeliveryAddress d2 = new DeliveryAddress("Cairo");
            //Shipment original2 = new Shipment("SH001", "Laptop", 3, 80, d2);
            //Console.WriteLine("------------------------------------------\n");
            //Console.WriteLine("Shallow Copy\n");
            //Console.WriteLine("------------------------------------------\n");

            //Shipment Copied1 = original2.ShallowCopy();

            //Console.WriteLine($"Original2 Shipment Address : {original2.Destination.City}");
            //Console.WriteLine($"Copied  Shipment Address : {Copied1.Destination.City}\n");

            //Copied1.Destination.City = "Giza";

            //Console.WriteLine("Changing copied shipment address...\n");
            //Console.WriteLine($"Original2 Shipment Address : {original2.Destination.City}");
            //Console.WriteLine($"Copied1  Shipment Address : {Copied1.Destination.City}\n");

            //if (original2.Destination.GetHashCode() == Copied1.Destination.GetHashCode())
            //{
            //    Console.WriteLine($"Same DeliveryAddress Object : True");
            //}
            //else
            //    Console.WriteLine($"Same DeliveryAddress Object : False");

            ////==========================================================================================================
            //DeliveryAddress d3 = new DeliveryAddress("Cairo");
            //Shipment original3 = new Shipment("SH001", "Laptop", 3, 80, d3);
            //Console.WriteLine("------------------------------------------\n");
            //Console.WriteLine("Deep Copy\n");
            //Console.WriteLine("------------------------------------------\n");
            //Shipment Copied2 = original3.DeepCopy();

            //Console.WriteLine($"Original3 Shipment Address : {original3.Destination.City}");
            //Console.WriteLine($"Copied2  Shipment Address : {Copied2.Destination.City}\n");

            //Copied2.Destination.City = "Giza";

            //Console.WriteLine("Changing copied shipment address...\n");
            //Console.WriteLine($"Original3 Shipment Address : {original3.Destination.City}");
            //Console.WriteLine($"Copied2  Shipment Address : {Copied2.Destination.City}\n");

            //if (original3.Destination.GetHashCode() == Copied2.Destination.GetHashCode())
            //{
            //    Console.WriteLine($"Same DeliveryAddress Object : True");
            //}
            //else
            //    Console.WriteLine($"Same DeliveryAddress Object : False");
            ////==============================================================================
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Extension Methods \n");
            //DeliveryUtilities.PrintSeparator();

            //Console.WriteLine($"{ShipmentExtensions.GetSummary(ss)}\n");
            //Console.WriteLine($"{ShipmentExtensions.GetSummary(es)}\n");
            //Console.WriteLine($"{ShipmentExtensions.GetSummary(Is)}\n");

            //Console.WriteLine($"{ss.TrackingCode} is Delivered {ShipmentExtensions.IsDelivered(ss)}\n");
            //Console.WriteLine($"{ss.TrackingCode} is Delivered {ShipmentExtensions.IsDelivered(Is)}\n");

            #endregion










        }
    }
}
