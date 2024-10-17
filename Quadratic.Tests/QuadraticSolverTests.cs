using QuadraticEquationSolver;

namespace Quadratic.Tests
{
    public class QuadraticSolverTests
    {
        private readonly QuadraticSolver _solver = new QuadraticSolver();

        [Fact]
        public void Test_NoRoots()
        {
            double[] result = _solver.Solve(1, 0, 1);
            Assert.Empty(result);
        }

        [Fact]
        public void Test_TwoRoots()
        {
            double[] result = _solver.Solve(1, 0, -1);
            Assert.Equal(new double[] { 1, -1 }, result);
        }

        [Fact]
        public void Test_OneRoot()
        {
            double[] result = _solver.Solve(1, 2, 1);
            Assert.Equal(new double[] { -1 }, result);
        }

        [Fact]
        public void Test_CoefficientA_IsZero()
        {
            Assert.Throws<ArgumentException>(() => _solver.Solve(0, 1, 1));
        }

        [Fact]
        public void Test_InvalidCoefficients()
        {
            Assert.Throws<ArgumentException>(() => _solver.Solve(double.NaN, 1, 1));
            Assert.Throws<ArgumentException>(() => _solver.Solve(1, double.NaN, 1));
            Assert.Throws<ArgumentException>(() => _solver.Solve(1, 1, double.NaN));
            Assert.Throws<ArgumentException>(() => _solver.Solve(double.PositiveInfinity, 1, 1));
            Assert.Throws<ArgumentException>(() => _solver.Solve(1, double.PositiveInfinity, 1));
            Assert.Throws<ArgumentException>(() => _solver.Solve(1, 1, double.PositiveInfinity));
        }
    }
}