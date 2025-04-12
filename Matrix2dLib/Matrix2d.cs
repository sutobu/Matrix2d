#nullable disable

namespace Matrix2dLib
{
    //immutable class
    public class Matrix2D : IEquatable<Matrix2D>
    {
        private readonly int a, b, c, d; //private fields
        /*
         -----
         |a  b|
         |c  d|
         -----
         */

        //konstruktor
        public Matrix2D(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /* public Matrix2D()
        {
            a = 1;
            b = 0;
            c = 0;
            d = 1;
        } */
        public Matrix2D() : this(1, 0, 0, 1) { }

        public Matrix2D Id => new Matrix2D(1, 0, 0, 1); //property typu get
        public Matrix2D Zero => new Matrix2D(0, 0, 0, 0);

        public override string ToString() => $"[[{a}, {b}],[{c}, {d}]]";
        public bool Equals(Matrix2D other)
        {
            if (other is null) return false;
            return a == other.a &&
                   b == other.b &&
                   c == other.c &&
                   d == other.d;

        }

        public static bool operator ==(Matrix2D left, Matrix2D right)
        {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Matrix2D left, Matrix2D right)
        {
            return !(left == right);
        }

        //dodawanie

        public static Matrix2D operator +(Matrix2D left, Matrix2D right)
            => new Matrix2D(left.a + right.a, left.b + right.b,
                            left.c + right.c, left.d + right.d);

        //odejmowanie
        public static Matrix2D operator -(Matrix2D left, Matrix2D right)
            => new Matrix2D(left.a - right.a, left.b - right.b,
                            left.c - right.c, left.d - right.d);

        //mnozenie
        public static Matrix2D operator *(Matrix2D left, Matrix2D right)
            => new Matrix2D(
                left.a * right.a + left.b * right.c,
                left.a * right.b + left.b * right.d,
                left.c * right.a + left.d * right.c,
                left.c * right.b + left.d * right.d
            );
        //mnozenie przez skalar
        public static Matrix2D operator *(Matrix2D left, int right)
            => new Matrix2D(left.a * right, left.b * right,
                            left.c * right, left.d * right);

        // scalar * macierz
        public static Matrix2D operator *(int left, Matrix2D right)
            => right * left;

        //(-1) * A
        public static Matrix2D operator -(Matrix2D left)
            => new Matrix2D(-left.a, -left.b, -left.c, -left.d);

        // transponowanie
        public Matrix2D Transpose()
            => new Matrix2D(a, c, b, d);

        //wyznacznik jako metoda klasy
        public static int Determinant(Matrix2D m)
            => m.a * m.d - m.b * m.c;

        //wyznacznik jako metoda instancji
        public int Det() => Determinant(this);


    }
}
