using System;
using SadConsole;
using SadRogue.Primitives;

namespace SadConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.WindowTitle = "To Touch the Moon";
 
            Game.Configuration gameStartup = new Game.Configuration()
                .SetScreenSize(120, 50)
                .OnStart(OnStart)
                .IsStartingScreenFocused(false)
                .ConfigureFonts((f) => f.UseBuiltinFontExtended());
 
            Game.Create(gameStartup);
            Game.Instance.Run();
            Game.Instance.Dispose();
        }
 
        private static void OnStart()
        {
          Game.Instance.Screen = new RootScreen();
          Game.Instance.Screen.IsFocused = true;
          Game.Instance.DestroyDefaultStartingConsole();
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