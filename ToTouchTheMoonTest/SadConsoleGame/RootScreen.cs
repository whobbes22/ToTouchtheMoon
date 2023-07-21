using SadConsole;
using SadConsole.Input;
using SadConsoleGame;
using SadRogue.Primitives;
using System.Collections.Generic;

public class RootScreen: ScreenObject
{
    private ScreenSurface _map;
    private GameObject _controlledObject;

    public RootScreen()
    {
      _map = new ScreenSurface(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 5);
      
      Children.Add(_map);
    }


  public override bool ProcessKeyboard(Keyboard keyboard)
  {
    bool handled = false;

    // Movement up or down
    if(keyboard.IsKeyPressed(Keys.Up))
    {
      _controlledObject.Move(_controlledObject.Position + Direction.Up, _map);
      handled = true;
    } else if(keyboard.IsKeyPressed(Keys.Down))
    {
      _controlledObject.Move(_controlledObject.Position + Direction.Down, _map);
      handled = true;
    }
    // Movement left or right
    if (keyboard.IsKeyPressed(Keys.Left))
    {
        _controlledObject.Move(_controlledObject.Position + Direction.Left, _map);
        handled = true;
    }
    else if (keyboard.IsKeyPressed(Keys.Right))
    {
        _controlledObject.Move(_controlledObject.Position + Direction.Right, _map);
        handled = true;
    }
    return handled;
  }
}