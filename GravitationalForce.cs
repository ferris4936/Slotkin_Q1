//Programmer: Erica Slotkin

//Filename: GravitationalForce

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_Q1
{
    class GravitationalForce
    {
        public const double G = 0.0000000000667408;
        public double F { get; private set; } //gravitational force in newton
        public double M1 { get; set; } //mass of object 1 in kilograms
        public double M2 { get; set; } //mass of object 2 in kilograms
        public double R { get; set; } //distance between M1 and M2 in meters 

        public GravitationalForce()
        {

        }

        public GravitationalForce(double mass1, double mass2, double distance)
        {
            this.M1 = mass1;
            this.M2 = mass2;
            this.R = distance;
        }

        public double CalcGravForce()
        {
            this.F = G*(M1 * M2 / R * R);  
            return F; 
        }
    }
}
