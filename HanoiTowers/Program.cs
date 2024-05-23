using HanoiTowers;

var game = new Game();
while (!game.IsSolved())
{
    game.Show();
    var fromIndex = MyConsole.AskForNoAndReturnIndex("Flytte disc fra tårn: ");
    var toIndex = MyConsole.AskForNoAndReturnIndex("Flytte disc til tårn: ");
    game.MoveDisc(fromIndex, toIndex);
}