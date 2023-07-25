using SadConsole;
using SadConsole.Input;
using SadConsoleGame;
using SadRogue.Primitives;
using System.Collections.Generic;

namespace SadConsoleGame
{
  public class RootScreen: ScreenObject
  {
      private Map _map;

      public RootScreen()
      {
        _map = new Map(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 5);
        
        Children.Add(_map.SurfaceObject);
      }


    public override bool ProcessKeyboard(Keyboard keyboard)
    {
      bool handled = false;

      // Movement up or down
      if(keyboard.IsKeyPressed(Keys.Up))
      {
        _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Up, _map);
        handled = true;
      } else if(keyboard.IsKeyPressed(Keys.Down))
      {
        _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Down, _map);
        handled = true;
      }
      // Movement left or right
      if (keyboard.IsKeyPressed(Keys.Left))
      {
          _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Left, _map);
          handled = true;
      }
      else if (keyboard.IsKeyPressed(Keys.Right))
      {
          _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Right, _map);
          handled = true;
      }
      return handled;
    }


  }
}