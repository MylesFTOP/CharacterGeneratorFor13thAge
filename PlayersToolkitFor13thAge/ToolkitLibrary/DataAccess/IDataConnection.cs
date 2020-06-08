using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public interface IDataConnection
    {
        CharacterModel SaveCharacter(CharacterModel character);
    }
}
