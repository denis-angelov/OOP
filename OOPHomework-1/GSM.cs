using System;
using System.Collections.Generic;

namespace DefiningClassesPart1
{
    public class GSM
    {
        //fields

        private string model;
        private string manufacturer;
        private string price = null;
        private string owner = null;

        private List<Call> callHistory;

        private Display display = new Display();
        private Battery battery = new Battery();


        //static field

        public static GSM IPhone4S = new GSM("4S", "Apple", "999", "Hipster");



        //constructors 


        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;

        }


        public GSM(string model, string manufacturer, string price) : this(model, manufacturer)
        {

            this.price = price;

        }





        public GSM(string model, string manufacturer, string price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }




        //Methods 

        public override string ToString()
        {
            return string.Format("Model: {0,-8}, Manufacturer: {1,-8}, Price: {2,-8},Owner: {3,-8} ",
                this.Model, this.Manufacturer, this.Price, this.Owner);
        }

        public void CallAddOrDelete()
        {

        }



        //properties


        public Call Call
        {
            get { return this.Call; }
            set { this.Call = value; }
        }



        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }


        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }


        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }


        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        //Problem 9. Call history

        private Call[] CallHistory
        {
            get { return this.callHistory; }
            set { this.CallHistory = value; }
        }




    }
}
