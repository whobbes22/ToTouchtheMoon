using System;
using System.Collections.Generic;
using System.Text;
using SadConsole;
using SadConsole.Input;
// using FeatureDemo.CustomConsoles;
// using Console = SadConsole.Console;
using SadRogue.Primitives;

namespace TTtMGame
{
  class Container : ScreenObject
  {
    private int currentConsoleIndex = -1;
    private IScreenObject selectedConsole;
    private ScreenObject selectedConsoleContainer;
    CustomConsole[] consoles;


    public Container()
    {
      selectedConsoleContainer = new ScreenObject();
      selectedConsoleContainer.Position = (0, 10);

      consoles = new CustomConsole[] {
        // new CustomConsole(new )
      };
    }
  }
}