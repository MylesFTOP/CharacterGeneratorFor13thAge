using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlayersToolkit.WebUI.Models;

namespace PlayersToolkit.WebUI.Data
{
    public class PlayersToolkitWebUIContext : DbContext
    {
        public PlayersToolkitWebUIContext (DbContextOptions<PlayersToolkitWebUIContext> options)
            : base(options)
        {
        }

        public DbSet<PlayersToolkit.WebUI.Models.CharacterViewModel> CharacterViewModel { get; set; }
    }
}
