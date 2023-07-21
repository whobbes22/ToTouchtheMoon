using SadConsole;
using SadRogue.Primitives;
 
namespace SadConsoleSetup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.WindowTitle = "SadConsole";
 
            Game.Configuration gameStartup = new Game.Configuration()
                .SetScreenSize(120, 40)
                .OnStart(OnStart)
                .IsStartingScreenFocused(false)
                .ConfigureFonts((f) => f.UseBuiltinFontExtended());
 
            Game.Create(gameStartup);
            Game.Instance.Run();
            Game.Instance.Dispose();
        }
 
        private static void OnStart()
        {
          ScreenObject container = new ScreenObject();
          Game.Instance.Screen = container;
          Game.Instance.DestroyDefaultStartingConsole();

          Console console1 = new Console(60,14);
          console1.Position = new Point(3,2);
          console1.Surface.DefaultBackground = Color.AnsiCyan;
          console1.Clear();
          console1.Print(1,1,"To Touch the Moon");
          console1.Print(1,2,"Load Game");
          console1.Cursor.Position = new Point(1, 2);
   
          console1.IsFocused = true;

          Console console2 = new Console(58, 12);
          console2.Position = new Point(19, 11);
          console2.Surface.DefaultBackground = Color.AnsiRed;
          console2.Clear();
          console2.Print(1, 1, "Hello");
          console2.Cursor.Position = new Point(1, 5);
      

          container.Children.Add(console2);
          container.Children.MoveToBottom(console2);

          container.Children.Add(console1);
          container.Children.Add(console2);
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