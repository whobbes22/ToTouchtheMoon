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
            if(SadConsole.GameHost.Instance.Keyboard.IsKeyDown(Keys.LeftShift) || SadConsole.GameHost.Instance.Keyboard.IsKeyDown(Keys.RightShift))
            {
              if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.A))
              {
                _CharacterCreationScreen.Print(1, 1,"upper A pressed");
                handled = true;
              }
              else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.B))
              {
                _CharacterCreationScreen.Print(1, 1,"upper B pressed");
                handled = true;
              }
  
            }

            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.A))
              {
                _CharacterCreationScreen.Print(1, 1,"lower a pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.B))
              {
                _CharacterCreationScreen.Print(1, 1,"lower b pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.C))
              {
                _CharacterCreationScreen.Print(1, 1,"lower c pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.D))
              {
                _CharacterCreationScreen.Print(1, 1,"lower d pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.E))
              {
                _CharacterCreationScreen.Print(1, 1,"lower e pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.F))
              {
                _CharacterCreationScreen.Print(1, 1,"lower f pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.G))
              {
                _CharacterCreationScreen.Print(1, 1,"lower g pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.H))
              {
                _CharacterCreationScreen.Print(1, 1,"lower h pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.I))
              {
                _CharacterCreationScreen.Print(1, 1,"lower i pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.J))
              {
                _CharacterCreationScreen.Print(1, 1,"lower j pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.K))
              {
                _CharacterCreationScreen.Print(1, 1,"lower k pressed");
                characterCreationLocation++;
                handled = true;
              }
            else if(SadConsole.GameHost.Instance.Keyboard.IsKeyPressed(Keys.L))
              {
                _CharacterCreationScreen.Print(1, 1,"lower l pressed");
                characterCreationLocation++;
                handled = true;
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

          characterCreationLocation = 1;
          return false;
        }
    }
}
