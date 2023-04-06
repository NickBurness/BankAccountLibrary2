using BankAccountLibrary2;
using System.Xml.Linq;

namespace BankAccountLibrary2Tests
{
    public class BankAccountTests
    {
        // arrange
        [Theory]
        [InlineData("Steve", 0, true)]
        [InlineData("St3v3", 0, false)]
        public void AccountName_DoesNotContainNumbers(string name, decimal balance, bool expected)
        {
            var bankAccount = new BankAccount(name, balance);

            // act 
            var result = bankAccount.Validate();

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void StartingBalance_IsCorrectWhenAccountIsCreated()
        {
            // arrange 
            var name = "Nick";
            decimal startingBalance = 10;
            var bankAccount = new BankAccount(name, startingBalance);
            var expected = true;

            // act 
            var result = bankAccount.ValidateStartingBalance();

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WithdrawDoesNotExceedAccountBalance()
        {
            // arrange 
            var name = "Nick";
            var startingBalance = 10;
            decimal withdrawalAmount = 10;
            var bankAccount = new BankAccount(name, startingBalance);
            var expected = 0; // the amount we expect

            // act 
            var result = bankAccount.Withdraw(withdrawalAmount);

            // assert
            Assert.Equal(expected, result);
        }
    }
}