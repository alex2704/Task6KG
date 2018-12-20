using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public static bool t = false;

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
            bitmap = new Bitmap(VW, VH);
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
            for (int j = 0; j < 4; j++)
            {
                result[j] = A[0] * B[0][j];
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
        private int II(double x)
        {
            return (int)Math.Round((x - Xmin) * I2 / (Xmax - Xmin));
        }

        private int JJ(double y)
        {
            return (int)Math.Round((y - Ymax) * J2 / (Ymin - Ymax));
        }

        private double XX(int I)
        {
            return Xmin + (Xmax - Xmin) * I / I2;
        }

        private double YY(int J)
        {
            return Ymax + (Ymin - Ymax) * J / J2;
        }
        private Point IJ(double[] Vt)
        {
            Point result;
            Vt = Rotate(Vt, 0, Alf, 0, 0);
            Vt = Rotate(Vt, 1, Bet, 0, 0);
            result = new Point(II(Vt[0]), JJ(Vt[1]));
            return result;
        }

        private double[] Norm(double[] V1, double[] V2, double[] V3)
        {
            double[] Result = new double[4];
            double[] A = new double[4];
            double[] B = new double[4];
            A[0] = V2[0] - V1[0]; A[1] = V2[1] - V1[1]; A[2] = V2[2] - V1[2];
            B[0] = V3[0] - V1[0]; B[1] = V3[1] - V1[1]; B[2] = V3[2] - V1[2];
            double u = A[1] * B[2] - A[2] * B[1];
            double v = -A[0] * B[2] + A[2] * B[0];
            double w = A[0] * B[1] - A[1] * B[0];

            double d = Math.Sqrt(u * u + v * v + w * w);
            if (d != 0)
            {
                Result[0] = u / d;
                Result[1] = v / d;
                Result[2] = w / d;
            }
            else
            {
                Result[0] = 0;
                Result[1] = 0;
                Result[2] = 0;
            }
            return Result;
        }

        private void OXYZ(Graphics g)
        {
            Point P0, P1;
            P0 = IJ(ToVector(-3, 0, 0));
            P1 = IJ(ToVector(3, 0, 0));
            g.DrawLine(Pens.Silver, P0.X, P0.Y, P1.X, P1.Y);
            g.DrawString("X", myFont, Brushes.Black, P1);
            P0 = IJ(ToVector(0, -3, 0));
            P1 = IJ(ToVector(0, 3, 0));
            g.DrawLine(Pens.Silver, P0.X, P0.Y, P1.X, P1.Y);
            g.DrawString("Y", myFont, Brushes.Black, P1);
            P0 = IJ(ToVector(0, 0, -3));
            P1 = IJ(ToVector(0, 0, 3));
            g.DrawLine(Pens.Silver, P0.X, P0.Y, P1.X, P1.Y);
            g.DrawString("Z", myFont, Brushes.Black, P1);
        }
        private void DrawEdge(Graphics g)
        {
            int L = body.Edges.Length;
            for (int i = 0; i < L; i++)
            {
                int x1 = II(body.VertexsT[body.Edges[i].p1][0]);
                int y1 = JJ(body.VertexsT[body.Edges[i].p1][1]);
                int x2 = II(body.VertexsT[body.Edges[i].p2][0]);
                int y2 = JJ(body.VertexsT[body.Edges[i].p2][1]);
                g.DrawLine(Pens.Black, x1, y1, x2, y2);
            }
        }

        private void DrawFaces(Graphics g)
        {
            int L1 = body.Faces.Length;
            int L0 = body.Faces[0].p.Length;
            Point[] w = new Point[L0];

            double[][] Vn = new double[3][];
            double[][] Wn = new double[3][];
            for (int i = 0; i < L1; i++)
            {
                for (int j = 0; j < L0; j++)
                {
                    double[] Vt = body.Vertexs[body.Faces[i].p[j]];
                    Vt = Rotate(Vt, 0, Alf1, 0, 0);
                    Vt = Rotate(Vt, 1, Bet1, 0, 0);
                    if (j <= 2) Vn[j] = Vt;
                    Vt = Rotate(Vt, 3, 0, Xs, Zs);
                    Vt = Rotate(Vt, 0, Alf, 0, 0);
                    Vt = Rotate(Vt, 1, Bet, 0, 0);
                    w[j].X = II(Vt[0]);
                    w[j].Y = JJ(Vt[1]);
                    if (j <= 2) Wn[j] = Vt;
                }
                body.Faces[i].N = Norm(Vn[0], Vn[1], Vn[2]);
                double[] NN = Norm(Wn[0], Wn[1], Wn[2]);
                double d = Math.Abs(NN[2]);
                Color col = Color.FromArgb(25, (byte)(Math.Round(255 * d)), 38);
                SolidBrush br = new SolidBrush(col);
                if (NN[2] < 0)
                    g.FillPolygon(br, w);
            }
        }

        private void DrawStereo(Graphics g)
        {
            Color c = Color.FromArgb(191, 32, 32, 1);
            Color cB = Color.FromArgb(211,226,38,1);
            Pen myPenR = new Pen(c, 1);
            Pen myPenB = new Pen(cB, 1);
            int L = body.Edges.Length;

            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            for (int i = 0; i < L; i++)
            {
                Edge e = body.Edges[i];
                double[] V1 = Rotate(body.VertexsT[e.p1], 1, AnglStereo, 0, 0);
                double[] V2 = Rotate(body.VertexsT[e.p2], 1, AnglStereo, 0, 0);
                g.DrawLine(myPenR, II(V1[0]), JJ(V1[1]), II(V2[0]), JJ(V2[1]));

                V1 = Rotate(body.VertexsT[e.p1], 1, -AnglStereo, 0, 0);
                V2 = Rotate(body.VertexsT[e.p2], 1, -AnglStereo, 0, 0);
                g.DrawLine(myPenB, II(V1[0]), JJ(V1[1]), II(V2[0]), JJ(V2[1]));
            }

            Font f = new Font("Courier", 12);
            SolidBrush br = new SolidBrush(myPenR.Color);
            SolidBrush bB = new SolidBrush(myPenB.Color);
            L = body.VertexsT.Length;
            for (int i = 0; i < L; i++)
            {
                double[] V1 = Rotate(body.VertexsT[i], 1, AnglStereo, 0, 0);
                g.DrawString(i.ToString(), f, br, II(V1[0]), JJ(V1[1]));
                V1 = Rotate(body.VertexsT[i], 1, -AnglStereo, 0, 0);
                g.DrawString(i.ToString(), f, bB, II(V1[0]), JJ(V1[1]));
            }
            f.Dispose();
        }
        public void DrawBody(Graphics g)
        {
            int L;
            if ((flEdge == 0) | (flEdge == 2))
            {
                L = body.Vertexs.Length;
                for (int i = 0; i < L; i++)
                {
                    body.VertexsT[i] = Rotate(body.Vertexs[i], 0, Alf1, 0, 0);
                    body.VertexsT[i] = Rotate(body.VertexsT[i], 1, Bet1, 0, 0);
                    body.VertexsT[i] = Rotate(body.VertexsT[i], 3, 0, Xs, Zs);
                    body.VertexsT[i] = Rotate(body.VertexsT[i], 0, Alf, 0, 0);
                    body.VertexsT[i] = Rotate(body.VertexsT[i], 1, Bet, 0, 0);
                }
            }
            switch (flEdge)
            {
                case 0:  // Edges
                    DrawEdge(g);
                    break;
                case 1:  // faces
                    DrawFaces(g);
                    break;
                case 2: // stereo
                    DrawStereo(g);
                    break;
            }
        }
        public void Draw()
        {
            I2 = bitmap.Width;
            J2 = bitmap.Height;
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Color c1;
                if (flEdge == 2)
                    c1 = Color.FromArgb(0, 0, 0);
                else
                    c1 = Color.FromArgb(255, 255, 255);
                g.Clear(c1);
                g.SmoothingMode = SmoothingMode.HighQuality;
                if (visibleOXYZ)
                    OXYZ(g);
                if (visiblePoint)
                    DrawPerspective(g);
                DrawBody(g);
            }
        }
        public void ChangeWindowXY(int u, int v, int Delta)
        {
            double coeff;
            double x = XX(u);
            double y = YY(v);
            if (Delta < 0)
                coeff = 1.03;
            else
                coeff = 0.97;
            Xmin = x - (x - Xmin) * coeff;
            Xmax = x + (Xmax - x) * coeff;
            Ymin = y - (y - Ymin) * coeff;
            Ymax = y + (Ymax - y) * coeff;
        }
        //Вращение вокруг векторов
        public void SetAngle(double x, double y, int rotateVec, bool flRotate)
        {
            if (flRotate)
            {
                switch (rotateVec)
                {
                    case 0:
                        Alf = Math.Atan2(y, x);
                        Bet = Math.Sqrt((x / 10) * (x / 10) + (y / 10) * (y / 10));
                        break;
                    case 1:
                        Alf1 = Math.Atan2(x, y);
                        Bet1 = Math.Sqrt((x / 10) * (x / 10) + (y / 10) * (y / 10));
                        break;
                    case 2:
                        Alf = Math.Atan2(y, x);
                        Bet = Math.Sqrt((x / 10) * (x / 10) + (y / 10) * (y / 10));
                        break;
                }
            }
            else
            {
                Alf1 = Math.Atan2(y, x);
                Bet1 = Math.Sqrt((x / 10) * (x / 10) + (y / 10) * (y / 10));
            }
        }
        private void DrawPerspective(Graphics g)//перспектива
        {
            Pen myPen = new Pen(Color.Gray);
            myPen.DashStyle = DashStyle.Dash;
            int L = body0.Vertexs.Length;
            for (int i = 0; i < L; i++)
            {
                body0.VertexsT[i] = Rotate(body0.Vertexs[i], 3, 0, Xs, Zs);
                body0.VertexsT[i] = Rotate(body0.VertexsT[i], 0, Alf, 0, 0);
                body0.VertexsT[i] = Rotate(body0.VertexsT[i], 1, Bet, 0, 0);
            }
            int L0 = body0.Edges.Length;
            for (int i = 0; i < L0; i++)
            {
                int x1 = II(body0.VertexsT[body0.Edges[i].p1][0]);
                int y1 = JJ(body0.VertexsT[body0.Edges[i].p1][1]);
                int x2 = II(body0.VertexsT[body0.Edges[i].p2][0]);
                int y2 = JJ(body0.VertexsT[body0.Edges[i].p2][1]);
                g.DrawLine(myPen, x1, y1, x2, y2);
            }

            if (Xs != 0)
            {
                double[] V1 = new double[4];
                V1[1] = 1 / Xs; V1[0] = 0; V1[2] = 0; V1[3] = 1;
                V1 = Rotate(V1, 0, Alf, 0, 0);
                V1 = Rotate(V1, 1, Bet, 0, 0);
                int u = II(V1[0]); int v = JJ(V1[1]);
                for (int i = 0; i < 6; i++)
                    if ((i != 2) && (i != 3))
                        g.DrawLine(myPen, u, v,
                            II(body0.VertexsT[i][0]),
                            JJ(body0.VertexsT[i][1]));
                g.FillRectangle(Brushes.Black, u - 2, v - 2, 4, 4);
            }
            if (Zs != 0)
            {
                double[] V1 = new double[4];
                V1[1] = 0; V1[0] = 0; V1[2] = 1 / Zs; V1[3] = 1;
                V1 = Rotate(V1, 0, Alf, 0, 0);
                V1 = Rotate(V1, 1, Bet, 0, 0);
                int u = II(V1[0]); int v = JJ(V1[1]);
                for (int i = 0; i < 4; i++)
                    g.DrawLine(myPen, u, v,
                        II(body0.VertexsT[i][0]),
                        JJ(body0.VertexsT[i][1]));
                g.FillRectangle(Brushes.Black, u - 2, v - 2, 4, 4);
            }
        }
    }
}
