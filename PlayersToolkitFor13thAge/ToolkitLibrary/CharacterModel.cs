using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CharacterModel
    {
        public string CharacterName { get; set; }
        public int CharacterID { get; set; }
        public UserModel Player { get; set; } = new UserModel();
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        public AbilityStat Strength { get; set; } = new AbilityStat();
        public AbilityStat Constitution { get; set; } = new AbilityStat();
        public AbilityStat Dexterity { get; set; } = new AbilityStat();
        public AbilityStat Wisdom { get; set; } = new AbilityStat();
        public AbilityStat Intellect { get; set; } = new AbilityStat();
        public AbilityStat Charisma { get; set; } = new AbilityStat();
        public CombatStat ArmorClass { get; private set; } = new CombatStat();
        public CombatStat PhysicalDefense { get; private set; } = new CombatStat();
        public CombatStat MentalDefense { get; private set; } = new CombatStat();
        public int HitPoints { get; private set; }
        public int Recoveries { get; private set; }
        public string RecoveryDice { get; private set; }
        public List<string> IconRelationships { get; set; }
        public List<Array> Backgrounds { get; set; }
        public List<string> Feats { get; set; }
        public List<string> Talents { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Spells { get; set; }
        public List<string> Items { get; set; }
    }
}
