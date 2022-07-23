namespace Gear_Optimizer
{
    public partial class Form1
    {
        public class Solution : IComparable<Solution>
        {
            public int Strength { get; set; }
            public int Speed { get; set; }
            public int Shooting { get; set; }
            public int Passing { get; set; }
            public int Technique { get; set; }


            public string Head { get; set; }
            public string Arms { get; set; }
            public string Body { get; set; }
            public string Legs { get; set; }


            public int Weight { get; set; }
            public int Bonus { get; set; }

            public void CalculateBonus (Character character, string primary, string? secondary = null, string? tertiary = null)
            {
                Strength = character.Strength;
                Speed = character.Speed;
                Shooting = character.Shooting;
                Passing = character.Passing;
                Technique = character.Technique;

                Head = character.Head.Name;
                Arms = character.Arms.Name;
                Body = character.Body.Name;
                Legs = character.Legs.Name;

                Weight = GetBonus(character, primary) * 3 + GetBonus(character, secondary) * 2 + GetBonus(character, tertiary);
                Bonus = GetBonus(character, primary) + GetBonus(character, secondary) + GetBonus(character, tertiary);
            }

            public int GetBonus (Character character, string? stat)
            {
                int bonus = 0;

                switch (stat ?? "None")
                {
                    case "Strength":
                        bonus = character.Strength - character.BaseStats.Strength;
                        break;
                    case "Speed":
                        bonus = character.Speed - character.BaseStats.Speed;
                        break;
                    case "Shooting":
                        bonus = character.Shooting - character.BaseStats.Shooting;
                        break;
                    case "Passing":
                        bonus = character.Passing - character.BaseStats.Passing;
                        break;
                    case "Technique":
                        bonus = character.Technique - character.BaseStats.Technique;
                        break;
                }

                return bonus;
            }

            public int CompareTo(Solution? other)
            {
                if (other is null)
                    return 1;

                if (other.Weight - this.Weight == 0)
                {
                    return other.Bonus - this.Bonus;
                }

                return other.Weight - this.Weight;
            }
        }
    }
}