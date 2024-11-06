
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Shapes3D;

namespace FinalAssignment
{
    public static class Solver
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please provide the path to the input CSV file.");
                return;
            }

            string filepath = args[0];
            if (!File.Exists(filepath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            List<Shape3D> shapes = new List<Shape3D>();
            double total = 0;

            foreach (string line in File.ReadLines(filepath))
            {
                string[] lineData = line.Split(',');
                string shapeType = lineData[0].ToLower();

                switch (shapeType)
                {
                    case "cuboid":
                        shapes.Add(new Cuboid(
                            double.Parse(lineData[1]),
                            double.Parse(lineData[2]),
                            double.Parse(lineData[3])));
                        break;
                    case "cube":
                        shapes.Add(new Cube(double.Parse(lineData[1])));
                        break;
                    case "cylinder":
                        shapes.Add(new Cylinder(
                            double.Parse(lineData[1]),
                            double.Parse(lineData[2])));
                        break;
                    case "sphere":
                        shapes.Add(new Sphere(double.Parse(lineData[1])));
                        break;
                    case "prism":
                        shapes.Add(new Prism(
                            double.Parse(lineData[1]),
                            int.Parse(lineData[2]),
                            double.Parse(lineData[3])));
                        break;
                    case "area":
                        double scale = double.Parse(lineData[1]);
                        double areaTotal = 0;
                        foreach (var shape in shapes)
                        {
                            areaTotal += shape.GetSurfaceArea();
                        }
                        total += areaTotal * scale;
                        break;
                    case "volume":
                        scale = double.Parse(lineData[1]);
                        double volumeTotal = 0;
                        foreach (var shape in shapes)
                        {
                            volumeTotal += shape.GetVolume();
                        }
                        total += volumeTotal * scale;
                        break;
                }
            }

            Console.WriteLine($"The sum of measurements is {total.ToString("N2", CultureInfo.InvariantCulture)}.");
        }
    }
}
