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

      public Map(int mapWidth, int mapHeight, int monsterAmount,int treasureAmount)
      {
        _mapObjects = new List<GameObject>();
        _mapSurface = new ScreenSurface(mapWidth, mapHeight);
        
        _mapSurface.UseMouse = false;

        // _mapSurface.Print(4,4,"hi",Color.Black);
        FillBackground();
      
        UserControlledObject = new GameObject(new ColoredGlyph(Color.White, Color.Black, 64), 
                                            _mapSurface.Surface.Area.Center, _mapSurface);

        for(int i = 0; i < monsterAmount; i++)
        {
          CreateMonster();
        }

        for(int i = 0; i < treasureAmount; i++)
        {
          CreateTreasure();
        }

        CreateDownStairs();
        CreateUpStairs();

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


     public void CreateDownStairs()
      {
        for(int i = 0; i < 100; i++)
        {
          Point randomPosition = new Point(Game.Instance.Random.Next(0,_mapSurface.Width), Game.Instance.Random.Next(0,_mapSurface.Surface.Height));

          bool foundObject = _mapObjects.Any(obj => obj.Position == randomPosition );
          if(foundObject) continue;

         
          GameObject dStair = new GameObject(new ColoredGlyph(Color.White, Color.Black, '>'),
                                                    randomPosition, _mapSurface);
          _mapObjects.Add(dStair);
          break;
        }
      }
      public void CreateUpStairs()
      {
        for(int i = 0; i < 100; i++)
        {
          Point randomPosition = new Point(Game.Instance.Random.Next(0,_mapSurface.Width), Game.Instance.Random.Next(0,_mapSurface.Surface.Height));

          bool foundObject = _mapObjects.Any(obj => obj.Position == randomPosition );
          if(foundObject) continue;

          GameObject uStair = new GameObject(new ColoredGlyph(Color.White, Color.Black, '<'),
                                                    randomPosition, _mapSurface);
          _mapObjects.Add(uStair);
          break;
        }
      }
      public void CreateTreasure()
      {
        for(int i = 0; i < 1000; i++)
        {
          Point randomPosition = new Point(Game.Instance.Random.Next(0,_mapSurface.Width), Game.Instance.Random.Next(0,_mapSurface.Surface.Height));

          bool foundObject = _mapObjects.Any(obj => obj.Position == randomPosition );
          if(foundObject) continue;

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

      public bool TryGetMapObject(Point position, out GameObject gameObject)
      {
        foreach (var otherGameObject in _mapObjects)
        {
          if(otherGameObject.Position == position)
          {
            gameObject = otherGameObject;
            return true;
          }
        }
        gameObject = null;
        return false;
      }

      public void RemoveMapObject(GameObject mapObject)
      {
        if(_mapObjects.Contains(mapObject))
        {
          _mapObjects.Remove(mapObject);
          mapObject.RestoreMap(this);
        }
      }
    }
}