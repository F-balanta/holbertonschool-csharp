using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}
        [Test]
        public void PositiveMatrix()
        {
            var Matrix = new int[,]{
                                    {12,8,4},
                                    {22,10,2},
                                    {14,16,6}};
            var MC = new int[,]{
                                {6,4,2},
                                {11,5,1},
                                {7,8,3}};
            var result = MyMath.Matrix.Divide(Matrix, 2);
            CollectionAssert.AreEqual(MC, result);
        }
        [Test]
        public void MatrixDividedZero()
        {
            var Matrix = new int[,]{
                                    {12,8,4},
                                    {22,10,2},
                                    {14,16,6}};
            var result = MyMath.Matrix.Divide(Matrix, 0);
            Assert.IsNull(result);
        }
        [Test]
        public void NegaticeMatrix1()
        {
            var Matrix = new int[,]{
                                    {12,8,4},
                                    {-22,-10,2},
                                    {-14,-4,8}};
            var MC = new int[,]{
                                { 6,4,2},
                                {-11,-5,1},
                                {-7,-2,4}};
            var result = MyMath.Matrix.Divide(Matrix, 2);
            CollectionAssert.AreEqual(MC, result);
        }
        [Test]
        public void MatrixNull()
        {
            int[,] Matrix = { };
            var result = MyMath.Matrix.Divide(Matrix,2);
            Assert.IsNull (result);
        }

    }
}