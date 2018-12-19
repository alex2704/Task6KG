using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyhedronClass
{
    public class PlatonBody
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public int I2 { get; set; }
        public int J2 { get; set; }
        public double Alf { get; set; }
        public double Alf1 { get; set; }
        public double Bet { get; set; }
        public double Bet1 { get; set; }
        public static double Xs { get; set; } = 0; //1-ая точка схода
        public static double Zs { get; set; } = 0; //2-ая точка схода
        public static bool visibleOXYZ = false;
        public static bool visiblePoint = false;
        public static bool flRotate = false;
        public static byte flEdge = 0;
        double AnglStereo = 0.010;

        public Bitmap bitmap;
        public SolidBrush myBrush;
        public Font myFont = new Font("Courier", 10);
        public static Body body;
        public static Body body0;
        public PlatonBody(int VW, int VH)
        {
            Xmin = -2;
            Xmax = 2;
            Ymin = -2;
            Ymax = 2;
            Alf = 4.31;
            Bet = 4.92;
            Alf1 = 0;
            Bet1 = 0;
            I2 = VW;
            J2 = VH;
            bitmap = new Bitmap(VW,VH);
            myBrush = new SolidBrush(Color.White);
            body = new Body(0);
            body0 = new Body(1);
        }
        private double[] ToVector(double x, double y, double z)
        {
            double[] result = new double[4];
            result[0] = x;
            result[1] = y;
            result[2] = z;
            result[3] = 1;
            return result;
        }
        private double[] VM_Mult(double[] A, double[][] B)
        {
            double[] result = new double[4];
            for(int j = 0; j < 4; j++)
            {
                result[j] = A[0] + B[0][j];
                for (int k = 1; k < 4; k++)
                    result[j] += A[k] * B[k][j];
            }
            if (result[3] != 0)
                for (int j = 0; j < 3; j++)
                    result[j] /= result[3];
            result[3] = 1;
            return result;
        }
        private double[] Rotate(double[] V, int k, double fi, double p, double r)
        {
            double[][] M = new double[4][];

            for (int i = 0; i < 4; i++)
                M[i] = new double[4];

            for (int i = 0; i < 4; i++)
            {
                M[3][i] = 0;
                M[i][3] = 0;
            }
            M[3][3] = 1;
            switch (k)
            {
                case 0: //матрица вращения вокруг оси X
                    M[0][0] = 1; M[0][1] = 0; M[0][2] = 0;
                    M[1][0] = 0; M[1][1] = Math.Cos(fi); M[1][2] = Math.Sin(fi);
                    M[2][0] = 0; M[2][1] = -Math.Sin(fi); M[2][2] = Math.Cos(fi);
                    break;
                case 1: //матрица вращения вокруг оси Y
                    M[0][0] = Math.Cos(fi); M[0][1] = 0; M[0][2] = -Math.Sin(fi);
                    M[1][0] = 0; M[1][1] = 1; M[1][2] = 0;
                    M[2][0] = Math.Sin(fi); M[2][1] = 0; M[2][2] = Math.Cos(fi);
                    break;
                case 2: //матрица вращения вокруг оси Z
                    M[0][0] = Math.Cos(fi); M[0][1] = Math.Sin(fi); M[0][2] = 0;
                    M[1][0] = -Math.Sin(fi); M[1][1] = Math.Cos(fi); M[1][2] = 0;
                    M[2][0] = 0; M[2][1] = 0; M[2][2] = 1;
                    break;
                case 3:
                    M[0][0] = 1; M[0][1] = 0; M[0][2] = 0;
                    M[1][0] = 0; M[1][1] = 1; M[1][2] = 0;
                    M[2][0] = 0; M[2][1] = 0; M[2][2] = 1;
                    M[1][3] = p; M[2][3] = r;
                    break;
            }
            return VM_Mult(V, M);
        }
    }
}
