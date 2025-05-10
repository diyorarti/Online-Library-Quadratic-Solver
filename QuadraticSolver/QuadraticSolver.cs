using System;

namespace QuadraticSolver
{
    public class EquationSolver
    {
        public static string Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return "No real roots";
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return $"One real root: {root}";
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return $"Two real roots: {root1}, {root2}";
            }
        }
    }
}
