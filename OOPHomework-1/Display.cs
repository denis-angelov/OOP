using System;


namespace DefiningClassesPart1
{
    public class Display
    {

        //fields
        string size = null;
        string numberOfColours = null;

        //properties


        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string NumberOfColour
        {
            get { return this.numberOfColours; }
            set { this.numberOfColours = value; }
        }



    }
}
