namespace TheatricalPlayersRefactoringKata
{
    public class TragicPlay : Play
    {
        public TragicPlay(string name) : base(name)
        {
        }

        public override int CalculateCost(int audience)
        {
            var playCost = 40000;
            if (audience > 30) {
                playCost += 1000 * (audience - 30);
            }
            return playCost;
        }
    }
}
