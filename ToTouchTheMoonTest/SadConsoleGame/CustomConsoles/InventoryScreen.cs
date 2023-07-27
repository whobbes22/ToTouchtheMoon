using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class InventoryScreen : SadConsole.UI.ControlsConsole
    {
        public InventoryScreen(): base(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY)
        {
          
          ScreenSurface _inventoryScreen = new ScreenSurface(120,50);
          _inventoryScreen.Position = new Point(0,0);
          _inventoryScreen.Surface.DefaultBackground = Color.Black;

          _inventoryScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Inventory");
          _inventoryScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"something");
          
          Children.Add(_inventoryScreen);
        }
        public override bool ProcessKeyboard(Keyboard keyboard)
        {
          bool handled = false;
          if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.Z))
          {
            SadConsole.GameHost.Instance.Screen = new RootScreen();
            GameHost.Instance.Screen.IsFocused = true;
            handled = true;
          }
          return handled;
        }
    }
}
