using System;
using SadConsole.Input;

namespace SadConsoleGame
{
    public class TitleScreen : Console
    {
        public TitleScreen(): base(120, 50)
        {
          ScreenSurface _titleScreen = new ScreenSurface(119, 50);
          _titleScreen.Position = new Point(0,0);
          _titleScreen.Surface.DefaultBackground = Color.Black;


         _titleScreen.Print(0,5,
@"                                                                                                                                                                                                                                                                                                                                                                                                                           ...............                           .^                                                                   ....::::^^^~~~~!~^::::::::..                   ..:YPJ^                                                              ..::^~~~~~^~~~~~^^^~~^^^^::^:::::.                .55GBG5:.                                                         ..:^^^^~!!!7!~~^^^^:^^~!!!!!~^::::.::..             :7JBGBB5JY:                                                      :^~!^^~!7J?????7!!!~^~?????J?!~::::::^:^^^.           .?GGBGBBP7                                                     .~!7!^^!JJYYJJ??J?7!!!!7JJJJ?JJY?~:^^^^:^7??7:.       ~!Y5BBGBGY!7^                                                   :7???!~7JJJYYJJJ?J7!!!!~7JYJJ?JJJY?!!7?~::^7JJ~::      :YPGGGGBBBPJ.                                                  ^??J????J?JJJJJJ?7?7!!~^^!?J?J???JJYYJYYY?!^^^~^^~:     :J5GPGGGBGPY~                                                 :?JJ?777???JJJ????????!~~7???!?!!?Y5YJYYYYY?7!7!~~~^:   !!?GGGGG##5YPY7.                                              .!?JJ?~!7?JJ?7?7?77!!777????JY?7~~7YYYYYYJ???7?JYJ?!^^: ..75GBGGBBBB5PG?                                               :7?JJ?7????J?!~~~^~~~!7JJ!~~~~~^:^~!?JJJJ?^^~!?JJJ7!^^: !J5GPGPG#GPGGJ^.~:                                             ^?JYYJJJJ77??!~~^^~!?7?YJ7!!!^::::::^:^~?7^^:^~7?J7^:^^ ~5PPPP#P5BBBG7JYJ.                                             ^7JYYYYYJ7~~777!~~!!????7!!7~^^::::::.:^~~~~~^:^~~!!~^^ :GGBPG##BGP5J?55~.                                             :^7YJJYYY?7!???77!7!!77!^^^^^^^^:::::::..:^7?7^^^~!^^^^~:7GGG#&BGGGBB#GG5! .                                           .:^7YYYYYYYJJJ??7?J7!~7?7~^^~~^^^^:::^::..:~!!~^^^~::^:~YJ5G###BBB#BGBGGBGY!.                                           ::^?YYYYYYYYJJ7!?JJ?7!7J?7!^^^^^^^^^::^::::^:^::....!?~^~~!7YPGG##BGPPPJ!^:                                            .:^!7JYYYYY?JJJJJ?7????JJ?~^:^^^^^:::^^:::::::::...:^5BGBPPBBBGGBGG5!^~!JJ~                                             .^^:~7?7?7!~7?J?7~77?JJJJ7~:^::::::^:::::^^::::.::^:~JGGBBBPGG#BGB&####5^ .                                             :::^^^~!~^!JYY777777JJ??!^.....::::::::::::::::^~^^75Y5BB#BBBB&&&#GBGGPPY~                                              .:^:::^^^!JJYY7!77!~^^^:.. ....::::::::::.:::^^..7YP5GG####GG##GPGGGB?7:                                                ..::.::::^~!!~~7!~^::..........:::^::::::::^:    ^5GBGGBB#####BB#BBBP5J:                                                 .::::^^:^^~~^^:^^^::.:.:.....:::::::::::.       .7YGBBBBGGBP##&#BBGP?                                                    ..:^^:^~^^^^^^:^^:::....::::::::::...      .!??!7YGBB#GPBP#GY5PYY!                                                        ..::^^^^^~~^^^^:::.............           :7?J?!JBG55PPPJ?7^                                                               ..:::::::::..:........                  ~??Y?7!.?Y.:~!:                                                                        ...  ..                                 J5.                                                                                                                    ?5:                                                                                                                   :Y?~                    ");

          _titleScreen.Print(5,8,"To Touch the Moon");
          _titleScreen.Print(5,15,"New Game");
          _titleScreen.Print(5,18,"Load Game (WIP)");
          _titleScreen.Print(5,21, "Credits (WIP)");
          Children.Add(_titleScreen);
        }

        public override bool ProcessKeyboard(Keyboard keyboard)
        {
          bool handled = false;
          if(keyboard.IsKeyPressed(Keys.Down))
          {
            // increase counter
          }
          return handled;
        }



        // private static void OnStart()
        // {
        //   ScreenObject container = new ScreenObject();
        //   Game.Instance.Screen = container;
        //   Game.Instance.DestroyDefaultStartingConsole();

        //   Console console1 = new Console(60,14);
        //   console1.Position = new Point(3,2);
        //   console1.Surface.DefaultBackground = Color.AnsiCyan;
        //   console1.Clear();
        //   console1.Print(1,1,"To Touch the Moon");
        //   console1.Print(1,2,"Load Game");
        //   console1.Cursor.Position = new Point(1, 2);
   
        //   console1.IsFocused = true;

        //   Console console2 = new Console(58, 12);
        //   console2.Position = new Point(19, 11);
        //   console2.Surface.DefaultBackground = Color.AnsiRed;
        //   console2.Clear();
        //   console2.Print(1, 1, "Hello");
        //   console2.Cursor.Position = new Point(1, 5);
         
        //   container.Children.Add(console1);
        //   container.Children.Add(console2);
        // }
    }
}
