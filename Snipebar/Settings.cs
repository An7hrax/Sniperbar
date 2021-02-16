using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace Sniperbar
{
    public class Settings : ISettings
    {
        public ToggleNode Enable { get; set; } = new ToggleNode(true);

        [Menu("Enabled", "Draw sniper count")]
        public ToggleNode MyCheckboxOption { get; set; } = new ToggleNode(true);
    }
}
