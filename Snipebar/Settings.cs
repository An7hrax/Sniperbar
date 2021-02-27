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
            Size_W = new RangeNode<int>(240, 60, 480);
            Size_H = new RangeNode<int>(10, 5, 50);
        }
        //public ToggleNode Enable { get; set; } = new ToggleNode(true);

        [Menu("Enabled", "Enable plugin")]
        public ToggleNode Enable { get; set; }

        [Menu("Text Shadow", "Draw a shadow on the text")]
        public ToggleNode Shadow { get; set; }

        [Menu("Stack Counter", "Draw Stack Count")]
        public ToggleNode Count { get; set; }

        [Menu("Sniper Bar", "Draw a bar")]
        public ToggleNode Bar { get; set; }

        [Menu("Size Width", "Width of the bar")]
        public RangeNode<int> Size_W { get; set; }

        [Menu("Size Height", "Height of the bar")]
        public RangeNode<int> Size_H { get; set; }
    }
}
