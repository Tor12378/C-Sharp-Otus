using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Otus
{
    public class Matrix
    {
        readonly double a,b,c,d;
        public Matrix(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string? ToString()
        {
            return $"{a} {b} \n{c} {d}\n";
        }
        public static Matrix operator + (Matrix m1,Matrix m2)
        {
            return new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.a * m2.a+ m1.b * m2.c, m1.a * m2.b + m1.b * m2.d, m1.c * m2.a + m1.d * m2.c, m1.c * m2.b + m1.d * m2.d);
        }
        public static Matrix operator *(Matrix m1, int a)
        {
            return new Matrix(m1.a*a,m1.b*a,m1.c*a,m1.d*a);
        }
        public static Matrix operator *(int a,Matrix m1)
        {
            return new Matrix(m1.a * a, m1.b * a, m1.c * a, m1.d * a);
        }
        public static Matrix operator -( Matrix m1)
        {
            return new Matrix(m1.a * -1, m1.b * -1, m1.c * -1, m1.d * -1);
        }
        public static double Opr(Matrix m1)
        {
            return m1.a * m1.d - m1.b * m1.c;
        }
    }
}
