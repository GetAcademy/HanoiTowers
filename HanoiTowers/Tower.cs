namespace HanoiTowers
{
    internal class Tower
    {
        private Disc[] _discs;

        public Tower(params int[] discSizes)
        {
            _discs = new Disc[3];
            for (var index = 0; index < discSizes.Length; index++)
            {
                var size = discSizes[index];
                _discs[index] = new Disc(size);
            }
        }

        public Disc GetDisc()
        {
            return null;
        }

        public void ReceiveDisc(Disc disc)
        {
        }

        public void Show()
        {
            
        }
    }
}
