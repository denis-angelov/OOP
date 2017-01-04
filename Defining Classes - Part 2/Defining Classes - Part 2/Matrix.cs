using System;
using System.Collections;
using System.Collections.Generic;


namespace Defining_Classes___Part_2
{
    class Matrix<T>
        where T: struct, IComparable,IConvertible
    { //field
       
       private int x;
       private int y;
       private int [,] matrix;

        //constructor 
        public Matrix(T x,T y)
        {
            if (NumCheck(x))
            {
                  this.x = NumConvert(x);
              

            }
            if (!NumCheck(x))
            {
                throw new ArgumentException("The number of rows  must be positive  Int,Float or Double!");
            }


            if (NumCheck(y))
            {
                  this.y = NumConvert(y);

            }
            if(!NumCheck(y))
            {
                throw new ArgumentException("The number of rows  must be positive  Int,Float or Double!");
            }
            this.matrix =  new int [x, y];   

        }


     //properties 

        public int X
        {
            get { return this.x; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of coloumns must be a positive value!");
                }


                this.x = value; }
        }

        public int Y
        {
         get { return this.y; }
         set {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of rows must be a positive value!");
                }


                this.y = value;
            }
        }

        //Methods

        //Indexer
        public T this[int x, int y]
        {
            get
            {
                return this.matrix[x, y];
            }
            set
            {
                this.matrix[x, y] = value;
            }
        }

        //Method to Check if number is  Int,Float or Double;
        private static bool NumCheck(T number)
        {

            switch (Type.GetTypeCode(number.GetType()))
            {
                case TypeCode.Int16:
                case TypeCode.Double:
                case TypeCode.UInt32:

                    return true;
                default:
                    return false;
            }
        }

        //Method to convert number;
        private static int  NumConvert(T number)
        {
            int result;
            switch (Type.GetTypeCode(number.GetType()))
            {
                case TypeCode.Int16:
                case TypeCode.Double:
                case TypeCode.UInt32:
               
                    result = int.Parse(number.ToString());
                    break;
                default:
                    throw new ArgumentException("The parameter must be positive  Int,Float or Double!");
            }


            return result;
        }
         



}
}
