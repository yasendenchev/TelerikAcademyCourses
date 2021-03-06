﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        static readonly Point3D pointO = new Point3D(0, 0, 0);

        //constructor

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //properties
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }


        //methods
        public override string ToString()
        {
            return string.Format($"({this.X}, {this.Y}, {this.Z})");
        }
    }
}
