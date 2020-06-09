using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CharacterModel
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        public int PlayerID { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        public int Strength { get; set; } 
        public int Constitution { get; set; } 
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Intellect { get; set; }
        public int Charisma { get; set; }
        //public CombatStat ArmorClass { get; private set; } = new CombatStat();
        //public CombatStat PhysicalDefense { get; private set; } = new CombatStat();
        //public CombatStat MentalDefense { get; private set; } = new CombatStat();
        //public int HitPoints { get; private set; }
        //public int Recoveries { get; private set; }
        //public string RecoveryDice { get; private set; }
        //public List<string> IconRelationships { get; set; }
        //public List<Array> Backgrounds { get; set; }
        //public List<string> Feats { get; set; }
        //public List<string> Talents { get; set; }
        //public List<string> Skills { get; set; }
        //public List<string> Spells { get; set; }
        //public List<string> Items { get; set; }
    }
}
