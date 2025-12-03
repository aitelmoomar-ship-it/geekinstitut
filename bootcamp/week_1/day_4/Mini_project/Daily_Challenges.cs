// using System;
// using System.Collections.Generic;

// namespace SphereChallenge
// {
//     public class Sphere : IComparable<Sphere>
//     {
//         public double Radius { get; set; }

//         public double Diameter
//         {
//             get { return Radius * 2; }
//             set { Radius = value / 2; }
//         }

//         public Sphere(double radius)
//         {
//             this.Radius = radius;
//         }

//         public double GetVolume()
//         {
//             return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
//         }

//         public double GetSurfaceArea()
//         {
//             return 4 * Math.PI * Math.Pow(Radius, 2);
//         }

//         public override string ToString()
//         {
//             return $"Sphere [Radius: {Radius:F2}, Diameter: {Diameter:F2}, Volume: {GetVolume():F2}]";
//         }

//         public static Sphere operator +(Sphere s1, Sphere s2)
//         {
//             return new Sphere(s1.Radius + s2.Radius);
//         }

//         public static bool operator >(Sphere s1, Sphere s2)
//         {
//             return s1.Radius > s2.Radius;
//         }

//         public static bool operator <(Sphere s1, Sphere s2)
//         {
//             return s1.Radius < s2.Radius;
//         }

//         public static bool operator ==(Sphere s1, Sphere s2)
//         {
//             if (ReferenceEquals(s1, null) && ReferenceEquals(s2, null)) return true;
//             if (ReferenceEquals(s1, null) || ReferenceEquals(s2, null)) return false;
//             return s1.Radius == s2.Radius;
//         }

//         public static bool operator !=(Sphere s1, Sphere s2)
//         {
//             return !(s1 == s2);
//         }

//         public override bool Equals(object obj)
//         {
//             if (obj is Sphere)
//             {
//                 return this.Radius == ((Sphere)obj).Radius;
//             }
//             return false;
//         }

//         public override int GetHashCode()
//         {
//             return Radius.GetHashCode();
//         }

//         public int CompareTo(Sphere other)
//         {
//             if (other == null) return 1;
//             return this.Radius.CompareTo(other.Radius);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("--- Sphere Challenge Demo ---\n");

//             Sphere s1 = new Sphere(5); 
//             Sphere s2 = new Sphere(2); 
            
//             Sphere s3 = new Sphere(0);
//             s3.Diameter = 20; 

//             Console.WriteLine($"S1: {s1}");
//             Console.WriteLine($"S2: {s2}");
//             Console.WriteLine($"S3 (via Diameter): {s3}");

//             Console.WriteLine("\n--- Calculations for S1 ---");
//             Console.WriteLine($"Volume: {s1.GetVolume():F2}");
//             Console.WriteLine($"Surface Area: {s1.GetSurfaceArea():F2}");

//             Console.WriteLine("\n--- Operators Test ---");
            
//             Sphere sumSphere = s1 + s2; 
//             Console.WriteLine($"S1 + S2 = {sumSphere}"); 

//             if (s3 > s1) Console.WriteLine("S3 is bigger than S1.");
//             else Console.WriteLine("S3 is smaller than S1.");

//             Sphere sCopy = new Sphere(5);
//             Console.WriteLine($"Is S1 == Copy? {s1 == sCopy}");

//             Console.WriteLine("\n--- Sorting List ---");
//             List<Sphere> spheres = new List<Sphere> { s3, s1, s2, sumSphere };
            
//             Console.WriteLine("Before Sort:");
//             foreach (var s in spheres) Console.Write($"{s.Radius} ");
            
//             spheres.Sort(); 
//             Console.WriteLine("\n\nAfter Sort:");
//             foreach (var s in spheres) Console.Write($"{s.Radius} ");
//             Console.WriteLine("\n");
//         }
//     }
// }