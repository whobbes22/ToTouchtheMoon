using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class TitleScreen : Console
    {
        public TitleScreen(): base(120, 50)
        {
          ScreenSurface _titleScreen = new ScreenSurface(120, 50);
          _titleScreen.Position = new Point(0,0);
          _titleScreen.Surface.DefaultBackground = Color.Green;

          Children.Add(_titleScreen);
        }

        public override bool ProcessKeyboard(Keyboard keyboard)
        {
          bool handled = false;
          if(keyboard.IsKeyPressed(Keys.Down))
          {
            // increase counter
          }
          return handled;
        }



        // private static void OnStart()
        // {
        //   ScreenObject container = new ScreenObject();
        //   Game.Instance.Screen = container;
        //   Game.Instance.DestroyDefaultStartingConsole();

        //   Console console1 = new Console(60,14);
        //   console1.Position = new Point(3,2);
        //   console1.Surface.DefaultBackground = Color.AnsiCyan;
        //   console1.Clear();
        //   console1.Print(1,1,"To Touch the Moon");
        //   console1.Print(1,2,"Load Game");
        //   console1.Cursor.Position = new Point(1, 2);
   
        //   console1.IsFocused = true;

        //   Console console2 = new Console(58, 12);
        //   console2.Position = new Point(19, 11);
        //   console2.Surface.DefaultBackground = Color.AnsiRed;
        //   console2.Clear();
        //   console2.Print(1, 1, "Hello");
        //   console2.Cursor.Position = new Point(1, 5);
         
        //   container.Children.Add(console1);
        //   container.Children.Add(console2);
        // }
    }
}
