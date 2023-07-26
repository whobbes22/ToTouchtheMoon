public class StartScreen : SadConsole.UI.ControlsConsole
{
    public StartScreen() : base(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY)
    {
        int buttonWidth = 25;
        var button1 = new SadConsole.UI.Controls.SelectionButton(buttonWidth, 1);
        var button2 = new SadConsole.UI.Controls.SelectionButton(buttonWidth, 1);
        var button3 = new SadConsole.UI.Controls.SelectionButton(buttonWidth, 1);
        var button4 = new SadConsole.UI.Controls.SelectionButton(buttonWidth, 1);

        // Place button center on the X-axis and then 1/3 the way from the top
        button1.Position = new SadRogue.Primitives.Point(Width / 2 - buttonWidth / 2, Game.Instance.ScreenCellsY / 3);
        button1.Text = "New Game";
        button1.Click += StartGame_Click;
        button1.SetNextSelection(ref button2);

        button2.Text = "Some other button";
        //button2.Click
        button2.PlaceRelativeTo(button1, Direction.Types.Down);
        button2.SetNextSelection(ref button3);

        button3.Text = "Some other button";
        //button3.Click
        button3.PlaceRelativeTo(button2, Direction.Types.Down);
        button3.SetNextSelection(ref button4);

        button4.Text = "Quit";
        button4.Click += Quit_Click;
        button4.PlaceRelativeTo(button3, Direction.Types.Down);
        button4.SetNextSelection(ref button1);

        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(button3);
        Controls.Add(button4);

        button1.IsFocused = true;
    }

    private void Quit_Click(object? sender, EventArgs e)
    {

    }
  

    private void StartGame_Click(object? sender, EventArgs e)
    {
        // Change the active game screen
        //Game.Instance.Screen = ...
    }
}