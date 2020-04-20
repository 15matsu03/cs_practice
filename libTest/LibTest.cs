using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsTddSample;

namespace Test
{

    [TestClass]
    public class LibTest
    {

        [TestMethod]
        // ���O�p�`���󂯎���1��Ԃ��e�X�g
        public void TestEquilateralTriangle()
        {
            int result = new Triangle(1, 1, 1).GetTriangleKind();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        // �񓙕ӎO�p�`���󂯎���2��Ԃ��e�X�g
        public void TestIsoscelesTriangle1()
        {
            int result = new Triangle(6, 6, 3).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // �񓙕ӎO�p�`���󂯎���2��Ԃ��e�X�g
        public void TestIsoscelesTriangle2()
        {
            int result = new Triangle(6, 3, 6).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // �񓙕ӎO�p�`���󂯎���2��Ԃ��e�X�g
        public void TestIsoscelesTriangle3()
        {
            int result = new Triangle(3, 6, 6).GetTriangleKind();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        // �s���ӎO�p�`���󂯎���3��Ԃ��e�X�g
        public void TestNormalTriangle()
        {
            int result = new Triangle(2, 3, 4).GetTriangleKind();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v�ɓ������ꍇ�A�O�p�`�ł͂Ȃ��i�����ł���j���ߗ�O��Ԃ��e�X�g�B
        public void TestLinear1()
        {
            new Triangle(1, 1, 2).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v�ɓ������ꍇ�A�O�p�`�ł͂Ȃ��i�����ł���j���ߗ�O�𓊂���e�X�g�B
        public void TestLinear2()
        {
            new Triangle(1, 2, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v�ɓ������ꍇ�A�O�p�`�ł͂Ȃ��i�����ł���j���ߗ�O�𓊂���e�X�g�B
        public void TestLinear3()
        {
            new Triangle(2, 1, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v���傫���ꍇ�A�O�p�`�ł͂Ȃ����ߗ�O�𓊂���e�X�g�B
        public void TestNotLinkedTriangle1()
        {
            new Triangle(1, 4, 9).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v���傫���ꍇ�A�O�p�`�ł͂Ȃ����ߗ�O�𓊂���e�X�g�B
        public void TestNotLinkedTriangle2()
        {
            new Triangle(4, 9, 1).GetTriangleKind();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchTriangleException))]
        // �Œ��ӂ̒��������̓�ӂ̍��v���傫���ꍇ�A�O�p�`�ł͂Ȃ����ߗ�O�𓊂���e�X�g�B
        public void TestNotLinkedTriangle3()
        {
            new Triangle(9, 4, 1).GetTriangleKind();
        }
    }
}
