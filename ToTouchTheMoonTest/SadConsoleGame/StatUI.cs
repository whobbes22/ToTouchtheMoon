using SadConsole;
using SadRogue.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace TTtMGame
{
    public class StatUI
    {
      private ScreenSurface _statSurface;
    
      public ScreenSurface SurfaceObject => _statSurface;


      public StatUI(int mapWidth, int mapHeight)
      {
      
        _statSurface = new ScreenSurface(mapWidth, mapHeight);
        _statSurface.UseMouse = false;

        _statSurface.SetBackground(Color.Black);
        _statSurface.Print(4,4,"hi",Color.Black);

      }

    }
}