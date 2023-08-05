using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class CharacterCreationScreen : ScreenObject
    {
        public CharacterCreationScreen()
        {
          
          ScreenSurface _CharacterCreationScreen = new ScreenSurface(Game.Instance.ScreenCellsX,Game.Instance.ScreenCellsY);
          _CharacterCreationScreen.Position = new Point(0,0);
          _CharacterCreationScreen.Surface.DefaultBackground = Color.Black;

          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Character Creation");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Celestial Month");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Sex");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Race");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Class");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Stats");
          
          // _CharacterCreationScreen.Print(0,Game.Instance.ScreenCellsY - 2,"(z) to go back");
          Children.Add(_CharacterCreationScreen);
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
