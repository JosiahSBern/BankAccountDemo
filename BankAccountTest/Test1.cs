using Ban
namespace BankAccountTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Debit_WithValidAmount()
    {
        // Arrange
        double startingBalance = 11.99;
        double debitAmmount = 4.55;
        double expected = 7.44;

        BankAccount account = new BankAccount("Mr. Bryan Walton", startingBalance);

        // Act
        account.Debit(debitAmmount);


        // Assert
        double actual 


    }
}
