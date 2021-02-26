using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace Sniperbar
{
    public class Settings : ISettings
    {
        public Settings() 
        {
            Enable = new ToggleNode(true);
            Shadow = new ToggleNode(true);
            Count = new ToggleNode(true);
            Bar = new ToggleNode(true);
            Size_W = new RangeNode<float>(240, 60, 480);
            Size_H = new RangeNode<float>(10, 5, 20);
        }
        //public ToggleNode Enable { get; set; } = new ToggleNode(true);

        [Menu("Enabled", "Draw sniper count")]
        public ToggleNode Enable { get; set; }

        [Menu("Shadow", "Draw Shadow on count")]
        public ToggleNode Shadow { get; set; }

        [Menu("Stack Counter", "Draw Stack Count")]
        public ToggleNode Count { get; set; }

        [Menu("Sniper Bar", "Draw Stack Count")]
        public ToggleNode Bar { get; set; }

        [Menu("Size Width")]
        public RangeNode<float> Size_W { get; set; }

        [Menu("Size Height")]
        public RangeNode<float> Size_H { get; set; }
    }
}
