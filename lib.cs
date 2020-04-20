using System;

namespace CsTddSample {
    public class Triangle {

        private TriangleKind kind;

        /**
         * �R���X�g���N�^�B
         */
        public Triangle (int sideA, int sideB, int sideC)
        {
            kind = CheckTriangleKind(sideA, sideB, sideC);
        }

        /**
         * �^����ꂽ3�̒l����A��������O�p�`�̎�ނ�Ԃ��B
         */
        private TriangleKind CheckTriangleKind(int sideA, int sideB, int sideC)
        {
            // �O�p�`�Ƃ��Đ������Ȃ��ꍇ��NoSuchTriangleException�𓊂���
            if (!IsTriangle(sideA, sideB, sideC))
            {
                throw new NoSuchTriangleException();
            }
            if (sideA == sideB && sideB == sideC)
            {
                // ���O�p�`��Ԃ�
                return TriangleKind.EquilatetalTriangle;
            }
            if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                // �񓙕ӎO�p�`��Ԃ�
                return TriangleKind.IsoscelesTriangle;
            }
            // ���łɎO�p�`�Ƃ��Đ������Ă��邱�Ƃ��m�F�ł��Ă��邽�߁A�s���ӎO�p�`��Ԃ�
            return TriangleKind.NormalTriangle;
        }

        /**
         * �^����ꂽ3�̒l���O�p�`�̏����𖞂��������m�F����B
         */
        private bool IsTriangle(int sideA, int sideB, int sideC)
        {
            // �O�p�`����������ɂ́A�ǂ̓�ӂ̒����̘a���c���ӂ̒������傫���Ȃ��Ă͂Ȃ�Ȃ�
            // �Ȃ��A���ꂪ��������ꍇ��ɎO�ӑS�Ă̒��������̒l�ƂȂ�
            return sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB;
        }

        /**
         * �O�p�`�̎�ނɉ������l��Ԃ��B
         */
        public int GetTriangleKind() {
            return (int)kind;
        }
    }

    /**
     * �O�p�`�̎�ނ�ێ�����񋓑́B
     */
    public enum TriangleKind
    {
        // ���O�p�`
        EquilatetalTriangle = 1,
        // �񓙕ӎO�p�`
        IsoscelesTriangle = 2,
        // �s���ӎO�p�`�i�����ł͈�ʓI�ȎO�p�`�Ƃ��Ă���j
        NormalTriangle = 3
    }

    /**
     * �O�p�`�Ƃ��Đ������Ȃ��p�^�[���̏ꍇ�ɓ��������O�B
     */
    public class NoSuchTriangleException : Exception
    {

    }

}