using System;

namespace TheatricalPlayersRefactoringKata
{
    public abstract class Play
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public Play(string name) {
            this._name = name;
        }

        // Cost information may not rightly belong to the play, but it's better than the statement printer!
        abstract public int CalculateCost(int audience);

        public virtual int CalculateCredit(int audience)
        {
            return Math.Max(audience - 30, 0);
        }
    }
}
