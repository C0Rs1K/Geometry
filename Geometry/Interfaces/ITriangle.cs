using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Interfaces
{
    public interface ITriangle : IShape
    {
        public double SideOne { get; }
        public double SideTwo { get; }
        public double SideThree { get; }
        public bool IsRightTriangle();
    }
}
