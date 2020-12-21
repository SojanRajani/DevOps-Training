Feature: Finding the balance in Account
         When I withdraw an amount from the given account balance    
         The resultant balance should be displayed.

Scenario Outline: When im withdrawing cash
    Given There is <AccountBalance> in my account
    When I withdraw <Amount> from my account
    Then The balance in my account is <Balance>

        Examples:
            | AccountBalance | Amount | Balance |
            | 10000          | 5000   | 5000    |
            | 15000          | 2000   | 13000   | 
