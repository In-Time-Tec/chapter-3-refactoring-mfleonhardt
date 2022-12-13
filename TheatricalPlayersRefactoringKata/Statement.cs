using System;
using System.Globalization;

namespace TheatricalPlayersRefactoringKata
{
    public class Statement
    {
        private CultureInfo cultureInfo = new CultureInfo("en-US");
        private string header = "";
        private string body = "";
        private string amountOwed = "";
        private string creditEarned = "";

        public void BuildHeader(string customer)
        {
            header = string.Format("Statement for {0}\n", customer);
        }

        public void BuildPlayRow(Performance performance)
        {
            body += (cultureInfo, "  {0}: {1:C} ({2} seats)\n",
                performance.Play.Name,
                FormatCost(performance.Cost),
                performance.Audience
            );
        }

        private decimal FormatCost(int cost)
        {
            return Convert.ToDecimal(cost / 100);
        }

        public void BuildAmountOwed(int totalAmountOwed)
        {
            amountOwed = String.Format(cultureInfo, "Amount owed is {0:C}\n", FormatCost(totalAmountOwed));
        }

        public void BuildCreditEarned(int totalComedyCredits)
        {
            creditEarned = String.Format("You earned {0} credits\n", totalComedyCredits);
        }

        public string Generate()
        {
            return header + body + amountOwed + creditEarned;
        }
    }
}