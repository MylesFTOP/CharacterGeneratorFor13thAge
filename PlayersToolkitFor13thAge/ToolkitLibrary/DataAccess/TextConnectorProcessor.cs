using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return File.ReadAllLines(file).ToList();
        }

        public static List<CharacterModel> ConvertToCharacterModels(this List<string> lines) {
            List<CharacterModel> output = new List<CharacterModel>();

            foreach ( string line in lines )
            {
                string[] cols = line.Split(',');

                CharacterModel c = new CharacterModel();
                c.CharacterID = int.Parse(cols[0]);
                c.CharacterName = cols[1];
                c.PlayerID = int.Parse(cols[2]);
                c.CharacterRace = cols[3];
                c.CharacterClass = cols[4];
                c.CharacterLevel = uint.Parse(cols[5]);
                c.Strength = uint.Parse(cols[6]);
                c.Constitution = uint.Parse(cols[7]);
                c.Dexterity = uint.Parse(cols[8]);
                c.Wisdom = uint.Parse(cols[9]);
                c.Intelligence = uint.Parse(cols[10]);
                c.Charisma = uint.Parse(cols[11]);
                c.CurrentHitPoints = int.Parse(cols[12]);
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
