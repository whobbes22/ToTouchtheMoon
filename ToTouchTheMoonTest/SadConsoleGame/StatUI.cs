using System;
using SadConsole;
using SadRogue.Primitives;
using System.Collections.Generic;
using System.Linq;


namespace SadConsoleGame
{
    public class StatUI
    {
      private ScreenSurface _statSurface;
    
      public ScreenSurface SurfaceObject => _statSurface;


      public StatUI(int mapWidth, int mapHeight)
      {
      
        _statSurface = new Console(mapWidth, mapHeight);
        _statSurface.UseMouse = false;
        _statSurface.Position = new Point(15,10);
        // _statSurface.DefaultBackground = Color.AnsiBlack;
        _statSurface.Print(4,4,"HP",Color.Black);
        _statSurface.Print(4,5,"PP",Color.Black);
      }

    }
}