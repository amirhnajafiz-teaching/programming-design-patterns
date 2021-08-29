public class BankAccount
{
    public static class Builder
    {
        private long accountNumber;
        private String owner;
        private String branch;
        private double balance;
        private double interestRate;

        public Builder(long accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public Builder withOwner(String owner)
        {
            this.owner = owner;
            return this;  //By returning the builder each time, we can create a fluent interface.
        }

        public Builder atBranch(String branch)
        {
            this.branch = branch;
            return this;
        }

        public Builder openingBalance(double balance)
        {
            this.balance = balance;
            return this;
        }

        public Builder atRate(double interestRate)
        {
            this.interestRate = interestRate;
            return this;
        }

        public BankAccount build()
        {
            // Here we create the actual bank account object,
            // which is always in a fully initialised state when it's returned.
            BankAccount account = new BankAccount();    //Since the builder is in the BankAccount class,
                                                        // we can invoke its private constructor.
            account.accountNumber = this.accountNumber;
            account.owner = this.owner;
            account.branch = this.branch;
            account.balance = this.balance;
            account.interestRate = this.interestRate;
            return account;
        }
    }

    // Original fields
    private long accountNumber;
    private String owner;
    private String branch;
    private double balance;
    private double interestRate;

    private BankAccount() {
        //Constructor is now private.
    }
}