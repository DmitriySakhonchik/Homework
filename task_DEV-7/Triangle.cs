using System;

namespace TriangleAnalysis
{
    enum Types { NA, Scalene, Isosceles, Equilateral };

    class Triangle
    {
        private int type;

        public const string NOT_DETERMINED = "Type of the triangle is not determined.";
        public const string SCALENE = "The triangle is scalene (all sides of different lengths).";
        public const string ISOSCELES = "The triangle is isosceles (two sides of equal length).";
        public const string EQUILATERAL = "The triangle is equilateral (all sides the same length).";

        public const string NEGATIVE = "Input number/numbers is/are negative.";
        public const string TRIANGLE_INEQUALITY = "Triangle inequality fails (triangle can not exist).";

        public void DetermineType(string[] sides)
        {
            if ((Double.Parse(sides[0]) < 0) ||
                (Double.Parse(sides[1]) < 0) ||
                (Double.Parse(sides[2]) < 0))
            {
                throw new Exception(NEGATIVE);
            }
            if (!(CheckTriangleInequality(sides)))
            {
                throw new Exception(TRIANGLE_INEQUALITY);
            }

            if ((Double.Parse(sides[0]) == Double.Parse(sides[1])) && 
                (Double.Parse(sides[1]) == Double.Parse(sides[2])) &&
                (Double.Parse(sides[0]) == Double.Parse(sides[2])))
            {
                type = (int)Types.Equilateral;
            }
            else if ((Double.Parse(sides[0]) != Double.Parse(sides[1])) && 
                     (Double.Parse(sides[1]) != Double.Parse(sides[2])) &&
                     (Double.Parse(sides[0]) != Double.Parse(sides[2])))
            {
                type = (int)Types.Scalene;
            }
            else
            {
                type = (int)Types.Isosceles;
            }
        }

        public void ShowType()
        {
            Console.WriteLine();
            switch(type)
            {
                case (int)Types.Scalene:
                    Console.WriteLine(SCALENE);
                    break;
                case (int)Types.Isosceles:
                    Console.WriteLine(ISOSCELES);
                    break;
                case (int)Types.Equilateral:
                    Console.WriteLine(EQUILATERAL);
                    break;
                default:
                    Console.WriteLine(NOT_DETERMINED);
                    break;
            }
        }

        public bool CheckTriangleInequality(string[] sides)
        {
            bool triangleInequality;
            if ((Double.Parse(sides[0]) + Double.Parse(sides[1]) >= Double.Parse(sides[2])) &&
                (Double.Parse(sides[1]) + Double.Parse(sides[2]) >= Double.Parse(sides[0])) &&
                (Double.Parse(sides[0]) + Double.Parse(sides[2]) >= Double.Parse(sides[1])))
            {
                triangleInequality = true;
            }
            else
            {
                triangleInequality = false;
            }
            return triangleInequality;
        }
    }
}
