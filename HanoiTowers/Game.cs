namespace HanoiTowers
{
    internal class Game
    {
        private readonly Tower[] _towers;

        public Game()
        {
            _towers = new Tower[]
            {
                new Tower(3, 5, 7),
                new Tower(),
                new Tower()
            };
        }

        public void MoveDisc(int fromTowerIndex, int toTowerIndex)
        {
        }

        private Tower FindTower(int towerIndex)
        {
            return null;
        }

        public bool IsSolved()
        {
            return false;
        }

        public void Show()
        {
            foreach (var tower in _towers)
            {
                tower.Show();
            }
        }
    }
}
