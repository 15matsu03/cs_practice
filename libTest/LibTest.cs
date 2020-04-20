using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsTddSample;

namespace Test
{

    [TestClass]
    public class LibTest
    {

        [TestMethod]
        // 正三角形を受け取ると1を返すテスト
        public void TestEquilateralTriangle()
        {
            int result = new Triangle(1, 1, 1).GetTriangleKind();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        // 二等辺三角形を受け取ると2を返すテスト
        public void TestIsoscelesTriangle1()
        {
            int result = new Triangle(6, 6, 3).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // 二等辺三角形を受け取ると2を返すテスト
        public void TestIsoscelesTriangle2()
        {
            int result = new Triangle(6, 3, 6).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // 二等辺三角形を受け取ると2を返すテスト
        public void TestIsoscelesTriangle3()
        {
            int result = new Triangle(3, 6, 6).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // 不等辺三角形を受け取ると3を返すテスト
        public void TestNormalTriangle()
        {
            int result = new Triangle(2, 3, 4).GetTriangleKind();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計に等しい場合、三角形ではない（直線である）ため例外を返すテスト。
        public void TestLinear1()
        {
            new Triangle(1, 1, 2).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計に等しい場合、三角形ではない（直線である）ため例外を投げるテスト。
        public void TestLinear2()
        {
            new Triangle(1, 2, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計に等しい場合、三角形ではない（直線である）ため例外を投げるテスト。
        public void TestLinear3()
        {
            new Triangle(2, 1, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計より大きい場合、三角形ではないため例外を投げるテスト。
        public void TestNotLinkedTriangle1()
        {
            new Triangle(1, 4, 9).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計より大きい場合、三角形ではないため例外を投げるテスト。
        public void TestNotLinkedTriangle2()
        {
            new Triangle(4, 9, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // 最長辺の長さが他の二辺の合計より大きい場合、三角形ではないため例外を投げるテスト。
        public void TestNotLinkedTriangle3()
        {
            new Triangle(9, 4, 1).GetTriangleKind();
        }
    }
}
