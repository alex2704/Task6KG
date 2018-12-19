using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyhedronClass
{
    public struct Face
    {
        public int[] p; //номера вершин
        public double[] N; //коэффициенты уравнения плоскости
    }
}
