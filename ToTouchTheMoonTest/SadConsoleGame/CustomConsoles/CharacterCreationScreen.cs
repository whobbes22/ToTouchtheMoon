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

          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Character Creation");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Choose a Celestial Month");

          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 4,"Eagle");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 6,"Swordfish");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 8,"Gaia Major");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 10,"Hare");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 12,"Crane");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 14,"Sun");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 16,"Fox");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 18,"Flying Fish");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 20,"Gaia Minor");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 22,"little Horse");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 24,"Lynx");
          _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 26,"Moon");

          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Sex");
          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Race");
          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Class");
          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3+ 2,"Stats");

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
