using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
    static public class PathStorage
    {
        static List<Point3D> Points = new List<Point3D>();
        //Methods

        private  static void Write(List<Point3D> ListPoints,string FilePath)
        {
            StreamWriter fileToWrite = new StreamWriter(FilePath);
            foreach (var point in ListPoints)
            {

                string line = String.Format("{0},{1},{2}", point.XPoint, point.YPoint, point.ZPoint);
                fileToWrite.WriteLine(line);

            }
            fileToWrite.Close();
        }

        public static void Save(string FilePath,List<Point3D>ListPoints)
        {
            Write( ListPoints, FilePath);
        }

        public static void Save(string FilePath, Point3D[] ListPoints)
        {
            Write(ListPoints.ToList(), FilePath);
        }

        public static List<Point3D> Load(string FilePath)
        {   List<Point3D> Point3dList = new List<Point3D>();
            StreamReader FileToRead = new StreamReader(FilePath);
            string line;
            while ((line = FileToRead.ReadLine()) != null)
             {
                int[] arLine = line.Split(',').Select(int.Parse).ToArray();
                Point3D pointToAdd = new Point3D(arLine[0], arLine[1], arLine[2]);
                Point3dList.Add(pointToAdd);
            }

           
            return Point3dList;
        }

    }
}
