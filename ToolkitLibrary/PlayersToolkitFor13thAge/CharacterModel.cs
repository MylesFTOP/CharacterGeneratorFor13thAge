using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersToolkitFor13thAge
{
    public class CharacterModel
    {
        public string CharacterName { get; set; }
        public int CharacterID { get; set; }
        public UserModel Player { get; set; } = new UserModel();
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        public List<int> AbilityStats { get; set; }
        public List<int> Attributes { get; set; }
        public List<string> IconRelationships { get; set; }
        public List<string> Backgrounds { get; set; }
        public List<string> Feats { get; set; }
        public List<string> Talents { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Spells { get; set; }
        public List<string> Items { get; set; }
    }
}
