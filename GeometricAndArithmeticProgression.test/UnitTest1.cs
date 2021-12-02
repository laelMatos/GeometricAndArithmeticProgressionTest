using System;
using Xunit;

namespace GeometricAndArithmeticProgression.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12 })]
        [InlineData(new int[] { 2, 4, 4, 8, 7, 12 })]
        public void ArithmeticTest(int[] arr)
        {
            Assert.True(Progression.IsArithmetic(arr));
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12 })]
        [InlineData(new int[] { 2, 4, 4, 8, 7, 12 })]
        public void ArithmeticTestFast(int[] arr)
        {
            Assert.True(Progression.IsArithmeticFast(arr));
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 8, 16 })]
        [InlineData(new int[] { 2, 4, 5, 16 })]
        public void GeometricTest(int[] arr)
        {
            Assert.True(Progression.IsGeometric(arr));
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 8, 16 })]
        [InlineData(new int[] { 2, 4, 5, 16 })]
        public void GeometricTestFast(int[] arr)
        {
            Assert.True(Progression.IsGeometricFast(arr));
        }
    }
}
