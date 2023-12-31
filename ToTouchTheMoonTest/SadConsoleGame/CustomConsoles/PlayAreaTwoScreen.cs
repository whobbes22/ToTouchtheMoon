using SadConsole;
using SadConsole.Input;
using SadConsoleGame;
using SadRogue.Primitives;
using System.Collections.Generic;

namespace SadConsoleGame
{
  public class PlayAreaTwoScreen: ScreenObject
  {
    private Map _map;
    private StatUI _statUI;


    public PlayAreaTwoScreen()
    {

      _map = new Map(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 3,10,2);
      _statUI = new StatUI(Game.Instance.ScreenCellsX, 5, 2);
      
      
      addMapObject();
      addUIObject();
      
    }

    public void addMapObject()
    {
      Children.Add(_map.SurfaceObject);
    }
    public void addUIObject()
    {
      Children.Add(_statUI.SurfaceObject);
    }


    public override bool ProcessKeyboard(Keyboard keyboard)
    {
      bool handled = false;

      if(keyboard.IsKeyPressed(Keys.OemComma))
      {
        SadConsole.GameHost.Instance.Screen = new RootScreen();
        GameHost.Instance.Screen.IsFocused = true;
        
        handled = true;
      }
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

    // ******* numpad directions ****

    if(keyboard.IsKeyPressed(Keys.NumPad1))
      {
        _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Down + Direction.Left, _map);
        handled = true;
      } else if (keyboard.IsKeyPressed(Keys.NumPad2))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Down, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad3))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Down + Direction.Right, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad4))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Left, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad5))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad6))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Right, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad7))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Up + Direction.Left, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad8))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Up, _map);
        handled = true;
      }else if (keyboard.IsKeyPressed(Keys.NumPad9))
      {
         _map.UserControlledObject.Move(_map.UserControlledObject.Position + Direction.Up + Direction.Right, _map);
        handled = true;
      }


      return handled;
    }

    

  }
}