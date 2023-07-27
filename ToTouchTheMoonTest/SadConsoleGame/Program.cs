using System;
using SadConsole;
using SadRogue.Primitives;
using SadConsole.Input;

namespace SadConsoleGame
{
    internal class Program
    {

      // private static Container MainConsole;

      // 120, 50 is standard for now

      
      static void Main(string[] args)
      {
        Settings.WindowTitle = "To Touch the Moon";

        Game.Configuration gameStartup = new Game.Configuration()
            .SetScreenSize(Globals.GAME_WIDTH, Globals.GAME_HEIGHT)
            .OnStart(Init)
            .IsStartingScreenFocused(false)
            .ConfigureFonts((f) => f.UseBuiltinFontExtended());

        Game.Create(gameStartup);
        Game.Instance.FrameUpdate += Instance_FrameUpdate;
        Game.Instance.Run();
        Game.Instance.Dispose();
      }

        private static void Init()
        {
          
          Random rand = new Random();
          int num = rand.Next(0,2);
          GameHost.Instance.Screen = new TitleScreen();
          // if(num == 1)
          // {
          //   Game.Instance.Screen = new TitleScreen();
          // } else 
          // {
          //   Game.Instance.Screen = new RootScreen();
          // }
          
          Game.Instance.Screen.IsFocused = true;
          Game.Instance.DestroyDefaultStartingConsole();
        }

        private static void Instance_FrameUpdate(object sender, GameHost e)
        {
          
          // if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.A))
          // {
          //   ScreenSurface _keyLogger = new ScreenSurface(GameHost.Instance.ScreenCellsX, GameHost.Instance.ScreenCellsY-1);
          //   _keyLogger.Surface.DefaultBackground = Color.Green;
          //   _keyLogger.Position = new Point(0,0);
          //   _keyLogger.Surface.DefaultBackground = Color.Black;
          //   _keyLogger.Print(0,0,"Most Recently Key Pressed: ");
          //   SadConsole.GameHost.Instance.Screen.Children.Add(_keyLogger);
          // }
           
          // else if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.F4))
          //   SadConsole.Game.Instance.ToggleFullScreen();
        }
      

        
    }
}

/*
function removeAt(str){
  let arr = str.split("")
  for(let i =0; i< arr.length; i++){
    if(arr[i] === "@"){
      arr[i] = " ";
    }
  }
  return arr.join("");
}

*/