using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
    class GenericList<T>
    {
        //fields
        
        T[] workArray;

        //constructor 
        public GenericList(int NumArray = 8)
        {    
        workArray = new T [NumArray]; 

        }


        //Methods 
        //TO DO Check all input parameters to avoid accessing elements at invalid positions.

        public void Add(T ElementToAdd)
        {
            T temp = workArray[0];
            int Len = workArray.Length;
            if ( !Compare(workArray[Len], default(T))) 
            {
                workArray = GrowArray(workArray);
            }
            for (int i =  1; i < Len; i++)
            {
                workArray[i] = temp;
                temp = workArray[i + 1];

            }

            workArray[0] = ElementToAdd;
        }

        public T ElementAt(int IndexAT)
        {
            return workArray[IndexAT];
        }

        public void RemoveAt(int IndexAT)
        {
            int Len = workArray.Length;
            for (int i =IndexAT;i< Len - 1;i++)
            {
                workArray[i] = workArray[i + 1];
            }
            workArray[Len] = default(T);
        }

        public void InsertAt(int IndexAT,T ElementToInsert)
        {           
            int Len = workArray.Length;
            T temp =workArray[IndexAT];
            if (IndexAT-1 > Len)
            {
                workArray= GrowArray(workArray);
            }
                for (int i = IndexAT+1; i < Len ; i++)
            {
                workArray[i] = temp;
                temp = workArray[i+ 1];
               
            }
            workArray[IndexAT] = ElementToInsert;
        }

        public void ClearList()
        {
            int Len = workArray.Length;
            for (int i = 0; i < Len; i++)
            {
                workArray[i] = default(T);

            }
        }

        public int Find(T ValueToFind)
        {
            int Len = workArray.Length;
            int indexOfFind=-1;

            for (int i = 0; i < Len; i++)
            {
                if (Compare(workArray[i], ValueToFind))
                {
                    indexOfFind = i;
                    break;
                }

            }
            return indexOfFind;
        }
        public override string  ToString()
        {
            int Len = workArray.Length;
            StringBuilder stringToReturn = new StringBuilder();

            stringToReturn.Append(workArray[0]);

            for (int i = 1 ; i < Len; i++)
            {
                stringToReturn.AppendFormat($" {workArray[i]}");
            }

            return stringToReturn.ToString();
        }

        //grow Array Method

           static  private T[] GrowArray(T[] OldAr)
        {
            int newLen = OldAr.Length * 2;
            T[] newAr= new T[newLen];

            for (int i = 0; i < OldAr.Length-1; i++)
            {
                newAr[i] = OldAr[i];
            }


            return newAr;
        }

        //compare generic method
        public bool Compare<M>(M x, M y)
        {
            return EqualityComparer<M>.Default.Equals(x, y);
        }
        public T Min()
        {
           

        }
        public T Max()
        {

        }
    }
}
