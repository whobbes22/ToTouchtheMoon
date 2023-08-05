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

          int x = GameHost.Instance.ScreenCellsX / 10;
          int y = GameHost.Instance.ScreenCellsY / 10;
          int offsetX = 2;
          int secondOffSetX = 50;  
          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Character Creation");
          _CharacterCreationScreen.Print(x,y,"Choose A Celestial Month");

          _CharacterCreationScreen.Print(x + offsetX, y + 4,"[Aa] Eagle");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 4,"[Bb] Swordfish");
          _CharacterCreationScreen.Print(x + offsetX, y + 8,"[Cc] Gaia Major");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 8,"[Dd] Hare");
          _CharacterCreationScreen.Print(x + offsetX, y + 12,"[Ee] Crane");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 12,"[Ff] Sun");
          _CharacterCreationScreen.Print(x + offsetX, y + 16,"[Gg] Fox");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 16,"[Hh] Flying Fish");
          _CharacterCreationScreen.Print(x + offsetX, y + 20,"[Ii] Gaia Minor");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 20,"[Jj] little Horse");
          _CharacterCreationScreen.Print(x + offsetX, y + 24,"[Kk] Lynx");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 24,"[Ll] Moon");

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
