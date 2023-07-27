using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class CreditScreen : SadConsole.UI.ControlsConsole
    {
        public CreditScreen(): base(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY)
        {
          
          ScreenSurface _creditScreen = new ScreenSurface(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY);
          _creditScreen.Position = new Point(0,0);
          _creditScreen.Surface.DefaultBackground = Color.Black;

          _creditScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Credits");
          _creditScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Most Things: Joe Wahbeh");
          _creditScreen.Print(0,Game.Instance.ScreenCellsY - 2,"(z) to go back");
          Children.Add(_creditScreen);
        }
        public override bool ProcessKeyboard(Keyboard keyboard)
        {
          bool handled = false;
          if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.Z))
          {
            SadConsole.GameHost.Instance.Screen = new TitleScreen();
            GameHost.Instance.Screen.IsFocused = true;
            handled = true;
          }
          return handled;
        }
    }
}
