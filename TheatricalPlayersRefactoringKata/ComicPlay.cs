namespace TheatricalPlayersRefactoringKata
{
    public class ComicPlay : Play
    {
        public ComicPlay(string name) : base(name)
        {
        }

        public override int CalculateCost(int audience)
        {
            var playCost = 30000;
            if (audience > 20) {
                playCost += 10000 + 500 * (audience - 20);
            }
            playCost += 300 * audience;
            return playCost;
        }
    }
}
