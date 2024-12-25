using System.Runtime.InteropServices.JavaScript;

namespace BudgetUnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void invalid_period()
    {
        var budgetService = new BudgetService();
        var budget = budgetService.Query(new DateTime(2024,1,2), new DateTime(2024,1,1));
        Assert.AreEqual(0, budget);
    }
}

public class BudgetService
{
    public decimal Query(DateTime start, DateTime end)
    {
        if (start > end)
        {
            return 0;
        }

        return 0;
    }
}