using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class CharacterCreationScreen : ScreenObject
    {
      private int characterCreationLocation = 1;

      private ScreenSurface _CharacterCreationScreen = new ScreenSurface(Game.Instance.ScreenCellsX,Game.Instance.ScreenCellsY);
        public CharacterCreationScreen()
        {
          
          
          _CharacterCreationScreen.Position = new Point(0,0);
          _CharacterCreationScreen.Surface.DefaultBackground = Color.Black;

          int x = GameHost.Instance.ScreenCellsX / 10;
          int y = GameHost.Instance.ScreenCellsY / 10;
          int offsetX = 2;
          int secondOffSetX = 50;  
          // _CharacterCreationScreen.Print(GameHost.Instance.ScreenCellsX / 3,Game.Instance.ScreenCellsY / 3,"Character Creation");
          _CharacterCreationScreen.Print(x,y,"Choose A Celestial Month");

          _CharacterCreationScreen.Print(x + offsetX, y + 4,"[aA] Eagle");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 4,"[bB] Swordfish");
          _CharacterCreationScreen.Print(x + offsetX, y + 8,"[cC] Gaia Major");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 8,"[dD] Hare");
          _CharacterCreationScreen.Print(x + offsetX, y + 12,"[eE] Crane");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 12,"[fF] Sun");
          _CharacterCreationScreen.Print(x + offsetX, y + 16,"[gG] Fox");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 16,"[hH] Flying Fish");
          _CharacterCreationScreen.Print(x + offsetX, y + 20,"[iI] Gaia Minor");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 20,"[jJ] little Horse");
          _CharacterCreationScreen.Print(x + offsetX, y + 24,"[kK] Lynx");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 24,"[lL] Moon");

          _CharacterCreationScreen.Print(x + offsetX, y + 30,"[a-l] Pick Month");
          _CharacterCreationScreen.Print(x + offsetX + secondOffSetX,y + 30,"[A-L] Describe Month");


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

          // ********************** Month *********************
          if(characterCreationLocation == 1){
            if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.LeftShift) || SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.RightShift))
            {
              _CharacterCreationScreen.Print(1, 1,"shift pressed");
              handled = true;
            }
            if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.Z))
              {
                // SadConsole.GameHost.Instance.Screen = new RootScreen();
                // GameHost.Instance.Screen.IsFocused = true;
                // handled = true;
              }
          }
          // ********************** Sex *********************
          if(characterCreationLocation == 2)
          {

          }
          // ********************** Race *********************
          if(characterCreationLocation == 3)
          {

          }
          // ********************** Class *********************
          if(characterCreationLocation == 4)
          {
            
          }
          // ********************** Stats *********************
          if(characterCreationLocation == 5)
          {
            
          }

          return handled;
        }
    }
}
