using SadConsole;
using SadRogue.Primitives;

namespace SadConsoleGame
{
    internal class StairsDown: GameObject
    {
      public StairsDown(Point position, IScreenSurface hostingSurface)
             : base(new ColoredGlyph(Color.Red, Color.Black, '>'), position, hostingSurface)
      {

      }

      public override bool Touched(GameObject source, Map map)
      {
        return base.Touched(source, map);
      }
    }
}