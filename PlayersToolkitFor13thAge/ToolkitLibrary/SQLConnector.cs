using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO: Make the SaveCharacter method save to the database.
        public CharacterModel SaveCharacter(CharacterModel character) {
            character.CharacterID = 1;
            return character;
        }
    }
}
