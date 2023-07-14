﻿Settings.WindowTitle = "My SadConsole Game";

Game.Configuration gameStartup = new Game.Configuration()
    .SetScreenSize(GameSettings.GAME_WIDTH, GameSettings.GAME_HEIGHT)
    .SetStartingScreen<ToTouchTheMoon.Scenes.RootScene>()
    ;

Game.Create(gameStartup);
Game.Instance.Run();
Game.Instance.Dispose();
