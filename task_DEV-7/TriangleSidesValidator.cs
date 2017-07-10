using System;

namespace TriangleAnalysis
{
    class TriangleSidesValidator
    {
        private string[] sides;

        public const string NEGATIVE = "Input number/numbers is/are negative.";
        public const string TRIANGLE_INEQUALITY = "Triangle inequality fails (triangle can not exist).";
        public const string SIDES_LENGTHS_NUMBER = "The number of LTS is not equal to 3.";

        public TriangleSidesValidator(string[] sides)
        {
            this.sides = sides;
        }

        public void CheckValidity()
        {
            CheckLength();
            CheckNegativity();
            CheckTriangleInequality();
        }

        public void CheckLength()
        {
            if (sides.Length != 3)
            {
                throw new Exception(SIDES_LENGTHS_NUMBER);
            }
        }

        public void CheckNegativity()
        {
            if ((Double.Parse(sides[0]) < 0) ||
                (Double.Parse(sides[1]) < 0) ||
                (Double.Parse(sides[2]) < 0))
            {
                throw new Exception(NEGATIVE);
            }
        }

        public void CheckTriangleInequality()
        {
            if (!(((Double.Parse(sides[0]) + Double.Parse(sides[1])) >= Double.Parse(sides[2])) &&
                  ((Double.Parse(sides[1]) + Double.Parse(sides[2])) >= Double.Parse(sides[0])) &&
                  ((Double.Parse(sides[0]) + Double.Parse(sides[2])) >= Double.Parse(sides[1]))))
            {
                throw new Exception(TRIANGLE_INEQUALITY);
            }
        }
    }
}
