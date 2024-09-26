using System;
namespace Program
{
    class Program{
        static void Main(string[] args){
           Point2D point1= new Point2D(1.3f, 1.4f);
           Point3D point2= new Point3D(1.4f,1.2f,1.5f);
            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());
        }
    }
}
