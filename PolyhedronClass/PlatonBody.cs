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
    }
}
