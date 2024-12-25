using System.Runtime.InteropServices.JavaScript;

namespace BudgetUnitTests;

public class QueryPeriod
{
    public QueryPeriod(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public bool IsInvalid()
    {
        return Start > End;
    }
}

public class Tests
{
    private BudgetService _budgetService;

    [SetUp]
    public void Setup()
    {
        _budgetService = new BudgetService();
    }

    [Test]
    public void invalid_period()
    {
        var start = new DateTime(2024, 1, 2);
        var end = new DateTime(2024, 1, 1);
        var queryPeriod = new QueryPeriod(start, end);
        BudgetShouldBe(queryPeriod, 0);
    }

    private void BudgetShouldBe(QueryPeriod queryPeriod, decimal expectedBudget)
    {
        Assert.That(_budgetService.Query(queryPeriod), Is.EqualTo(expectedBudget));
    }
}

public class BudgetService
{
    public decimal Query(QueryPeriod period)
    {
        if (period.IsInvalid())
        {
            return 0;
        }

        return 0;
    }
}