using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPointsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            List<double> distribution = new List<double>();

            // read in points
            string points_txt_file = "";
            using(System.IO.StreamReader reader = new System.IO.StreamReader(points_txt_file))
            {
                string[] line;
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine().Split(new char[] { ' ' });
                    points.Add(new Point(double.Parse(line[0]), double.Parse(line[1]), double.Parse(line[2]));
                }
            }

            // read in distribution
            string distribution_txt_file = "";
            using(System.IO.StreamReader reader = new System.IO.StreamReader(distribution_txt_file))
            {
                while(!reader.EndOfStream)
                    distribution.Add(double.Parse(reader.ReadLine()));
            }
        }
    }
}
