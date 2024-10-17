namespace QuadraticEquationSolver
{
    public class QuadraticSolver
    {
        public double[] Solve(double a, double b, double c)
        {
            if (Math.Abs(a) < double.Epsilon)
                throw new ArgumentException("Coefficient 'a' cannot be zero.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }
    }
}