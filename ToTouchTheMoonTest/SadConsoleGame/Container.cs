// using System;
// using System.Collections.Generic;
// using System.Text;
// using SadConsole;
// using SadConsole.Input;
// // using FeatureDemo.CustomConsoles;
// // using Console = SadConsole.Console;
// using SadRogue.Primitives;


// namespace SadConsoleGame
// {
//   class Container : ScreenObject
//   {
//     private int currentConsoleIndex = -1;
//     private IScreenObject selectedConsole;
//     private ScreenObject selectedConsoleContainer;
//     CustomConsole[] consoles;


//     public Container()
//     {
//       selectedConsoleContainer = new ScreenObject();
//       selectedConsoleContainer.Position = (0, 10);

//       consoles = new CustomConsole[] {
//         // new CustomConsole(new )
//       };

//       Children.Add(selectedConsoleContainer);
//       MoveNextConsole();
//     }

//     public void MoveNextConsole()
//     {
//       currentConsoleIndex++;

//       if(currentConsoleIndex >= consoles.Length)
//       {
//         currentConsoleIndex = 0;
//       }

//       selectedConsole = consoles[currentConsoleIndex].Console;
//       selectedConsoleContainer.Children.Clear();
//       selectedConsoleContainer.Children.Add(selectedConsole);

//       selectedConsole.IsVisible = true;
//       selectedConsole.IsFocused = true;

//       GameHost.Instance.FocusedScreenObjects.Set(selectedConsole);

//       if(selectedConsole is IResartable a)
//       {
//         a.Restart();
//       }
//     }
//   }
// }