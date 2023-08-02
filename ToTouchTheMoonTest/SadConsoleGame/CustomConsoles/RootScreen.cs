using SadConsole;
using SadConsole.Input;
using SadConsoleGame;
using SadRogue.Primitives;
using System.Collections.Generic;

namespace SadConsoleGame
{
  public class RootScreen: ScreenObject
  {
    private Map _map1;
    private Map _map2;

    private Map _currentMap;
    private StatUI _statUI;
    
    private static int floorNumber = 1;
    private static Dictionary<int,Map> _locations;
  
    public RootScreen()
    {
      GenerateMap();
      
    }

    public void GenerateMap()
    {
      
      _map1 = new Map(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 3,2,5);
      _map2 = new Map(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 3,15,2);
      _statUI = new StatUI(Game.Instance.ScreenCellsX, 5,floorNumber);
      
      _currentMap = _map1;
      
      RefocusCurrentMap();
      
    }

    public void RefocusCurrentMap()
    {
      
      Children.Clear();
      Children.Add(_currentMap.SurfaceObject);
      Children.Add(_statUI.SurfaceObject);
  }
    
    public override bool ProcessKeyboard(Keyboard keyboard)
    {
      bool handled = false;
      
      if(keyboard.HasKeysPressed)
      {
        string keys = "";
        // need to convert asciiKey into a string
        foreach(AsciiKey key in keyboard.KeysPressed)
        {
          keys += $" {key.Character}";
        }
        _statUI.RecentKeyPressed(keys);
        // handled = true;
      }
      // **************** INVENTORY *************
      if(keyboard.IsKeyPressed(Keys.I))
      {
          SadConsole.GameHost.Instance.Screen = new InventoryScreen();
          GameHost.Instance.Screen.IsFocused = true;
          handled = true;
      }
      


      // if(keyboard.IsKeyPressed(Keys.Q))
      // {
      //   handled = true;
      //   _map.SurfaceObject.IsFocused = false;
      //   _map.SurfaceObject.IsVisible = false;
      // }
      // if(keyboard.IsKeyPressed(Keys.W))
      // {
      //   handled = true;
      //   _map.SurfaceObject.IsVisible = true;
      // }

      // ******************* Staris ******************
      if(keyboard.IsKeyPressed(Keys.OemComma))
      {
        _map2 = _currentMap;
        _currentMap = _map1;
        
        if(floorNumber <=1)
        {
          floorNumber = 1;
        } else
        {
          floorNumber--;
        }
        //floorNumber = (floorNumber <=1) ? 1 : floorNumber--;

        RefocusCurrentMap();
        handled = true;
        
      }

      if(keyboard.IsKeyPressed(Keys.Decimal))
      {
        
        _map1 = _currentMap;
        _currentMap = _map2;
        
        floorNumber++;

        RefocusCurrentMap();
        handled = true;
        // floorNumber++;
      }


      
      // Movement up or down
      if(keyboard.IsKeyPressed(Keys.Up))
      {
        _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Up, _currentMap);
        
        handled = true;
      } else if(keyboard.IsKeyPressed(Keys.Down))
      {
        _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Down, _currentMap);
        handled = true;
      }
      // Movement left or right
      if (keyboard.IsKeyPressed(Keys.Left))
      {
          _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Left, _currentMap);
          handled = true;
      }
      else if (keyboard.IsKeyPressed(Keys.Right))
      {
          _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Right, _currentMap);
          handled = true;
      }

    // ******* numpad directions ****

    if(keyboard.IsKeyPressed(Keys.NumPad1))
      {
        _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Down + Direction.Left, _currentMap);
        handled = true;
      } else if (keyboard.IsKeyPressed(Keys.NumPad2))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Down, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad3))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Down + Direction.Right, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad4))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Left, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad5))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad6))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Right, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad7))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Up + Direction.Left, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad8))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Up, _currentMap);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad9))
      {
         _currentMap.UserControlledObject.Move(_currentMap.UserControlledObject.Position + Direction.Up + Direction.Right, _currentMap);
        handled = true;
      }

      if(handled)
      {
        _statUI.IncreaseTurnCounter();
        _statUI.updateFloorNumber(floorNumber);
      }
      return handled;
    }

    

  }
}