using SadConsole;
using SadRogue.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace SadConsoleGame
{
    public class Map
    {
      private List<GameObject> _mapObjects;
      private ScreenSurface _mapSurface;

      public IReadOnlyList<GameObject> GameObjects => _mapObjects.AsReadOnly();
      public ScreenSurface SurfaceObject => _mapSurface;
      public GameObject UserControlledObject { get; set; }

      public Map(int mapWidth, int mapHeight)
      {
        _mapObjects = new List<GameObject>();
        _mapSurface = new ScreenSurface(mapWidth, mapHeight);
        _mapSurface.UseMouse = false;

        FillBackground();
      
        UserControlledObject = new GameObject(new ColoredGlyph(Color.White, Color.Black, 2), 
                                            _mapSurface.Surface.Area.Center, _mapSurface);

        CreateTreasure();
        CreateMonster();
      }

      private void FillBackground()
      {
        Color[] colors = new[] { Color.LightGreen, Color.Coral, Color.CornflowerBlue, Color.DarkGreen };
        float[] colorStops = new[] { 0f, 0.35f, 0.75f, 1f };

        Algorithms.GradientFill(_mapSurface.FontSize,
                                _mapSurface.Surface.Area.Center,
                                _mapSurface.Surface.Width / 3,
                                45,
                                _mapSurface.Surface.Area,
                                new Gradient(colors, colorStops),
                                (x, y, color) => _mapSurface.Surface[x, y].Background = color);
      }

      public void CreateTreasure()
      {
        for(int i = 0; i < 1000; i++)
        {
          Point randomPosition = new Point(Game.Instance.Random.Next(0,_mapSurface.Width), Game.Instance.Random.Next(0,_mapSurface.Surface.Height));

          bool fouundObject = _mapObjects.Any(obj => obj.Position == randomPosition );
          if(fouundObject) continue;

          GameObject treasure = new GameObject(new ColoredGlyph(Color.Yellow, Color.Black, 'v'),
                                                    randomPosition, _mapSurface);
          _mapObjects.Add(treasure);
          break;
        }
      }

      public void CreateMonster()
      {
        for(int i = 0; i <1000; i++)
        {
          Point randomPosition = new Point(Game.Instance.Random.Next(0,_mapSurface.Surface.Width),
                                                Game.Instance.Random.Next(0, _mapSurface.Surface.Height));
          bool foundObject = _mapObjects.Any(obj => obj.Position == randomPosition);
          if(foundObject) continue;

          GameObject monster = new GameObject(new ColoredGlyph(Color.Red, Color.Black, 'M'), randomPosition,
                                                                                            _mapSurface);
          _mapObjects.Add(monster);
          break;
        }
      }

    }
}