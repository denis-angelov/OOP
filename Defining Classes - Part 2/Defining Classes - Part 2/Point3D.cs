using System;


namespace Defining_Classes___Part_2
{
    public struct Point3D
    {  //fields 
        private int xPoint;
        private int yPoint;
        private int zPoint;

        //static fields

        private static readonly Point3D pointO =new Point3D(0,0,0) ;

        //properties

        public int XPoint {

            get { return this.xPoint; }
            set { this.xPoint = value; }
        }
        public int YPoint
        {
            get { return this.yPoint; }
            set { this.yPoint = value; }
        }
        public int ZPoint
        {

            get { return this.zPoint; }
            set { this.yPoint = value; }
        }

        //static properties

       public Point3D PointO
        {
            get { return pointO; }
        }   


        //constructors
        public Point3D(int X,int Y,int Z)
        {
            this.xPoint = X;
            this.yPoint = Y;
            this.zPoint = Z;
        }





        //method 
        public override string ToString()
        {
            return string.Format($"X:{this.xPoint} Y:{this.yPoint} Z:{this.zPoint}");
        }
    }
}
