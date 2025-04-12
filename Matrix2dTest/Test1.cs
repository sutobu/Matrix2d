using Matrix2dLib;


namespace Matrix2dTest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            var m = new Matrix2D();
            Assert.AreEqual("[[1, 0], [0, 1]]", m.ToString());
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.AreEqual("[[1, 2], [3, 4]]", m.ToString());
        }

        [TestMethod]
        public void TestMatrixAddition()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(5, 6, 7, 8);
            var result = m1 + m2;
            Assert.AreEqual("[[6, 8], [10, 12]]", result.ToString());
        }

        [TestMethod]
        public void TestMatrixScalarMultiplication()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            var result = m * 2;
            Assert.AreEqual("[[2, 4], [6, 8]]", result.ToString());
        }

        [TestMethod]
        public void TestMatrixNegation()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            var result = -m;

            Assert.AreEqual("[[-1, -2], [-3, -4]]", result.ToString());
        }

        [TestMethod]
        public void TestMatrixEquality()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 2, 3, 4);
            var m3 = new Matrix2D(5, 6, 7, 8);

            Assert.IsTrue(m1 == m2);
            Assert.IsFalse(m1 == m3);
        }

        [TestMethod]
        public void TestMatrixDeterminant()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            var det = m.Det();
            Assert.AreEqual(-2, det);
        }

        [TestMethod]
        public void TestParse()
        {
            string input = "[1, 2, 3, 4]";
            var m = Matrix2D.Parse(input);
            Assert.AreEqual("[[1, 2], [3, 4]]", m.ToString());
        }

        [TestMethod]
        public void TestMatrixTranspose()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            var result = m.Transpose();
            Assert.AreEqual("[[1, 3], [2, 4]]", result.ToString());
        }
    }
}
