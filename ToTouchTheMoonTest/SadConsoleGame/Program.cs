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
      public static int MAIN_WIDTH = 120;
      public static int MAIN_HEIGHT = 50;
      
      static void Main(string[] args)
      {
        Settings.WindowTitle = "To Touch the Moon";

        Game.Configuration gameStartup = new Game.Configuration()
            .SetScreenSize(MAIN_WIDTH, MAIN_HEIGHT)
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
          // if(SadConsole.GameHost.Instance.Keyboard.IsKeyReleased(Keys.N))
          // {
          //   SadConsole.GameHost.Instance.Screen = new RootScreen();
          //   GameHost.Instance.Screen.IsFocused = true;
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