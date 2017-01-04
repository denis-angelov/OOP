using System;


namespace Defining_Classes___Part_2
{
    static class TwoPoints
    { 
        //method

        public  static int Distance(int Point1,int Point2)
        {
            int distance = int.Parse(Math.Sqrt(Point2 * Point2 + Point1 * Point1).ToString());
            return distance;
        }
      
    }
}
