using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gear_Optimizer
{
    public class Character
    {
        public string Name { get; set; }
        public Statblock BaseStats { get; set; }
        public Gear Head { get; set; }
        public Gear Body { get; set; }
        public Gear Arms { get; set; }
        public Gear Legs { get; set; }

        private int STAT_MINIMUM = 1;
        private int STAT_MAXIMUM = 25;

        public int Strength {
            get
            {
                return Clamp (BaseStats.Strength + Head.Strength + Body.Strength + Arms.Strength + Legs.Strength);
            }
        }

        public int Speed
        {
            get
            {
                return Clamp (BaseStats.Speed + Head.Speed + Body.Speed + Arms.Speed + Legs.Speed);
            }
        }

        public int Shooting
        {
            get
            {
                return Clamp (BaseStats.Shooting + Head.Shooting + Body.Shooting + Arms.Shooting + Legs.Shooting);
            }
        }

        public int Passing
        {
            get
            {
                return Clamp (BaseStats.Passing + Head.Passing + Body.Passing + Arms.Passing + Legs.Passing);
            }
        }

        public int Technique
        {
            get
            {
                return Clamp (BaseStats.Technique + Head.Technique + Body.Technique + Arms.Technique + Legs.Technique);
            }
        }

        public int Clamp (int stat)
        {
            return Math.Max(STAT_MINIMUM, Math.Min(STAT_MAXIMUM, stat));
        }

        public Character(string name, int[] stats)
        {
            Name = name;
            BaseStats = new Statblock(stats);
        }

        public string ToString (bool csvChecked)
        {
            string retval = "";

            if (csvChecked)
            {
                retval = $"{Name}\t{Strength}\t{Speed}\t{Shooting}\t{Passing}\t{Technique}\t{Head.Name}\t{Arms.Name}\t{Body.Name}\t{Legs.Name}";
            }
            else
            {
                retval = this.ToString();
            }

            return retval;
        }

        public override string ToString()
        {
            return $"{Name}: {Strength}, {Speed}, {Shooting}, {Passing}, {Technique}\t\t" +
                   $"Head: {Head.Name}, Arms: {Arms.Name}, Body: {Body.Name}, Legs: {Legs.Name}";
        }
    }

    public class Gear : Statblock
    {
        public string Name { get; set; }

        public Gear(string name, int[] stats) : base(stats)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}: {Strength}, {Speed}, {Shooting}, {Passing}, {Technique}";
        }
    }
}