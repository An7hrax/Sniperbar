using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                                                                .ToList(); //cab use <Buffs>().ToList();
            var scrRect = GameController.Window.GetWindowRectangle();
            var center = new Vector2(scrRect.X + scrRect.Width / 2, scrRect.Height - 500);
            center.Y -= 15;
            var textRect = center;
            textRect.Y -= 15;

            var castbar_w = 240; //add setting increase with the power of 6 for even number so the bar is aligned with background
            var castbar_h = 10; //add setting
            var castbar_part = castbar_w / 6;

            if (Settings.MyCheckboxOption)
            {
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 1))
                {

                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 1, castbar_h), Color.Yellow);
                    Graphics.DrawText("1", textRect, Color.Yellow, "consolab:13", FontAlign.Center);
                }
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 2))
                {

                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 2, castbar_h), Color.Yellow);
                    Graphics.DrawText("2", textRect, Color.Yellow, "consolab:16", FontAlign.Center);
                }
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 3))
                {

                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 3, castbar_h), Color.Orange);
                    Graphics.DrawText("3", textRect, Color.Orange, "consolab:18", FontAlign.Center);
                }
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 4))
                {
                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 4, castbar_h), Color.Orange);
                    Graphics.DrawText("4", textRect, Color.Orange, "consolab:20", FontAlign.Center);
                }
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 5))
                {
                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 5, castbar_h), Color.OrangeRed);
                    Graphics.DrawText("5", textRect, Color.OrangeRed, "consolab:22", FontAlign.Center);
                }
                if (buffs.Exists(b => b.Name == "snipe_stacks" && b.Charges == 6))
                {
                    Graphics.DrawBox(new RectangleF(scrRect.X - 2 - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500 - 2, castbar_w + 4, castbar_h + 4), Color.Black);
                    Graphics.DrawBox(new RectangleF(scrRect.X - (castbar_part * 3) + scrRect.Width / 2, scrRect.Height - 500, castbar_part * 6, castbar_h), Color.Red);
                    Graphics.DrawText("6", textRect, Color.Red, "consolab:24", FontAlign.Center);
                }
            }
        }
    }
}
