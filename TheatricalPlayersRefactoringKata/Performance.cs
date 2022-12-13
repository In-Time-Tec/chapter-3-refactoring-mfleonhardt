namespace TheatricalPlayersRefactoringKata
{
    public class Performance
    {
        private int _audience;
        private int _cost;
        private int _comedyCredit;
        private Play _play;

        public int Audience { get => _audience; set => _audience = value; }
        public int Cost { get => _cost; set => _cost = value; }
        public int ComedyCredit { get => _comedyCredit; set => _comedyCredit = value; }
        public Play Play { get => _play; set => _play = value; }

        public Performance(Play play, int audience)
        {
            this._play = play;
            this._audience = audience;
        }

        public void CalculateCost()
        {
            _cost  = _play.CalculateCost(_audience);
        }

        public void CalculateComedyCredit()
        {
            _comedyCredit = _play.CalculateComedyCredit(_audience);
        }
    }
}
