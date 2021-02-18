using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace ToolkitLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file) {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file)
                .ToList();
        }

        public static List<CharacterModel> ConvertToCharacterModels(this List<string> lines) {
            List<CharacterModel> output = new List<CharacterModel>();

            foreach ( string line in lines )
            {
                string[] cols = line.Split(',');

                CharacterModel c = new CharacterModel(
                    characterName : cols[1],
                    characterRace : cols[3],
                    characterClass : cols[4],
                    characterLevel : cols[5],
                    strength : cols[6],
                    constitution : cols[7],
                    dexterity : cols[8],
                    wisdom : cols[9],
                    intelligence : cols[10],
                    charisma : cols[11],
                    currentHitPoints : cols[12]
                )
                {
                    CharacterID = int.Parse(cols[0]),
                    PlayerID = int.Parse(cols[2])
                };
                output.Add(c);
            }
            return output;
        }

        public static void SaveToCharactersFile(this List<CharacterModel> models, string fileName) {
            List<string> lines = new List<string>();

            foreach ( CharacterModel c in models )
            {
                lines.Add($"{c.CharacterID},{c.CharacterName},{c.PlayerID},{c.CharacterRace},{c.CharacterClass},{c.CharacterLevel},{c.Strength},{c.Constitution},{c.Dexterity},{c.Wisdom},{c.Intelligence},{c.Charisma},{c.CurrentHitPoints}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
