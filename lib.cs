using System;

namespace CsTddSample {
    public class Triangle {

        private TriangleKind kind;

        /**
         * コンストラクタ。
         */
        public Triangle (int sideA, int sideB, int sideC)
        {
            kind = CheckTriangleKind(sideA, sideB, sideC);
        }

        /**
         * 与えられた3つの値から、成立する三角形の種類を返す。
         */
        private TriangleKind CheckTriangleKind(int sideA, int sideB, int sideC)
        {
            // 三角形として成立しない場合はNoSuchTriangleExceptionを投げる
            if (!IsTriangle(sideA, sideB, sideC))
            {
                throw new NoSuchTriangleException();
            }
            if (sideA == sideB && sideB == sideC)
            {
                // 正三角形を返す
                return TriangleKind.EquilatetalTriangle;
            }
            if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                // 二等辺三角形を返す
                return TriangleKind.IsoscelesTriangle;
            }
            // すでに三角形として成立していることが確認できているため、不等辺三角形を返す
            return TriangleKind.NormalTriangle;
        }

        /**
         * 与えられた3つの値が三角形の条件を満たすかを確認する。
         */
        private bool IsTriangle(int sideA, int sideB, int sideC)
        {
            // 三角形が成立するには、どの二辺の長さの和も残り一辺の長さより大きくなくてはならない
            // なお、これが成立する場合常に三辺全ての長さが正の値となる
            return sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB;
        }

        /**
         * 三角形の種類に応じた値を返す。
         */
        public int GetTriangleKind() {
            return (int)kind;
        }
    }

    /**
     * 三角形の種類を保持する列挙体。
     */
    public enum TriangleKind
    {
        // 正三角形
        EquilatetalTriangle = 1,
        // 二等辺三角形
        IsoscelesTriangle = 2,
        // 不等辺三角形（ここでは一般的な三角形としている）
        NormalTriangle = 3
    }

    /**
     * 三角形として成立しないパターンの場合に投げられる例外。
     */
    public class NoSuchTriangleException : Exception
    {

    }

}