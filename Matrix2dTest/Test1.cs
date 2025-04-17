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
        public void Test_Equals_Operator()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 2, 3, 4);
            Assert.IsTrue(m1 == m2);
        }

        [TestMethod]
        public void Test_NotEquals_Operator()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(1, 2, 3, 5);
            Assert.IsTrue(m1 != m2);
        }

        [TestMethod]
        public void Test_Equals_Null()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            Matrix2D m2 = null;
            Assert.IsFalse(m1.Equals(m2));
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
        public void TestMatrixMultiplication()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var m2 = new Matrix2D(5, 6, 7, 8);
            var result = m1 * m2;
            Assert.AreEqual("[[2, 4], [6, 8]]", result.ToString());
        }

        [TestMethod]
        public void Test_Multiply_Number_Left_Operator()
        {
            var m1 = new Matrix2D(1, 2, 3, 4);
            var x = 2;
            var m3 = m1 * x;
            Assert.AreEqual("[[2, 4], [6, 8]]", m3.ToString());
        }

        public void Test_Multiply_Number_Right_Operator()
        {
            var x = 2;
            var m2 = new Matrix2D(1, 2, 3, 4);
            var m3 = x * m2;
            Assert.AreEqual("[[2, 4], [6, 8]]", m3.ToString());
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
        public void Test_Static_Determinant()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            var m1 = Matrix2D.Determinant(m);
            Assert.AreEqual(-2, m1);
        }

        [TestMethod]
        public void Test_Det()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.AreEqual(-2, m.Det());
        }

        [TestMethod]
        public void TestParse()
        {
            string input = "[1, 2, 3, 4]";
            var m = Matrix2D.Parse(input);
            Assert.AreEqual("[[1, 2], [3, 4]]", m.ToString());
        }

        [TestMethod]
        public void Test_Parse_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Matrix2D.Parse("[1, 2], [3]"));
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
