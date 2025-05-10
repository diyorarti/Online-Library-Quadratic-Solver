using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class EquationSolverTests
    {
        [Fact]
        public void NoRealRootsTest()
        {
            var result = EquationSolver.Solve(1, 2, 5);
            Assert.Equal("No real roots", result);
        }

        [Fact]
        public void OneRealRootTest()
        {
            var result = EquationSolver.Solve(1, 2, 1);
            Assert.Contains("One real root", result);
        }

        [Fact]
        public void TwoRealRootsTest()
        {
            var result = EquationSolver.Solve(1, -3, 2);
            Assert.Contains("Two real roots", result);
        }

        [Theory]
        [InlineData(1, 0, -1, "Two real roots")]
        [InlineData(1, -2, 1, "One real root")]
        [InlineData(2, 1, 5, "No real roots")]
        public void MultipleCases(double a, double b, double c, string expected)
        {
            var result = EquationSolver.Solve(a, b, c);
            Assert.Contains(expected, result);
        }
    }
}
