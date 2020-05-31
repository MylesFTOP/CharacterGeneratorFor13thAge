using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO: Make the SaveCharacter method save to the database.
        /// <summary>
        /// Saves a new or existing character to the database.
        /// </summary>
        /// <param name="character">The character information.</param>
        /// <returns>The character details, including the unique ID.</returns>
        public CharacterModel SaveCharacter(CharacterModel character) {
            character.CharacterID = 1;
            return character;
        }
    }
}
