using SadConsole;
using SadRogue.Primitives;

namespace SadConsoleGame
{
    public class GameObject
    {
        public Point Position { get; private set; }

        public ColoredGlyph Appearance { get; set; }

        public GameObject(ColoredGlyph appearance, Point position, IScreenSurface hostingSurface)
        {
            Appearance = appearance;
            Position = position;
            DrawGameObject(hostingSurface);
        }

        private void DrawGameObject(IScreenSurface screenSurface)
        {
            Appearance.CopyAppearanceTo(screenSurface.Surface[Position]);
            screenSurface.IsDirty = true;
        }

        public void Move(Point newPosition, IScreenSurface screenSurface)
        { 
            Position = newPosition;
            DrawGameObject(screenSurface);
        }
    }
}