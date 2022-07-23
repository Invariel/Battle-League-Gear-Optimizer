using System.ComponentModel;
using System.Text;
using System.Text.Json;

namespace Gear_Optimizer
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Character> Characters = new Dictionary<string, Character>();
        private Dictionary<string, Gear> Head = new Dictionary<string, Gear>();
        private Dictionary<string, Gear> Body = new Dictionary<string, Gear>();
        private Dictionary<string, Gear> Arms = new Dictionary<string, Gear>();
        private Dictionary<string, Gear> Legs = new Dictionary<string, Gear>();

        private BindingList<Solution> Result = new BindingList<Solution>();

        private string[] Statnames = new string[] { "None", "Strength", "Speed", "Shooting", "Passing", "Technique" };

        public Form1()
        {
            InitializeComponent();

            cmb_Primary.TextChanged += UpdateSecondary;
            cmb_Primary.LostFocus += UpdateSecondary;
            cmb_Primary.TextChanged += UpdateTertiary;
            cmb_Primary.LostFocus += UpdateTertiary;

            cmb_Secondary.TextChanged += UpdateTertiary;
            cmb_Secondary.LostFocus += UpdateTertiary;

            ParseJsonData();

            cmb_Character.DataSource = Characters.Keys.ToList();

            btn_Go.Click += CalculateOptimalStats;
            dg_Result.DataSource = Result;
        }

        private void Noop(object? sender, EventArgs e) { }

        private void CalculateOptimalStats (object? sender, EventArgs e)
        {
            List<Solution> solutions = new List<Solution>();

            Result.Clear();

            foreach (KeyValuePair<string, Gear> head in Head)
                foreach (KeyValuePair<string, Gear> body in Body)
                    foreach (KeyValuePair<string, Gear> arms in Arms)
                        foreach (KeyValuePair<string, Gear> legs in Legs)
                        {
                            if (IgnoreBushido(head.Key, body.Key, arms.Key, legs.Key))
                                continue;

                            Character selectedCharacter = Characters[cmb_Character.Text];

                            selectedCharacter.Head = head.Value;
                            selectedCharacter.Body = body.Value;
                            selectedCharacter.Arms = arms.Value;
                            selectedCharacter.Legs = legs.Value;

                            Solution newSolution = new Solution();

                            newSolution.CalculateBonus(selectedCharacter, cmb_Primary.Text, cmb_Secondary.Text, cmb_Tertiary.Text);

                            solutions.Add(newSolution);
                        }

            solutions.Sort();

            for (int i = 0; i < numud_Results.Value; ++ i)
            {
                Result.Add(solutions[i]);
            }
            dg_Result.DataSource = null;
            dg_Result.DataSource = Result;

            dg_Result.Refresh();
        }

        private bool IgnoreBushido (string head, string body, string arms, string legs)
        {
            return chk_IgnoreBushido.Checked && (head == "Bushido" || body == "Bushido" || arms == "Bushido" || legs == "Bushido");
        }

        private void UpdateSecondary(object? sender, EventArgs e)
        {
            cmb_Secondary.DataSource = null;
            cmb_Secondary.DataSource = Statnames.Where(s => s != cmb_Primary.Text).ToList();
            cmb_Secondary.Refresh();
        }

        private void UpdateTertiary(object? sender, EventArgs e)
        {
            cmb_Tertiary.DataSource = null;
            cmb_Tertiary.DataSource = Statnames.Where(s => s == "None" || (s != cmb_Primary.Text && s != cmb_Secondary.Text)).ToList();
            cmb_Secondary.Refresh();
        }

        private void ParseJsonData ()
        {
            var parsedData = JsonSerializer.Deserialize<RawData>(File.ReadAllText("stats.json"));

            foreach (KeyValuePair<string, int[]> gear in parsedData.Gearlist.Head)
            {
                Head.Add(gear.Key, new Gear(gear.Key, gear.Value));
            }

            foreach (KeyValuePair<string, int[]> gear in parsedData.Gearlist.Arms)
            {
                Arms.Add(gear.Key, new Gear(gear.Key, gear.Value));
            }

            foreach (KeyValuePair<string, int[]> gear in parsedData.Gearlist.Body)
            {
                Body.Add(gear.Key, new Gear(gear.Key, gear.Value));
            }

            foreach (KeyValuePair<string, int[]> gear in parsedData.Gearlist.Legs)
            {
                Legs.Add(gear.Key, new Gear(gear.Key, gear.Value));
            }

            foreach (KeyValuePair<string, int[]> kvp in parsedData.Characters)
            {
                Character character = new Character(kvp.Key, kvp.Value);
                character.Head = Head["None"];
                character.Arms = Arms["None"];
                character.Body = Body["None"];
                character.Legs = Legs["None"];
                Characters.Add(kvp.Key, character);
            }
        }
    }
}