using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear_Optimizer
{
    public class Statblock
    {
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Shooting { get; set; }
        public int Passing { get; set; }
        public int Technique { get; set; }

        public Statblock(int[] stats)
        {
            if (stats.Length != 5)
            {
                throw new Exception("Statblock is invalid.");
            }

            Strength = stats[0];
            Speed = stats[1];
            Shooting = stats[2];
            Passing = stats[3];
            Technique = stats[4];
        }
    }
}
