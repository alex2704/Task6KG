﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyhedronClass
{
    public class Body
    {
        #region // const
        int[,] HexaedrIndex =
        {   {3,2,1,0},
            {4,5,6,7},
            {5,1,2,6},
            {6,2,3,7},
            {3,0,4,7},
            {0,1,5,4} };
        int[,] OctaedrIndex =
        {   {4,1,0},
            {4,2,1},
            {4,3,2},
            {4,0,3},
            {5,0,1},
            {5,1,2},
            {5,2,3},
            {5,3,0} };
        static double IcoX = 0.525731112119133606;
        static double IcoZ = 0.850650808352039932;
        double[,] IcoData =
        {   {-IcoX,     0,  IcoZ},
            { IcoX,     0,  IcoZ},
            {-IcoX,     0, -IcoZ},
            { IcoX,     0, -IcoZ},
            {    0,  IcoZ,  IcoX},
            {    0,  IcoZ, -IcoX},
            {    0, -IcoZ,  IcoX},
            {    0, -IcoZ, -IcoX},
            { IcoZ,  IcoX,     0},
            {-IcoZ,  IcoX,     0},
            { IcoZ, -IcoX,     0},
            {-IcoZ, -IcoX,     0} };

        int[,] IcoIndex =
        {   { 0,  4,  1},
            { 0,  9,  4},
            { 9,  5,  4},
            { 4,  5,  8},
            { 4,  8,  1},
            { 8, 10,  1},
            { 8,  3, 10},
            { 5,  3,  8},
            { 5,  2,  3},
            { 2,  7,  3},
            { 7, 10,  3},
            { 7,  6, 10},
            { 7, 11,  6},
            {11,  0,  6},
            { 0,  1,  6},
            { 6,  1, 10},
            { 9,  0, 11},
            { 9, 11,  2},
            { 9,  2,  5},
            { 7,  2, 11} };
        int[,] DodecIndex =
        {   { 0,  1,  9, 16,  5},
            { 1,  0,  3, 18,  7},
            { 1,  7, 11, 10,  9},
            {11,  7, 18, 19,  6},
            { 8, 17, 16,  9, 10},
            { 2, 14, 15,  6, 19},
            { 2, 13, 12,  4, 14},
            { 2, 19, 18,  3, 13},
            { 3,  0,  5, 12, 13},
            { 6, 15,  8, 10, 11},
            { 4, 17,  8, 15, 14},
            { 4, 12,  5, 16, 17} };
        #endregion
        public double SizeBody { get; set; } = 0.3;
        public double[][] Vertexs { get; set; } //массив вершин всех тел
        public double[][] VertexsT { get; set; } //массив вершин всех тел
        public Edge[] Edges; //массив ребер всех тел
        public Face[] Faces; //массив граней всех тел
        double[,] dodec = new double[20, 3];
        public Body(byte fl)
        {
            switch (fl)
            {
                case 0:
                    Tetraedr(SizeBody);
                    break;
                case 1:
                    Hexaedr(SizeBody);
                    break;
                case 2:
                    Octaedr(SizeBody);
                    break;
                case 3:
                    Icosahedron(SizeBody);
                    break;
                case 4:
                    Dodecahedron(SizeBody);
                    break;
            }
        }
        Edge[] GetEdges(Face[] Sides) // по граням строит ребра
        {
            Edge[] Result = new Edge[0];
            int Ls = Sides.Length;
            int Le = 0;
            for (int i = 0; i < Ls; i++)
            {
                int L = Sides[i].p.Length;
                for (int j = 0; j < L; j++)
                {
                    bool Ok = false; int k = -1;
                    while ((k < Le - 1) && !Ok)
                    {
                        k++;
                        Ok = ((Result[k].p1 == Sides[i].p[j]) &
                              (Result[k].p2 == Sides[i].p[(j + 1) % L])) |
                             ((Result[k].p2 == Sides[i].p[j]) &
                              (Result[k].p1 == Sides[i].p[(j + 1) % L]));
                    }
                    if (!Ok)
                    {
                        Array.Resize<Edge>(ref Result, ++Le);
                        Result[Le - 1].p1 = Sides[i].p[j];
                        Result[Le - 1].p2 = Sides[i].p[(j + 1) % L];
                    }
                }
            }
            return Result;
        }
        private void Octaedr(double Size)
        {
            Vertexs = new double[6][];
            VertexsT = new double[6][];
            for(int i = 0; i < 6; i++)
            {
                Vertexs[i] = new double[4];
                VertexsT[i] = new double[4];
            }
            Vertexs[0][0] = 0; Vertexs[0][1] = Size; Vertexs[0][2] = 0;
            Vertexs[1][0] = Size; Vertexs[1][1] = 0; Vertexs[1][2] = 0;
            Vertexs[2][0] = 0; Vertexs[2][1] = -Size; Vertexs[2][2] = 0;
            Vertexs[3][0] = -Size; Vertexs[3][1] = 0; Vertexs[3][2] = 0;
            Vertexs[4][0] = 0; Vertexs[4][1] = 0; Vertexs[4][2] = Size;
            Vertexs[5][0] = 0; Vertexs[5][1] = 0; Vertexs[5][2] = -Size;
            for (int i = 0; i < 6; i++)
                Vertexs[i][3] = 1;
            Faces = new Face[8];
            for(int i = 0; i < 8; i++)
            {
                Faces[i].p = new int[3];
                for (int j = 0; j < 3; j++)
                    Faces[i].p[j] = OctaedrIndex[i, j];
            }
            Edges = GetEdges(Faces);
        }
        private void Icosahedron(double Size)
        {
            Vertexs = new double[12][];
            VertexsT = new double[12][];
            for (int i = 0; i < 12; i++)
            {
                Vertexs[i] = new double[4];
                VertexsT[i] = new double[4];
            }
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 3; j++)
                    Vertexs[i][j] = Size * IcoData[i, j];

            for (int i = 0; i < 12; i++)
                Vertexs[i][3] = 1;

            Faces = new Face[20];
            for (int i = 0; i < 20; i++)
            {
                Faces[i].p = new int[3];
                for (int j = 0; j < 3; j++)
                    Faces[i].p[j] = IcoIndex[i, j];
            }
            Edges = GetEdges(Faces);
        }
    }
}
