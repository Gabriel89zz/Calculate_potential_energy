using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_potential_energy
{
    internal class PotentialEnergy
    {
        private double mass;

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public PotentialEnergy()
        {
            mass = 0;
            height = 0;
        }

        public double CalculatePotentialEnergy(PotentialEnergy ball)
        {
            double gravity = 9.8;
            return ball.mass * ball.height * gravity;
        }
    }
}