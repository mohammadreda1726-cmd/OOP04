namespace Smart_Delivery_Management_System04
{
    internal class Program
    {


        #region Q1 Abstraction
        #region a) What is Abstraction in Object-Oriented Programming?
        /*
         * The abstract is a class that contains methods without a body 
         * that can be implemented in the class from which it is inherited, 
         * and an abstract class allows inheritance 
         * and does not create objects from it.
         */
        #endregion

        #region b) Why is abstraction considered one of the four pillars of OOP?

        // hiding the implementation details and showing only the essential of the objects

        #endregion

        #endregion

        #region Q2 Abstract Classes vs. Interfaces
        #region a) What is the difference between an Abstract Class and an Interface?
        /*
         * Abstract Class => has fields and  constructors, inherited only once
         * Interface      => does not have fields and  constructors, multiple interface
         */
        #endregion

        #region b) When would you choose an Interface instead of an Abstract Class?
        // If there is more than one inherited condition
        #endregion

        #region c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
        // 1) No 
        // 2) Yes
        #endregion
        #endregion


        static void Main()
        {

            Console.WriteLine("              Delivery Center");
            Console.WriteLine("==========================================");

            // a. Create StandardShipment
            StandardShipment standard = new StandardShipment("SH001","Laptop",10,45,new DeliveryAddress("Cairo", "Main Street", 10));

            // b. Create ExpressShipment
            ExpressShipment express = new ExpressShipment("SH002","Express Package",10,20,new DeliveryAddress("Cairo", "Nile Street", 20),30);

            // c. Create InternationalShipment
            InternationalShipment international = new InternationalShipment("SH003","International Package",20,100,new DeliveryAddress("Berlin", "Main Street", 30),"Germany");

            // Create DeliveryCenter
            DeliveryCenter center = new DeliveryCenter("Delivery Center");

            // d. Add all shipments to DeliveryCenter
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // e. Print all shipment details
            center.PrintAllShipments();


            Console.WriteLine("             Tracking Status");
            Console.WriteLine();

            // f. Print tracking status of every shipment
            Console.WriteLine(standard.GetTrackingStatus());
            Console.WriteLine(express.GetTrackingStatus());
            Console.WriteLine(international.GetTrackingStatus());


            Console.WriteLine("                Insurance");
            // g. Print insurance cost of every shipment
            Console.WriteLine($"Standard Shipment Insurance : {standard.CalculateInsurance():0.00} EGP");

            Console.WriteLine($"Express Shipment Insurance  : {express.CalculateInsurance():0.00} EGP");

            Console.WriteLine($"International Shipment Insurance : {international.CalculateInsurance():0.00} EGP");


            Console.WriteLine("        Interface Polymorphism");
            Console.WriteLine("        Demonstrated Successfully.");

            // h. Store shipment objects in ITrackable[]
            ITrackable[] trackableShipments =
            {
                standard,
                express,
                international
            };

            Console.WriteLine();
            Console.WriteLine("Tracking Status Using ITrackable[]:");

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            // i. Store shipment objects in IInsurable[]
            IInsurable[] insurableShipments =
            {
                standard,
                express,
                international
            };

            Console.WriteLine();
            Console.WriteLine("Insurance Values Using IInsurable[]:");

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine($"{shipment.CalculateInsurance():0.00} EGP");
            }
        }
    }
}
