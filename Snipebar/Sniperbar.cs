using System.Linq;
using ExileCore;
using ExileCore.PoEMemory.Components;
using ExileCore.Shared.Enums;
using SharpDX;

namespace Sniperbar
{
    public class hohohaha : BaseSettingsPlugin<Settings>
    {
        public override void Render()
        {
            var buffs = GameController.EntityListWrapper.Player.GetComponent<Life>()
                                                                .Buffs
                                                                .ToList();
            var scrRect = GameController.Window.GetWindowRectangle();
            var center = new Vector2(scrRect.X + scrRect.Width / 2, scrRect.Height - 500);
            center.Y -= 15;
            var textRect = center;
            textRect.Y -= 15;

            int set_castbar_w = Settings.Size_W.Value;
            int set_castbar_h = Settings.Size_H.Value;
            int set_castbar_part_w = set_castbar_w / 6;

            string[] fontstage = { "consolab:13", "consolab:16", "consolab:18", "consolab:20", "consolab:22", "consolab:24" };
            Color[] colorstage = { Color.Yellow, Color.Yellow, Color.Orange, Color.Orange, Color.OrangeRed, Color.Red };


            if (Settings.Enable)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == (i + 1)))
                    {
                        if (Settings.Bar)
                        {
                            Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (set_castbar_part_w * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, set_castbar_w + 4, set_castbar_h + 4), Color.Black);
                            Graphics.DrawBox(new RectangleF(scrRect.X - (set_castbar_part_w * 3) + scrRect.Width / 2, scrRect.Height - 500, set_castbar_part_w * (i + 1), set_castbar_h), colorstage[i]);
                        }
                        if (Settings.Count) 
                        {
                            if (Settings.Shadow)
                            {
                                Graphics.DrawText((i + 1).ToString(), textRect + 2, Color.Black, fontstage[i], FontAlign.Center); //Shadow
                            }                        
                            Graphics.DrawText((i + 1).ToString(), textRect, colorstage[i], fontstage[i], FontAlign.Center);
                        }
                    }
                }
            }
        }
    }
}
