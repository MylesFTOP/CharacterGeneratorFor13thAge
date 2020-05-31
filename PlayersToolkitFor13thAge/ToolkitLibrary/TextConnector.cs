using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO: Make the SaveCharacter method save to a text file.
        public CharacterModel SaveCharacter(CharacterModel character) {
            character.CharacterID = 1;
            return character;
        }
    }
}
