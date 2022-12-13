using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata
{
    public class StatementPrinter
    {
        private Statement statement;
        private int totalAmountOwed = 0;
        private int totalComedyCredit = 0;

        public string Print(Invoice invoice, Dictionary<string, Play> plays)
        {
            InitializeStatement();
            statement.BuildHeader(invoice.Customer);

            foreach(var performance in invoice.Performances) 
            {
                CalculatePerformanceData(performance);
                System.Console.WriteLine(performance.ComedyCredit);
                IncrementTotals(performance);
                statement.BuildPlayRow(performance);
            }

            statement.BuildAmountOwed(totalAmountOwed);
            statement.BuildCreditEarned(totalComedyCredit);

            return statement.Generate();
        }

        private void CalculatePerformanceData(Performance performance)
        {
            performance.CalculateCost();
            performance.CalculateCredit();
        }

        private void InitializeStatement()
        {
            statement = new Statement();
            totalAmountOwed = 0;
            totalComedyCredit = 0;
        }

        private void IncrementTotals(Performance performance)
        {
            totalAmountOwed += performance.Cost;
            totalComedyCredit += performance.ComedyCredit;
        }
    }
}
