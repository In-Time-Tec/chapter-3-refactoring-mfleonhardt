using System;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests
{
    public class StatementPrinterTests
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void test_statement_example()
        {
            var plays = new Dictionary<string, Play>();
            plays.Add("hamlet", new TragicPlay("Hamlet"));
            plays.Add("as-like", new ComicPlay("As You Like It"));
            plays.Add("othello", new TragicPlay("Othello"));

            Invoice invoice = new Invoice("BigCo", new List<Performance>{new Performance(plays["hamlet"], 55),
                new Performance(plays["as-like"], 35),
                new Performance(plays["othello"], 40)});
            
            StatementPrinter statementPrinter = new StatementPrinter();
            var result = statementPrinter.Print(invoice, plays);

            Approvals.Verify(result);
        }
    }
}
