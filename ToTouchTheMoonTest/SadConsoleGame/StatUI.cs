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
      private int _turnCounter{get;set;}
      public ScreenSurface SurfaceObject => _statSurface;


      public StatUI(int mapWidth, int mapHeight, int floorNumber)
      {
        _turnCounter = 0;
        _statSurface = new Console(mapWidth, mapHeight);
        _statSurface.UseMouse = false;
        _statSurface.Position = new Point(0,Game.Instance.ScreenCellsY - 3);
        _statSurface.Surface.DefaultBackground = Color.Black;
        // _statSurface.DefaultBackground = Color.AnsiBlack;
        _statSurface.Print(0,0,"Name: ",Color.Wheat);
       
        _statSurface.Print(10,0,"St: ",Color.Wheat);
        _statSurface.Print(20,0,"Dx: ",Color.Wheat);
        _statSurface.Print(30,0,"To: ",Color.Wheat);
        _statSurface.Print(40,0,"In: ",Color.Wheat);
        _statSurface.Print(50,0,"Wi: ",Color.Wheat);
        _statSurface.Print(60,0,"Ch: ",Color.Wheat);
        _statSurface.Print(70,0,"Sp: ",Color.Wheat);
        _statSurface.Print(70,0,"Turn: " + _turnCounter,Color.Wheat);

        _statSurface.Print(0,1,"DV: ",Color.Wheat);
        _statSurface.Print(10,1,"HP: ",Color.Wheat);
        _statSurface.Print(20,1,"MP: ",Color.Wheat);
        _statSurface.Print(30,1,"EXP: ",Color.Wheat);
        _statSurface.Print(100,1,"Location: " + floorNumber,Color.Wheat);

        
      }

      public void RecentKeyPressed(string keys)
      {
        _statSurface.Print(0,2,"Key Pressed: " + keys,Color.Wheat);
      }

      public void IncreaseTurnCounter()
      {
        _statSurface.Print(70,0,"Turn: " + _turnCounter,Color.Wheat);
        _turnCounter++;
      }
    }
}